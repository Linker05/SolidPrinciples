using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class FileTextReader
    {
        public FileTextReader()
        {

        }

        public string ReadText(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open))
            using (var sr = new StreamReader(fs))
                return sr.ReadToEnd();
        }
    }
}
