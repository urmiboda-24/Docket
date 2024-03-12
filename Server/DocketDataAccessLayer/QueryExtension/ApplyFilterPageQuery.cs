using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocketCommon.Constants;
using DocketEntities.Request;

namespace DocketDataAccessLayer.QueryExtension
{
    public static class ApplyFilterPageQuery
    {
        public static IQueryable<T> ApplyQuery<T>(this IQueryable<T> query, PageRequest request)
        {
            int pageSize = request.PageSize;
            int pageNumber = request.PageNumber;

            if (pageSize < 1) throw new ArgumentOutOfRangeException(nameof(pageSize), ErrorMessages.PAGE_SIZE);
            if (pageNumber < 1) throw new ArgumentOutOfRangeException(nameof(pageNumber), ErrorMessages.PAGE_NUMBER);

            int skip = (pageNumber - 1) * pageSize;

            return
                query
                .Skip(skip)
                .Take(pageSize);
        }
    }
}