using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocketCommon.Utils;
using DocketEntities.DataModels;

namespace DocketDataAccessLayer.DataSeed
{
    public class DefaultUserRole
    {
        public static List<UserRole> ListUserRole()
        {
            return new List<UserRole>()
            {
                new UserRole()
                {
                    Id = 1,
                    RoleId=1,
                    UserId=1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy =1,
                    CreatedOn=DateTimeHelper.DateTimeOffsetHelper
                }
            };
        }
    }
}