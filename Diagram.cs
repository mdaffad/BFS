using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

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
            

        }
    }
}
