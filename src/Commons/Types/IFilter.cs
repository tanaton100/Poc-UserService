using System.Collections.Generic;

namespace AdvancedInfoService.Mimo.GitLabService.Commons.Types
{
    public interface IFilter<TResult, in TQuery> where TQuery : IQuery
    {
        IEnumerable<TResult> Filter(IEnumerable<TResult> values, TQuery query);
    }
}