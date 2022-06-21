using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretformproje.Classlar
{
    internal class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AddDate { get; set; }
    }
}
