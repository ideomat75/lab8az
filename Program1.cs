using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename, dir, arch;
            
            Console.WriteLine("Enter file name");
            filename = Console.ReadLine();

            Console.WriteLine("Enter dir");
            dir = Console.ReadLine();

            Console.WriteLine("Arch(a) or no");
            arch = Console.ReadLine();

            string[] all = Directory.GetFiles(dir, filename, SearchOption.AllDirectories);

            if (all.Length == 0)
                Console.WriteLine("No file");

            if (all.Length > 1)
                foreach(var f in all)
                    Console.WriteLine(f);

            if (all.Length == 1)
            {
                FileStream fs = new FileStream(all[0], FileMode.Open);

                if (arch == "a")
                {
                    Console.WriteLine("Enter full file name");
                    string resfile = Console.ReadLine();

                    GZipStream gZipStream = new GZipStream(File.Create(resfile), CompressionMode.Compress);
                    fs.CopyTo(gZipStream);
                }
                else
                {
                    for (int i = 0; i < fs.Length; i++)
                        Console.Write((char)fs.ReadByte());
                }
            }
        }
    }
}
