using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMain.Classes
{
    internal class Builds
    {
        public static void BuildHandler(string buildName, string picture)
        {
            if (buildName.Contains("7"))
            {
                picture = "";
            }
        }
    }
}
