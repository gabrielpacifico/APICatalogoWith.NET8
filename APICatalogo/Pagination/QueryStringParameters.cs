namespace APICatalogo.Pagination
{
    public abstract class QueryStringParameters
    {
        const int maxPagSize = 50;
        public int pageNumber { get; set; } = 1;
        private int _pageSize = maxPagSize;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPagSize) ? maxPagSize : value;
            }
        }
    }
}
