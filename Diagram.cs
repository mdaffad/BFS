using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
namespace src
{
    class Diagram
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        public Diagram(int a)
        {
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./LogFile.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            int input = a;
            Graph g = new Graph();
            FileHandler f = new FileHandler();
            string path = System.IO.Directory.GetCurrentDirectory();
            System.IO.DirectoryInfo directoryInfo =
                    System.IO.Directory.GetParent(path);
            directoryInfo =
                    System.IO.Directory.GetParent(directoryInfo.FullName);

            f.readPopulation(g, directoryInfo.FullName + "/Populasi.txt", input);
            f.readGraph(g, directoryInfo.FullName + "/Graf.txt");
            g.BFS(input);
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();

        }
    }
}
