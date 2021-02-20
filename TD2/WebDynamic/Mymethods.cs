using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDynamic
{
    class Mymethods
    {
        public Mymethods()
        {
        }

        static public String displayParams(String param1, String param2)
        {
            return "<HTML><BODY> Hello " + param1 + " et " + param2 + "</BODY></HTML>";
        }

        static public String Executable(String param1, String param2)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\Users\\yaho2\\source\\repos\\eiin839\\TD2\\Executable\\bin\\Debug\\Executable.exe"; // Specify exe name.
            start.Arguments = $"{param1} {param2}"; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }
    }
}
