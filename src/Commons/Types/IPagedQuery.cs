namespace AdvancedInfoService.Mimo.GitLabService.Commons.Types
{
    public interface IPagedQuery : IQuery
    {
        int Page { get; }
        int PerPage { get; }
    }
}