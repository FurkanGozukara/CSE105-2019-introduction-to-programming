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
        public static Dictionary<string, userVals> dicUserValues = new Dictionary<string, userVals>();

            static csPublicFunctions()
        {
            foreach (var vrLine in File.ReadLines("users.txt"))
            {
                userVals myTempUser = new userVals();
                myTempUser.srUserPassword = vrLine.Split(';')[1];

                var vrLogFilepath = vrLine.Split(';').First() + ".txt";
                if (File.Exists(vrLogFilepath))
                {
                    myTempUser.lstUserLogs.AddRange(File.ReadAllLines(vrLogFilepath).ToList());
                }
                dicUserValues.Add(vrLine.Split(';').First(), myTempUser);
            }
        }

        public class userVals
        {
            public string srUserPassword = "";
            public List<string> lstUserLogs = new List<string>();
        }

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
