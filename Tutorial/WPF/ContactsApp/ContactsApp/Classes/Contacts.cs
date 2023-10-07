using ServiceStack.DataAnnotations;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Classes
{
    internal class Contacts
    {
        [PrimaryKey , AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        
        public string Phone { get; set; }


        public override string ToString()
        {
            return $"{Name} - {Email} - {Phone}";
        }
    }
}
