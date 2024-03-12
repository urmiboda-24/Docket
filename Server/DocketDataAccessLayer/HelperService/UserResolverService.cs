using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DocketDataAccessLayer.HelperService
{
    public class UserResolverService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserResolverService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public long UserID => long.Parse(FindClaim(ClaimTypes.NameIdentifier));

        public string UserName => FindClaim(ClaimTypes.Name);

        private string? FindClaim(string claimName)
        {
            ClaimsIdentity? claimsIdentity = _httpContextAccessor.HttpContext?.User.Identity as ClaimsIdentity;
            bool isAuthenticated = _httpContextAccessor.HttpContext?.User.Identity?.IsAuthenticated ?? false;

            if (isAuthenticated is not true) throw new UnauthorizedAccessException();

            Claim? claim = claimsIdentity?.FindFirst(claimName);
            if (claim == null)
            {
                return null;
            }
            return claim.Value;
        }
    }
}