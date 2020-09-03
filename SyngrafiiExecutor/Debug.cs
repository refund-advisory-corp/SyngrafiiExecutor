using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace SyngrafiiExecutor
{
    class DebugClass
    {
        public static void Jot(List<string> Infos)
        {
            string DirectoryPath;
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string unescapedpath = Uri.UnescapeDataString(uri.Path);
            DirectoryPath = System.IO.Path.GetDirectoryName(unescapedpath);
            DirectoryPath = System.IO.Path.GetDirectoryName(DirectoryPath);
            string ErrorLogFilePath0 = DirectoryPath + "\\ErrorLog.txt";
            if (!File.Exists(ErrorLogFilePath0))
            {
                using (StreamWriter writer = File.CreateText(ErrorLogFilePath0))
                {
                    writer.WriteLine("--Error Log for REFFORMZ program--");
                }
            }
            using (StreamWriter writer2 = File.AppendText(ErrorLogFilePath0))
            {
                writer2.WriteLine("----------------------------------------------------------------------");

                foreach (string Info in Infos)
                {
                    writer2.WriteLine(Info);
                }
            }
        }
    }
}
