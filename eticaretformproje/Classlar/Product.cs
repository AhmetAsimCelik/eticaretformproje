using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretformproje.Classlar
{
    internal class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }

        public string UnitStock { get; set; }

        public string BrandID { get; set; }
        public Brand Brand { get; set; }
        public string AddDate { get; set; }
        public string UpdateDate { get; set; }


    }
}
