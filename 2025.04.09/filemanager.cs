using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025._04._09
{
    public class filemanager
    {
        string filename;

        public filemanager(string filename)
        {
            this.filename = filename;
        }

        public void writeoneline(int db,string pastatype,string filling)
        {
           
            using (StreamWriter write = new StreamWriter(filename, true, Encoding.UTF8))
            {
                write.Write($"\n{db};{pastatype};{filling}");
            }
        }
    }
    
}
