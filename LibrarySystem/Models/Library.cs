using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Library
    {
        //the attributes that need to be filled
        public int Id { get; set; } // id for library 
        public string Name { get; set; } //  Name for person
        public int LibraryPopulation { get; set; } // add population in the library 
        public string LibraryAddress { get; set; } // Address  for the person 
    }
}
