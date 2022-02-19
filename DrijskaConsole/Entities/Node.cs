using System.Collections.Generic;

namespace DrijskaConsole.Entities
{
    public class Node
    {
        public string Title { get; set; }
        public bool Visited = false;
        
        public List<Adjacencie> Neighbors = new List<Adjacencie>();
        public Node(string title)
        {
            Title = title;
        }
    }
        public class Adjacencie{
            public Adjacencie(double cost, Node neighbor)
            {
                Cost = cost;
                Neighbor = neighbor;
            }

            public double Cost { get; set; }
            public Node Neighbor { get; set; }
        }


}