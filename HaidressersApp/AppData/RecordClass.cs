using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaidressersApp.AppData
{
    public class RecordClass
    {
        public string Date { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public RecordClass(string _date, string _surname, string _name, string _title)
        {
            this.Date = _date;
            this.Surname = _surname;
            this.Name = _name;
            this.Title = _title;
        }
    }
}
