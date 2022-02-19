using System.Collections.Generic;

namespace DrijskaConsole.Entities
{
    public class Node
    {
        public Node(string title, List<Adjacencies> neighbors)
        {
            Title = title;
            Neighbors = neighbors;
        }

        public string Title { get; set; }
        public List<Adjacencies> Neighbors = new List<Adjacencies>();

        
        
        public class Adjacencies{
            public Adjacencies(double distancie, Node neighbor)
            {
                Distancie = distancie;
                Neighbor = neighbor;
            }

            public double Distancie { get; set; }
            public Node Neighbor { get; set; }
            
            
            
        }
    
    }


}