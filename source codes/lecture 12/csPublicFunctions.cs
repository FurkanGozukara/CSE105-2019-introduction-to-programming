using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lecture_12
{
  public static  class csPublicFunctions
    {
        public static void appendToLogFile(string srUserName, string srText)
        {
            File.AppendAllText(srUserName + ".txt", srText + "\r\n");
        }

        public static void readToListBox(MainWindow mm,string srUserName)
        {
            if (!File.Exists(srUserName + ".txt"))
                return;
            mm.lstBoxUserLogs.Items.Clear();
            List<string> lstUserLogs = File.ReadAllLines(srUserName + ".txt").ToList();
            lstUserLogs.Reverse();
            foreach (var item in lstUserLogs)
            {
                mm.lstBoxUserLogs.Items.Add(item);
            }
           
        }
    }
}
