namespace Northwind.DataSource
{
    public class DataProvider
    {
        private string _connection;
        private NorthwindDataContext _db;

        public DataProvider()
        {
            _connection = "Data Source=.;Initial Catalog=northwind;Integrated Security=True;User Instance=False";
            _db = new NorthwindDataContext(_connection);            
        }

        public NorthwindDataContext DataContext
        {
            get { return _db; }
        }
    }
}
