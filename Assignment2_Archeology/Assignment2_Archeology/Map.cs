using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Archeology
{
    public class Map
    {
        public int MapNum = 6;
        public string name = "map";
        public Map()
        {

        }

/*        public override string getResourceId()
        {
            Console.WriteLine("이 카드는 " + name);
            return name;
        }*/



        public override string ToString()
        {
            return name;
        }
    }
}
