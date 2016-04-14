using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsInfo.Models
{
    public class FellowStudents
    {
        public string Name { get; set; }
        public string HairColor { get; set; }
        public string Height { get; set; }

        public FellowStudents(string name, string haircolor, string height)
        {
            Name = name;
            HairColor = haircolor;
            Height = height;
        }
    }
}