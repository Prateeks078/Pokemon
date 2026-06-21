using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Basics
{
    internal class Movie
    {
        public string name;
        private int rating;// Making it private for not disturbing it outside this class..
        public string actor;

        // Writing a Constructor
        public Movie(string mname,int mrating,string mactor) {
            name = mname;
            Rating = mrating;
            actor = mactor;
        }

        //  Getter-Setters
        public int Rating {
            get  { return rating; }
            set { if (value >= 0) rating=value; }
        }
    }
}
