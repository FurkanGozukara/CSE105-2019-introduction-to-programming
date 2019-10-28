using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_8_panels
{
    public static class RandomNumberList
    {
        static Random myRandom = new Random();
        private static List<int> returnNumberList()
        {
            List<int> lstReturn = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lstReturn.Add(myRandom.Next());
            }
            return lstReturn;
        }

        public static List<string> returnNumbers()
        {
            List<string> lstReturnList = new List<string>();
            foreach (var item in returnNumberList())
            {
                lstReturnList.Add(item.ToString("N0"));
            }
            return lstReturnList;
        }
    }
}
