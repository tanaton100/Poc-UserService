namespace AdvancedInfoService.Mimo.GitLabService.Commons.Types
{
    public abstract class PagedQueryBase : IPagedQuery
    {
        public string Filter { get; set; }
        public int Page { get; set; } = 1;
        public int PerPage { get; set; } = 10;
        public bool? SortDesc { get; set; }
        public string SortColumn { get; set; }
    }
}