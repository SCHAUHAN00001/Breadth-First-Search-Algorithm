using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadth_First_Search_Algorithm
{
    internal class Program
    {
        class Graphs
        {
            int vertices;
            int[,] adjMat;

            public Graphs(int n)
            {
                vertices = n;
                adjMat = new int[n, n];
            }

            public void insertEdge(int u, int v, int x)
            {
                adjMat[u, v] = x;
            }

            public void removeEdge(int u, int v)
            {
                adjMat[u, v] = 0;
            }

            public bool existEdge(int u, int v)
            {
                return adjMat[u, v] != 0;
            }

            public int vertexCount()
            {
                return vertices;
            }

            public int edgeCount()
            {
                int count = 0;
                for (int i = 0; i < vertices; i++)
                {
                    for (int j = 0; j < vertices; j++)
                        if (adjMat[i, j] != 0)
                            count = count + 1;
                }
                return count;
            }

            public void edges()
            {
                Console.WriteLine("Edges:");
                for (int i = 0; i < vertices; i++)
                    for (int j = 0; j < vertices; j++)
                        if (adjMat[i, j] != 0)
                            Console.WriteLine(i + "--" + j);
            }

            public int outdegree(int v)
            {
                int count = 0;
                for (int j = 0; j < vertices; j++)
                    if (adjMat[v, j] != 0)
                        count = count + 1;
                return count;
            }

            public int indegree(int v)
            {
                int count = 0;
                for (int i = 0; i < vertices; i++)
                    if (adjMat[i, v] != 0)
                        count = count + 1;
                return count;
            }

            public void display()
            {
                for (int i = 0; i < vertices; i++)
                {
                    for (int j = 0; j < vertices; j++)
                        Console.Write(adjMat[i, j] + "\t");
                    Console.WriteLine();
                }
            }
            public void BFS(int s)
            {
                int i = s;
                QueueLnkedList q = new QueueLnkedList();
                int[] visited = new int[vertices];
                Console.Write(i + " ");
                visited[i] = 1;
                q.enqueue(i);
                while (!q.isEmpty())
                {
                    i = q.dequeue();
                    for (int j = 0; j < vertices; j++)
                    {
                        if (adjMat[i, j] == 1 && visited[j] == 0)
                        {
                            Console.Write(j + " ");
                            visited[j] = 1;
                            q.enqueue(j);
                        }
                    }
                }
            }

            static void Main(string[] args)
            {
                Graphs g = new Graphs(7);
                g.insertEdge(0, 1, 1);
                g.insertEdge(0, 5, 1);
                g.insertEdge(0, 6, 1);
                g.insertEdge(1, 0, 1);
                g.insertEdge(1, 2, 1);
                g.insertEdge(1, 5, 1);
                g.insertEdge(1, 6, 1);
                g.insertEdge(2, 3, 1);
                g.insertEdge(2, 4, 1);
                g.insertEdge(2, 6, 1);
                g.insertEdge(3, 4, 1);
                g.insertEdge(4, 2, 1);
                g.insertEdge(4, 5, 1);
                g.insertEdge(5, 2, 1);
                g.insertEdge(5, 3, 1);
                g.insertEdge(6, 3, 1);
                Console.WriteLine("Breadth First Search:");
                g.BFS(0);
                Console.ReadKey();
            }
        }
    }
}
