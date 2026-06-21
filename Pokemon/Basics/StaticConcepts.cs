using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Basics
{
    internal class Song
    {
        public string name;
        public int duration;
        public string singer;
        public static int songCount=0; // Writing a Static count variable

        // Defining the Constructor
        public Song(string sname, int sduration, string singername) {
            name = sname;
            duration = sduration;
            singer = singername;
            songCount++; // It will be incremented everytime an instance is being created of a Song 
        }


        //Defining a static MethodA for the same 
        public int GetsongCount() {
            return songCount;
        }
    }
}
