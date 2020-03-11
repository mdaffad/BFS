using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Msagl;
namespace src
{   
    class City
    {
        // PROPERTY
        public char cityName { get; set; } // Nama Kota ; A
        public double population { get; set; } // Populasi Kota ; P(A)
        public List<Neighbor> listOfNeighbor { get; set; } // Container Tetangga
        public int infectedDay { get; set; } // Hari awal terinfeksi ; T(A)
        public int infectedDuration {get; set;} // Durasi Terinfeksi hingga akhir perhitungan; t(A)
        public double infectedPopulation { get; set; } // Populasi yang terinfeksi
        public bool infected { get; set; } // Apakah kota sudah terinfeksi

        public char infectedFrom { get; set; }
        // METHOD
        public City(char cityName, double population, int input)
        {
            this.listOfNeighbor = new List<Neighbor>();
            this.cityName = cityName;
            this.population = population;
            this.infectedDay = 0;
            this.infectedDuration = input - this.infectedDay;
            this.infectedPopulation = 0;
            this.infected = false;
            this.infectedFrom = ' ';
        }
        public double calcInfected()
        {

            double temp = 1 + ((this.population - 1) * Math.Exp(-0.25 * this.infectedDuration));
            return this.population / temp;
        }

        public void displayCity()
        {
            System.Console.WriteLine("City Name: " + cityName);
            System.Console.WriteLine("Population: " + population);
            System.Console.WriteLine("Infected?: " + infected);
            if(infected){
                System.Console.WriteLine("Infected Day: " + infectedDay);
                System.Console.WriteLine("Infected Duration : " + infectedDuration);
                System.Console.WriteLine("Infected Population: " + infectedPopulation);
                System.Console.WriteLine("Infected From : " + infectedFrom);
            }
        }

        public void printNeighbor()
        {
            foreach (Neighbor item in listOfNeighbor)
            {
                item.displayNeighbor();
            }
        }

        public bool infecting(Neighbor N)
        {
            double S = this.calcInfected() * N.travelProb;
            return (S > 1);
        }

        public int lamaInfeksi(Neighbor N)
        {
            int result = Convert.ToInt32(-4 * Math.Log(( (this.population * N.travelProb - 1) / (this.population - 1)), Math.Exp(1)));
            System.Console.WriteLine("Populasi : " + this.population);
            System.Console.WriteLine("Probability : " + N.travelProb);
            System.Console.WriteLine("Lama Infeksi : " + result);
            return result;
        }
    }

    class Neighbor
    {
        // PROPERTY
        public char neighborName { get; set; }
        public double travelProb { get; set; }

        
        
        public void displayNeighbor()
        {
            System.Console.WriteLine("Neighbor Name: " + neighborName);
            System.Console.WriteLine("Travel Probability: " + travelProb);
        }   

        // METHOD
        public Neighbor(char neighborName, double travelProb)
        {
            this.neighborName = neighborName;
            this.travelProb = travelProb;
        }
    }

    class Graph 
    {
        public List<City> listOfCity { get; set; }
        public char initialCity { get; set; }
        public Graph() {
            this.listOfCity = new List<City>();
            this.initialCity = 'A';
        }
        public Graph(char city)
        {
            this.initialCity = city;
        }
        public void printCity()
        {
            foreach (City item in listOfCity)
            {
                item.displayCity();
            }
        }
        public void printAll()
        {
            foreach (City city in listOfCity)
            {
                System.Console.WriteLine("==========CITY==========");
                city.displayCity();
                System.Console.WriteLine("========NEIGHBOR========");
                foreach (Neighbor neighbor in city.listOfNeighbor)
                {
                    neighbor.displayNeighbor();
                }
                System.Console.WriteLine("=========================");
            }
        }

        public void printQueueBFS(Queue<Tuple<char,char>> QueueBFS){
            System.Console.Write("Queue : {");
            foreach (Tuple<char,char> elmt in QueueBFS)
            {
                System.Console.Write("<" + elmt.Item1 + "," + elmt.Item2 + ">");

            }
            System.Console.WriteLine("}");
        }

        public string printQueueBFSBuffer(Queue<Tuple<char, char>> QueueBFS)
        {
            string buffer = "Queue : {";
            foreach (Tuple<char, char> elmt in QueueBFS)
            {
                System.Console.Write("<" + elmt.Item1 + "," + elmt.Item2 + ">");
                buffer = buffer + "<" + elmt.Item1 + "," + elmt.Item2 + ">";
            }
            buffer = buffer + "}";
            return buffer;
        }

        public void BFS(int input)
        {
            // Inisialisasi Queue Awal
            Queue<Tuple<char, char>> QueueBFS = new Queue<Tuple<char, char>>();
            listOfCity.Find(x => x.cityName == this.initialCity).infected = true;
            listOfCity.Find(x => x.cityName == this.initialCity).infectedPopulation = listOfCity.Find(x => x.cityName == this.initialCity).calcInfected();

            this.printAll();
            
            foreach (Neighbor neighbor in listOfCity.Find(x => x.cityName == this.initialCity).listOfNeighbor)
            {
                Tuple<char, char> init = new Tuple<char, char>(this.initialCity, neighbor.neighborName);                
                QueueBFS.Enqueue(init);
            }

            // Debug Inisialisasi Queue Awal
            printQueueBFS(QueueBFS);

            // Start Form dan Viewer Awal
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            //create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            //create a viewer object 
            // End Form dan Viewer Awal

            // Start of Setup Graph Awal
            foreach (var item in listOfCity)
            {
                graph.AddNode(Convert.ToString(item.cityName));
                var edited = graph.FindNode(Convert.ToString(item.cityName));
                if (item.infected)
                {
                    edited.Attr.FillColor = Microsoft.Msagl.Drawing.Color.DarkRed;
                }
                else
                {
                    edited.Attr.FillColor = Microsoft.Msagl.Drawing.Color.DarkGreen;
                }
                edited.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
            }

            foreach (City item in this.listOfCity)
            {
                foreach (Neighbor item2 in item.listOfNeighbor)
                {
                    string temp1 = Convert.ToString(item.cityName);
                    string temp2 = Convert.ToString(item2.neighborName);
                    graph.AddEdge(temp1, temp2).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                }
            }

            string buffer = printQueueBFSBuffer(QueueBFS);
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Active = true;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            viewer.SetToolTip(toolTip1, buffer);
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);



            form.Size = new System.Drawing.Size(1080, 720);

            form.ResumeLayout();
            //show the form 
            form.ShowDialog();
            // End of Viewing and Buffer Node (BFS Queue)
            // End of Setup Graph Awal


            System.Console.WriteLine("============== PERSEBARAN DIMULAI =================");

            // Proses BFS
            while(QueueBFS.Count != 0)
            {
                buffer = "";
                Tuple<char, char> temp = QueueBFS.Dequeue();
                char infectingCityName = temp.Item1;
                char cityToInfectName = temp.Item2;
                
                
                /* Kalo berhasil menginfeksi kota dan kota yang terinfeksi belum terinfeksi sebelumnya */
                if ((listOfCity.Find(x=>x.cityName == infectingCityName).infecting(listOfCity.Find(x => x.cityName == infectingCityName).listOfNeighbor.Find(x => x.neighborName == cityToInfectName))) && (!listOfCity.Find(x => x.cityName == cityToInfectName).infected)){

                    System.Console.WriteLine("{0} berhasil menginfeksi {1}", infectingCityName, cityToInfectName);
                    graph.AddEdge(Convert.ToString(infectingCityName), Convert.ToString(cityToInfectName)).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    Microsoft.Msagl.Drawing.Node edited = graph.FindNode(Convert.ToString(cityToInfectName));
                    edited.Attr.FillColor = Microsoft.Msagl.Drawing.Color.DarkRed;
                    /* ======================== QUEUE MANAGER ========================== */

                    /* Tambahkan <kota terinfeksi,tetangga dari kota terinfeksi> ke dalam queue */
                    foreach (Neighbor neighbor in listOfCity.Find(x => x.cityName == cityToInfectName).listOfNeighbor)
                    {
                        char infectedNeighbors = neighbor.neighborName;
                        Tuple<char, char> newTuple = new Tuple<char, char>(cityToInfectName, infectedNeighbors);
                        
                        
                        QueueBFS.Enqueue(newTuple);
                    }
                    /* Debug Queue */ 
                        printQueueBFS(QueueBFS);
                    
                    buffer = buffer + printQueueBFSBuffer(QueueBFS);

                    /* ====================== ATTRIBUTE CHANGE MANAGER =========================== */
                    listOfCity.Find(x => x.cityName == cityToInfectName).infected = true;
                    listOfCity.Find(x => x.cityName == cityToInfectName).infectedDay = listOfCity.Find(x => x.cityName == infectingCityName).lamaInfeksi(listOfCity.Find(x => x.cityName == infectingCityName).listOfNeighbor.Find(x => x.neighborName == cityToInfectName)) + listOfCity.Find(x=>x.cityName == infectingCityName).infectedDay;
                    System.Console.WriteLine("Berapa nih Infected Day? " + listOfCity.Find(x => x.cityName == cityToInfectName).infectedDay);
                    listOfCity.Find(x => x.cityName == cityToInfectName).infectedDuration = input - listOfCity.Find(x => x.cityName == cityToInfectName).infectedDay;
                    System.Console.WriteLine("Berapa nih Infected Duration? " + listOfCity.Find(x => x.cityName == cityToInfectName).infectedDuration);
                    listOfCity.Find(x => x.cityName == cityToInfectName).infectedPopulation = listOfCity.Find(x => x.cityName == cityToInfectName).calcInfected();
                    
                    if (listOfCity.Find(x => x.cityName == cityToInfectName).infectedFrom == ' ')
                    {
                        listOfCity.Find(x => x.cityName == cityToInfectName).infectedFrom = infectingCityName;
                    }
                }

                /* Kalo kota yang akan diinfeksi sudah terinfeksi sebelumnya */
                else if (listOfCity.Find(x => x.cityName == cityToInfectName).infected){

                    System.Console.WriteLine("Kota {0} sudah terinfeksi sebelumnya! Serangan tidak akan berpengaruh", cityToInfectName);
                    printQueueBFS(QueueBFS);
                    
                    buffer = buffer + printQueueBFSBuffer(QueueBFS);
                }

                /* Kalo kota tidak berhasil diinfeksi */
                else {

                    System.Console.WriteLine("{0} tidak berhasil menginfeksi {1}", infectingCityName, cityToInfectName);
                    printQueueBFS(QueueBFS);
                    
                    
                    buffer = buffer + printQueueBFSBuffer(QueueBFS);
                }


                //Microsoft.Msagl.Drawing.Node bfsDisplay= graph.AddNode(buffer);

                //bfsDisplay.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;


                // Start of Viewing and Buffer Node (BFS Queue)

                //Microsoft.Msagl.Drawing.Node remover = graph.FindNode(buffer);
                //graph.RemoveNode(remover);
                //Microsoft.Msagl.Drawing.Node bfsDisplay= graph.AddNode(buffer);

                //bfsDisplay.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                //bind the graph to the viewer 
                
                
                viewer.SetToolTip(toolTip1, buffer);
                viewer.Graph = graph;
                //associate the viewer with the form 
                form.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                form.Controls.Add(viewer);

                

                form.Size = new System.Drawing.Size(1080, 720);

                form.ResumeLayout();
                //show the form 
                form.ShowDialog();
                // End of Viewing and Buffer Node (BFS Queue)
            }
            this.printAll();   
        }
    }
}

       


