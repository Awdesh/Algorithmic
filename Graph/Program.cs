using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Vertex
    {
        public bool wasVisited;
        public string label;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        public Vertex(string label)
        {
            this.label = label;
            this.wasVisited = false;
        }
    }

    public class Graph
    {
        private const int NUM_VERTICES = 20;
        private Vertex[] vertices;
        private int[,] adjMatrix;
        int numVertices;

        /// <summary>
        /// 
        /// </summary>
        public Graph()
        {
            vertices = new Vertex[NUM_VERTICES];
            adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            numVertices = 0;

            for (int j = 0; j <= NUM_VERTICES - 1; j++)
            {
                for (int k = 0; k <= NUM_VERTICES - 1; k++)
                {
                    adjMatrix[j, k] = 0;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        public void AddVertex(string label)
        {
            vertices[numVertices] = new Vertex(label);
            numVertices++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="eend"></param>
        public void AddEdge(int start, int eend)
        {
            adjMatrix[start, eend] = 1;
            adjMatrix[eend, start] = 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        public void ShowVertex(int v)
        {
            Console.Write(vertices[v].label + " ");
        }
    }

    
    public class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph();
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddVertex("F");
            g.AddVertex("G");
            g.AddVertex("H");
            g.AddVertex("I");
            g.AddVertex("J");
            g.AddVertex("K");
            g.AddVertex("L");
            g.AddVertex("M");
            g.AddVertex("N");
            g.AddVertex("O");
            g.AddVertex("P");
            g.AddVertex("Q");
            g.AddVertex("R");
            g.AddVertex("S");
            g.AddVertex("T");

            g.AddEdge(0, 1);
            g.AddEdge(0, 2); 
            g.AddEdge(0, 5);
            g.AddEdge(1, 4);
            g.AddEdge(1, 3);
            g.AddEdge(2, 6);
            g.AddEdge(3, 7);
            g.AddEdge(4, 8);
            g.AddEdge(5, 9);
            g.AddEdge(6, 10);
            g.AddEdge(7, 11);
            g.AddEdge(8, 12);
            g.AddEdge(9, 13);
            g.AddEdge(10, 14);
            g.AddEdge(11, 15);
            g.AddEdge(12, 16);
            g.AddEdge(13, 17);
            g.AddEdge(14, 18);
        }
    }
}
