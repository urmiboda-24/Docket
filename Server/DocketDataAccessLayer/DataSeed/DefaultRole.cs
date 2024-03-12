using DocketCommon.Utils;
using DocketEntities.DataModels;

namespace DocketDataAccessLayer.DataSeed
{
    public class DefaultRole
    {
        public static List<Role> ListRole()
        {
            return new List<Role>()
            {
                new Role()
                {
                    Id = 1,
                    Name ="SystemAdmin",
                    IsSystemAdmin = true,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy =1,
                    CreatedOn=DateTimeHelper.DateTimeOffsetHelper
                },
                new Role()
                {
                    Id = 2,
                    Name ="Student",
                    IsSystemAdmin = false,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy =1,
                    CreatedOn=DateTimeHelper.DateTimeOffsetHelper
                }
            };
        }
    }
}