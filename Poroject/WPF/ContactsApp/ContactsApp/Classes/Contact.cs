using ServiceStack.DataAnnotations;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIncrementAttribute = SQLite.AutoIncrementAttribute;
using PrimaryKeyAttribute = SQLite.PrimaryKeyAttribute;

namespace ContactsApp.Classes
{
    public class Contact
    {
        [PrimaryKey , AutoIncrement]
        public int Id { get; set; }

        public  string Name { get; set; }

        public  string EmailAddress { get; set; }
        
        public  string Phone { get; set; }


        public override string ToString()
        {
            return $"{Name} - {EmailAddress} - {Phone}";
        }
    }
}
