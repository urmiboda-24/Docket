using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocketCommon.Utils;
using DocketEntities.DataModels;

namespace DocketDataAccessLayer.DataSeed
{
    public class DefaultUser
    {
        public static List<User> ListUser()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "System",
                    LastName="Admin",
                    Password = "1zQBjROCRd9VaLvXgIuVNH56MVuW0X41IsyoU3sWXxYY9rYwinc1QixtB4MRZJIL",
                    Email = "system.admin@gmail.com",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = 1,
                    CreatedOn = DateTimeHelper.DateTimeOffsetHelper
                }
            };
        }
    }
}