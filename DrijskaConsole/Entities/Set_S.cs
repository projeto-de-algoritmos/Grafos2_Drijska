using System;
using System.Collections.Generic;

namespace DrijskaConsole.Entities
{
    public class Set_S
    {
        public List<Shortest_Path> Shortest_Paths = new List<Shortest_Path>();

        public void Add(Node reference , Node previous ,double totalCost ){
            this.Shortest_Paths.Add(new Shortest_Path(reference,previous,totalCost));
        }
        

        public class Shortest_Path{
            public Shortest_Path(Node reference, Node previous, double totalCost)
            {
                Reference = reference;
                Previous = previous;
                TotalCost = totalCost;
            }

            public Node Reference { get; set; }
            public Node Previous { get; set; }
            public double TotalCost { get; set; }
            
            
            
            
            
        }
    }
}