using Northwind.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities
{
    public class Territories
    {
        public class Territory
        {
            public string TerritoryID { get; set; }
            public string TerritoryDescription { get; set; }
            public int RegionID { get; set; }
        }

        private readonly DataProvider _provider;
        private System.Data.Linq.Table<Northwind.DataSource.Territory> _territories;

        public Territories()
        {
            _provider = new DataProvider();
            _territories = _provider.DataContext.Territories;
        }

        public IEnumerable<Territory> GetAllTeritorries
        {
            get
            {
                return _territories.Select(e => new Territory
                {
                    TerritoryID = e.TerritoryID,
                    TerritoryDescription = e.TerritoryDescription,
                    RegionID = e.RegionID
                });
            }
        }

        public int GetTerritoriesCount
        {
            get { return _territories.Count(); }
        }
    }
}
