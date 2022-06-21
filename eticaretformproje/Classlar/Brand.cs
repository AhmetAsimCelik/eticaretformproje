using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretformproje.Classlar
{
    internal class Brand
    {
        public string BrandID { get; set; }

        public string BrandName { get; set; }

        public string Origin { get; set; }
        public string CategoryID { get; set; }

        public Category Category { get; set; }
        public string AddDate { get; set; }

        public string UpdateDate { get; set; }


    }
}
