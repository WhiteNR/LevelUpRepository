using Northwind.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities
{
    public class Customers
    {
        public class Customer
        {
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string Country { get; set; }
        }

        private readonly DataProvider _provider;
        private System.Data.Linq.Table<Northwind.DataSource.Customer> _customers;

        public Customers()
        {
             _provider = new DataProvider();
            _customers = _provider.DataContext.Customers;
        }

        public IEnumerable<Customer> GetAllCustomers
        {
            get
            {
                return _customers.Select(e => new Customer
                {
                    CustomerID = e.CustomerID,
                    CompanyName = e.CompanyName,
                    ContactName = e.ContactName
                });
            }
        }

        public IEnumerable<string> GetCustomersCountries
        {
            get
            {
                return _customers.Select(e => e.Country).Distinct();
            }
        }

        public IEnumerable<Customer> GetCustomersInCountry(string country)
        {
            return _customers.Select(customers => new Customer
            {
                CustomerID = customers.CustomerID,
                CompanyName = customers.CompanyName,
                ContactName = customers.ContactName,
                Country = customers.Country
            }).Where(customers => customers.Country == country);
        }

        //public IEnumerable<int> GetCustomersInCountryGroup
        //{
        //    get
        //    {
        //        return _customers from 
        //    }
        //}

        public int GetCustomersCount
        {
            get { return _customers.Count(); }
        }
    }
}
