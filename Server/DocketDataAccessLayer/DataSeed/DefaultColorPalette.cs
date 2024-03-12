using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocketCommon.Utils;
using DocketEntities.DataModels;

namespace DocketDataAccessLayer.DataSeed
{
    public class DefaultColorPalette
    {
        public static List<ColorPalette> ListColorPalette()
        {
            return new List<ColorPalette>()
            {
                new()
                {
                    Id = 1,
                    Name ="#AD88C6",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy =1,
                    CreatedOn=DateTimeHelper.DateTimeOffsetHelper
                },
                new()
                {
                    Id = 2,
                    Name ="#E493B3",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy =1,
                    CreatedOn=DateTimeHelper.DateTimeOffsetHelper
                },
                new()
                {
                    Id = 3,
                    Name ="#BFD8AF",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy =1,
                    CreatedOn=DateTimeHelper.DateTimeOffsetHelper
                },
                 new()
                {
                    Id = 4,
                    Name ="#7BD3EA",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy =1,
                    CreatedOn=DateTimeHelper.DateTimeOffsetHelper
                }
            };
        }
    }
}