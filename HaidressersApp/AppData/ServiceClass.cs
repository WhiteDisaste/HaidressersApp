using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaidressersApp.AppData
{
    public class ServiceClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public ServiceClass(int _id, string _name, string _price)
        {
            this.Id = _id;
            this.Name = _name;
            this.Price = _price;
        }   
    }
}
