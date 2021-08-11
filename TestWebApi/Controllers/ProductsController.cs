using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestWebApi.Models;

// Above are Required Namespace for our code what we are going to write below

namespace TestWebApi.Controllers
{

    [Produces("application/json")] // Api Type is application/json
    [Route("api/products")] // Base URL https://localhost:5001/api/products
    public class ProductsController
    {
        Products[] products = new Products[]{


            new Products {Code = "014600301",
             Description = "BARILLA FARINA 1 KG",
             Um = "PZ",
             PcCart = 24,
              NetWeight = 1,
              Price = 1.09},

                //          {
                //     "code": "014600301",
                //     "description": "BARILLA FARINA 1 KG",
                //     "um": "PZ",
                //     "codStat": null,
                //     "pcCart": 24,
                //     "netWeight": 1,
                //     "state": null,
                //     "creationDate": "0001-01-01T00:00:00",
                //     "price": 1.09
                // }



            new Products {Code = "013500121", Description = "BARILLA PASTA GR.500 N.70 1/2 PENNE", Um = "PZ", PcCart = 30, NetWeight = 0.5, Price = 1.3 },
            new Products {Code = "007686402", Description = "FINDUS FIOR DI NASELLO 300 GR", Um = "PZ", PcCart = 8, NetWeight = 0.3, Price = 6.46 },
            new Products {Code = "057549001", Description = "FINDUS CROCCOLE 400 GR", Um = "PZ", PcCart = 12, NetWeight = 0.4, Price = 5.97 }
            // And These are dummy Data Actually it should come from Database. But , In this Tutorial we are Hard Coding It;

    };
        [HttpGet] // Using Get Method // Base URL
        public IEnumerable<Products> ListAllProducts()
        {
            return products;

            // We are returing All products when user hit the base url
        }

        [HttpGet("code/{codart}")] // We need to Add "https://localhost:5001/api/products/code/014600301" in URL to get the details for that particular Code; The Double Quoted Url will return the Details :: Code = "014600301", Description = "BARILLA FARINA 1 KG",Um = "PZ",PcCart = 24, NetWeight = 1, Price = 1.09

        public IEnumerable<Products> ListProductByCode(string codart)
        {
            IEnumerable<Products> retVal =
            from g in products
            where g.Code.Equals(codart)  // Here we are querying the data which is Equal to that Particular Code; We can say as ID
            select g;

            return retVal;
        }

        //We are going to do the Same for Description Query also
        [HttpGet("description/{desart}")]
        public IEnumerable<Products> ListProductsByDescription(string desart)
        {
            IEnumerable<Products> retVal =
            from g in products
            where g.Description.ToUpper().Contains(desart.ToUpper()) // Converting All string to same case and Check either the result Contains that word Or Not
            orderby g.Code
            select g;
            return retVal;

        }

    }
}

// Now we are going to Run the App 
// So it returning All the Products because of ListAllProducts() This Method;
// Lets Check using Code
// We are getting Same Date 


//Lets Check for Description Also
// So URL will be
// https://localhost:5001/api/products/description/FINDUS

// Here we must receive two Data

// Results are as Expected 

// Q and A;
// Thanks for watching......