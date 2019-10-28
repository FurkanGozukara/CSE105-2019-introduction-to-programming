using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_8_panels
{
  public  class nonStaticRandomNumberList
    {
        Random myRandom = new Random();
        private List<int> returnNumberList()
        {
            List<int> lstReturn = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lstReturn.Add(myRandom.Next());
            }
            return lstReturn;
        }

        private List<int> returnNumberList2()
        {
            return null;
        }

        private List<int> returnNumberList3()
        {
            return new List<int>();
        }

        private void returnNumberList4()
        {
             
        }

        public List<string> returnNumbers()
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
