using System.Collections.Generic;

namespace AdvancedInfoService.Mimo.GitLabService.Commons.Types
{
    public interface IPagedFilter<TResult, in TQuery> where TQuery : IQuery
    {
        PageResult<TResult> Filter(IEnumerable<TResult> values, TQuery query);
    }
}