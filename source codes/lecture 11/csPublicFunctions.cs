using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_11
{
    public static class csPublicFunctions
    {
        public static char crUsernamePasswordSeperator = ';';
        public static bool checkUserExists(string srUserName)
        {
            bool blExists = false;
            foreach (var vrLine in File.ReadLines("users.txt"))
            {
                if(vrLine.Split(crUsernamePasswordSeperator)[0]==srUserName)
                {
                    blExists = true;
                    break;
                }
            }
            return blExists;
        }

        public static bool checkPasswordTrue(string srUserName, string srPassword)
        {
            string srHashedpw = encrtpy.ComputeSha256Hash(srPassword);

            bool blCorrectPw = false;
            foreach (var vrLine in File.ReadLines("users.txt"))
            {
                var vrSplitP = vrLine.Split(crUsernamePasswordSeperator);

                if (vrSplitP[0] == srUserName)
                {
                    if(vrSplitP[1]==srHashedpw)
                    {
                        blCorrectPw = true;
                    }
                    break;
                }
            }
            return blCorrectPw;
        }
    }
}
