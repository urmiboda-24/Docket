using System.Security.Claims;
using DocketDataAccessLayer.DataSeed;
using DocketEntities.DataModels;
using DocketEntities.DataModels.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DocketDataAccessLayer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserDocument> UserDocuments { get; set; }
        public virtual DbSet<UserPalette> UserPalettes { get; set; }
        public virtual DbSet<ColorPalette> ColorPalettes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
              .HasMany(u => u.UserRoles)
              .WithOne(ur => ur.User)
              .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
               .HasOne(ur => ur.User)
               .WithMany(u => u.UserRoles)
               .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
               .HasOne(ur => ur.Role)
               .WithMany()
               .HasForeignKey(ur => ur.RoleId);

            modelBuilder.Entity<Role>()
             .HasMany(u => u.UserRoles)
             .WithOne(ur => ur.Role)
             .HasForeignKey(ur => ur.RoleId);

            // modelBuilder.Entity<UserPalette>().HasOne(up => up.User).WithMany().HasForeignKey(up => up.UserId);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            IHttpContextAccessor httpContextAccessor = this.GetService<IHttpContextAccessor>();
            int userId = int.Parse(httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");

            if (userId != 0)
            {
                IEnumerable<EntityEntry> entries = ChangeTracker
                    .Entries()
                     .Where(e => IsAuditEntity(e.Entity.GetType()) &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

                foreach (var entityEntry in entries)
                {
                    if (IsAuditEntity(entityEntry.Entity.GetType()))
                    {
                        var auditEntity = (dynamic)entityEntry.Entity;
                        if (entityEntry.State == EntityState.Modified)
                        {
                            auditEntity.UpdatedBy = userId;
                            if (auditEntity.IsDeleted == true)
                                auditEntity.DeletedOn = DateTimeOffset.UtcNow;
                            else
                                auditEntity.UpdatedOn = DateTimeOffset.UtcNow;
                        }
                        if (entityEntry.State == EntityState.Added)
                        {
                            auditEntity.CreatedOn = DateTimeOffset.UtcNow;
                            auditEntity.CreatedBy = userId;
                        }
                    }
                }
            }
            else
            {
                IEnumerable<EntityEntry> entries = ChangeTracker
                    .Entries()
                     .Where(e => IsAuditEntity(e.Entity.GetType()) &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

                foreach (var entityEntry in entries)
                {
                    if (IsAuditEntity(entityEntry.Entity.GetType()))
                    {
                        var auditEntity = (dynamic)entityEntry.Entity;
                        if (entityEntry.State == EntityState.Added)
                        {
                            auditEntity.CreatedOn = DateTimeOffset.UtcNow;
                        }
                    }
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        private bool IsAuditEntity(Type entityType)
        {
            var baseType = entityType.BaseType;
            while (baseType != null)
            {
                if (baseType.IsGenericType &&
                    baseType.GetGenericTypeDefinition() == typeof(AuditEntity<>))
                {
                    return true;
                }
                baseType = baseType.BaseType;
            }
            return false;
        }

    }
}