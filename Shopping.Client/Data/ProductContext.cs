using System.Collections.Generic;
using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public class ProductContext
    {
        public static readonly List<Products> Products = new List<Products>
        {
            new Products()
            {
            Id = 1,
            Name = "Iphone 13",
            Description = "asfafsadd",
            ImageFile = "aabdfbsd.png",
            Category = "adbfdbsd"
            },
            new Products()
            {
            Id = 2,
            Name = "Samsung S22",
            Description = "asfafafvd",
            ImageFile = "aasdzxcz.png",
            Category = "abdfbsd"
            },
            new Products()
            {
            Id = 3,
            Name = "Xiaomi Mi 11",
            Description = "aafdadsd",
            ImageFile = "aasgsgd.png",
            Category = "asgvsdvd"
            },
            new Products()
            {
            Id = 4,
            Name = "Redmi 11",
            Description = "asxcbvxd",
            ImageFile = "aasbcvxbd.png",
            Category = "asnfgnd"
            },
            new Products()
            {
            Id = 1,
            Name = "Motorola G200",
            Description = "fngfgnasd",
            ImageFile = "aanfgnsd.png",
            Category = "asnfgnd"
            }
            //this is a new comment for creating the QA branch
            //this is another branch for creating the dev branch
        };
    }
}
