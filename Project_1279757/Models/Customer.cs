using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279757.Models
{
    public class Customer : BaseEntity
    {
        public Customer() { }
        public Customer(int id,string Name, string ContactNo, string Adress) 
        {
            this.Name=Name;
            this.ContactNo = ContactNo;
            this.Adress = Adress;
        }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Adress { get; set; }

    }
}
