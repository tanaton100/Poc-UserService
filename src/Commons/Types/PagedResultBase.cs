namespace AdvancedInfoService.Mimo.GitLabService.Commons.Types
{
    public abstract class PagedResultBase
    {
        public int Page { get; }
        public int PerPage { get; }
        public int TotalPage { get; }
        public int TotalRecord { get; }

        protected PagedResultBase()
        {
        }

        protected PagedResultBase(int currentPage, int resultsPerPage,
            int totalPages, int totalResults)
        {
            Page = currentPage > totalPages ? totalPages : currentPage;
            PerPage = resultsPerPage;
            TotalPage = totalPages;
            TotalRecord = totalResults;
        }
    }
}