using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEnjoyer
{
    internal class Helper
    {
        public static void ForEachLoop<T>(IEnumerable<T> gameList)
        {
            foreach(var game in gameList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
