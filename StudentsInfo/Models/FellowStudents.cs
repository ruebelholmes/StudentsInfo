using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsInfo.Models
{
    public class FellowStudents
    {
        private string v;

        public string Name { get; set; }
        public string HairColor { get; set; }
        public int HeightFeet { get; set; }
        public int HeightInches { get; set; }

       

        public FellowStudents( string name, string haircolor, int heightFeet, int heightInches)
        {
            Name = name;
            HairColor = haircolor;
            HeightFeet = heightFeet;
            HeightInches = heightInches;
        }

        public FellowStudents(string v)
        {
            this.v = v;
        }
    }
}