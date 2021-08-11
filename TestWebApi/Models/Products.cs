using System;
namespace TestWebApi.Models
{
    public class Products
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Um { get; set; }
        public string CodStat { get; set; }
        public int PcCart { get; set; }
        public double NetWeight { get; set; }
        public string State { get; set; }
        public DateTime CreationDate { get; set; }
        public double Price { get; set; }
    }
}

// This class contains all the properties we can get from a relational database like MySQL or PostgreSQL but, in this tutorial, we’ll insert data using a specific method without connecting app to a DBMS.

// Hope you read above Comment