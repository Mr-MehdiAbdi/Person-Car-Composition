using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PersonCarComposition.Bad_Design
{
    public class Person
    {
        /*Personal Information*/
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string NaCode { get; set; }
        public string BirthDate { get; set; }

        /*First Car*/
        public string Car1Model { get; set; }
        public string Car1Color { get; set; }
        public string Car1Year { get; set; }
        public string Car1plateNumber { get; set; }

        /*Second Car*/
        public string Car2Model { get; set; }
        public string Car2Color { get; set; }
        public string Car2Year { get; set; }
        public string Car2plateNumber { get; set; }

    }
}
