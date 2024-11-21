using System;
using System.Collections.Generic;

namespace Bll
{
    public class GFG
    {

        // Function that implements Dijkstra's
        // single source shortest path algorithm
        // for a graph represented using adjacency
        // matrix representation
        private static int[] DijkstraShortestPath(int[,] graph, int source)
        {
            int[] dist = new int[graph.GetLength(0)];// dist[i] will hold the shortest distance from src to vertex i
            bool[] sptSet = new bool[graph.GetLength(0)]; // sptSet[i] will true if vertex i is included in shortest path tree or shortest distance from src to i is finalized
            int[] path = new int[graph.GetLength(0)];// The output array. will hold all the vertex of the shortest path

            // Initialize all distances as int.MaxValue;
            // INFINITE and stpSet[] as false
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            dist[source] = 0;// Distance of source vertex from itself is always 0
            path[source] = -1;//Path of source vertex from itself is always -1

            // Find shortest path for all vertices
            for (int count = 0; count < graph.GetLength(0) - 1; count++)
            {
                int u = MinDistance(dist, sptSet);// Pick the minimum distance vertex from the set of vertices not yet processed. u is always equal to src in first iteration.
                sptSet[u] = true;// Mark the picked vertex as processed

                // Update dist value of the adjacent vertices of the picked vertex.
                for (int v = 0; v < graph.GetLength(0); v++)
                    // Update dist[v] only if is not in sptSet, there is an edge from u to v, and total weight of path
                    // from src to v through u is smaller than current value of dist[v]
                    if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                        path[v] = u;
                    }
            }

            // A utility function to print
            // the constructed distance array
            Console.WriteLine("Vertex \t Distance from source");
            for (int i = 0; i < graph.GetLength(0); i++)
                Console.WriteLine(i + " \t\t " + dist[i]);

            return path;
        }
        private static int MinDistance(int[] dist, bool[] sptSet)
        {
            // Initialize min value
            int min = int.MaxValue;
            int minIndex = -1;

            for (int v = 0; v < dist.Length; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    minIndex = v;
                }
            return minIndex;
        }

        private static List<int> Path(int[] path, int source, int destination)
        {
            List<int> shortestPath = new List<int>();
            int vertex = destination;
            while (vertex != source)
            {
                shortestPath.Add(vertex);
                vertex = path[vertex];
            }

            shortestPath.Add(source);
            shortestPath.Reverse();

            //Console.WriteLine("Shortest Path from source to destination:");
            //Console.WriteLine(string.Join(" -> ", shortestPath));

            return shortestPath;
        }
        // Driver Code
        public static List<int> Main(int source, int location)
        {
            /* Let us create the example graph discussed above */
            GraphBll G = new GraphBll();
            int[,] graph = G.Graphmat;


            int[] path = DijkstraShortestPath(graph, source);
            return Path(path, source, location);
        }
    }

}
