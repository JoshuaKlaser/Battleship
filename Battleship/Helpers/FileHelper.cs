using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Helpers
{
    public class FileHelper
    {
        private static readonly string ExeLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static string GetExecutableFilePath(string fileAndPath)
        {
            return ExeLocation + fileAndPath;
        }
    }
}
