using System;
using System.Collections.Generic;
using DrijskaConsole.Entities;
using static DrijskaConsole.Entities.Next;
using static DrijskaConsole.Entities.Set_S;

namespace DrijskaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var set_S = new Set_S();
            var next = new Next();

            Node node1=  new Node("1");            
            Node node2=  new Node("2");
            Node node3=  new Node("3");
            Node node4=  new Node("4");
            Node node5=  new Node("5");
            Node node6=  new Node("6");
            Node node7=  new Node("7");
            Node node8=  new Node("8");
        
            node1.Neighbors = new List<Adjacencie>() {
                new Adjacencie(9.0,node2),
                new Adjacencie(14.0,node6),
                new Adjacencie(15.0,node7),
                };
            node2.Neighbors = new List<Adjacencie>() {
                new Adjacencie(23.0,node3),
                };
            node6.Neighbors = new List<Adjacencie>() {
                new Adjacencie(18.0,node3),
                new Adjacencie(30.0,node5),
                new Adjacencie(5.0,node7),
                };
            node7.Neighbors = new List<Adjacencie>() {
                new Adjacencie(20.0,node5),
                new Adjacencie(44.0,node8),
                };
            node3.Neighbors = new List<Adjacencie>() {
                new Adjacencie(19.0,node8),
                };
            node5.Neighbors = new List<Adjacencie>() {
                new Adjacencie(11.0,node4),
                new Adjacencie(16.0,node8),
                };
            node4.Neighbors = new List<Adjacencie>() {
                new Adjacencie(6.0,node3),
                new Adjacencie(6.0,node8),
                };

            set_S.Shortest_Paths = new List<Shortest_Path>();

            var drijska = new Drijska(next,set_S);
            drijska.Lower_Cost(node1,node8);
            Console.WriteLine(drijska.TotalCost);
        }

        
    }
}
