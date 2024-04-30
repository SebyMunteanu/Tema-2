using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Tema2Console
{
    public class FileHandler
    {
        public string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
