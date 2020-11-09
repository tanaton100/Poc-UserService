using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace AdvancedInfoService.Mimo.GitLabService.Commons.Types
{
    public class PageResult<T> : PagedResultBase
    {
        public IEnumerable<T> Items { get; }

      
        protected PageResult()
        {
            Items = Enumerable.Empty<T>();
        }

        [JsonConstructor]
        protected PageResult(IEnumerable<T> items,
            int currentPage, int resultsPerPage,
            int totalPages, int totalResults) :
                base(currentPage, resultsPerPage, totalPages, totalResults)
        {
            Items = items;
        }

        public static PageResult<T> Create(IEnumerable<T> items,
            int currentPage, int resultsPerPage,
            int totalPages, int totalResults)
            => new PageResult<T>(items, currentPage, resultsPerPage, totalPages, totalResults);

        public static PageResult<T> From(PagedResultBase result, IEnumerable<T> items)
             => new PageResult<T>(items, result.Page, result.PerPage,
                result.TotalPage, result.TotalRecord);

        public static PageResult<T> Empty => new PageResult<T>();

      
    }
}