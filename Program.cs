using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // a pre-defined adjacencyList of a color graph
            (int, int)[][] adjacencyList = new (int, int)[8][];
            /*Red      */ adjacencyList[0] = new (int, int)[] { (1, 1), (5, 5) };
            /*DarkBlue */ adjacencyList[1] = new (int, int)[] { (2, 8), (3, 1) };
            /*Yellow   */ adjacencyList[2] = new (int, int)[] { (7, 6) };
            /*LightBlue*/ adjacencyList[3] = new (int, int)[] { (1, 1), (5, 0) };
            /*Purple   */ adjacencyList[4] = new (int, int)[] { (2, 1) };
            /*grey     */ adjacencyList[5] = new (int, int)[] { (3, 0), (6, 1) };
            /*Orange   */ adjacencyList[6] = new (int, int)[] { (4, 1) };
            /*Green    */ adjacencyList[7] = new (int, int)[] { };
            // track what nodes have already been visited
            bool[] visited = new bool[adjacencyList.GetLength(0)];
            // an array of strings for easier readability when compaired to the graph
            string[] colors = { "Red", "Dark Blue", "Yellow", "Light Blue", "Purple", "Grey", "Orange", "Green" };
            // search the adjacencyList starting from node Red
            DepthSearch(adjacencyList, 0, visited, colors);
        }
        /* Method: DepthSearch
         * Purpose: Search an array of colors and output the result 
         * Restrictions: Any array searched must consist of a 2D jagged array made of (int, int)
         */
        public static void DepthSearch((int, int)[][] adjacencyList, int currentPos, bool[] visited, string[] colors)
        {
            // Output the color of the node we are currently at
            Console.WriteLine(colors[currentPos] + " ");
            // set the node tracker at the position we are currently at to true
            visited[currentPos] = true;
            // search through each element in the array
            foreach((int, int) index in adjacencyList[currentPos])
            {
                // if the node referenced in the edge has not been visited
                if(!visited[index.Item1])
                {
                    // search the node referenced
                    DepthSearch(adjacencyList, index.Item1, visited, colors);
                }
            }
        }
    }
}
