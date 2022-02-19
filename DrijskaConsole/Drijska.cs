using System.Linq;
using DrijskaConsole.Entities;

namespace DrijskaConsole
{
    public class Drijska
    {
        public Next next { get; set; }
        public Set_S set_S{get;set;}
        public double TotalCost=0;
        
        

        public Drijska(Next next, Set_S set_S)
        {
            this.next = next;
            this.set_S = set_S;
        }

        public void Lower_Cost(Node s, Node t ){

            Node actual = s;
            this.set_S.Add(actual,null,0);
            this.set_S.Shortest_Paths.SingleOrDefault(sp => sp.Reference.Title == actual.Title ).TotalCost = 0;
            s.Visited = true;

            while(!t.Visited /*ou nao ter conseguido atingir t*/){
                foreach(Adjacencie adj in actual.Neighbors){
                    /*-----ADICIONAR NA Next-----*/
                    //Se o meu destino ja foi visitado , ele ja esta presente na Set_S
                    if(adj.Neighbor.Visited){
                        continue;
                    }
                    AddinNext(adj,actual);
                }
                AddinSet_s(out actual);
            }
        }


        private void AddinNext(Adjacencie adj, Node actual){
            //Pego o custo de se chegar ao nó atual
                    var totalCost = this.set_S.Shortest_Paths.SingleOrDefault(sp => sp.Reference.Title == actual.Title).TotalCost;
                    //Somo com o custo de se chegar ao nó vizinho
                    totalCost += adj.Cost;
                    //adiciono o custo de se chegar ao vizinho, o nó vizinho , e o nó de origem
                    this.next.Add(totalCost, adj.Neighbor,actual);
        }
        private void AddinSet_s(out Node actual)
        {
            //Escolho da Next o candidato com o menor caminho
            var lessCost =this.next.listCandidate.Min(cd => cd.TotalCost);
            var choosenCandidate = this.next.listCandidate.SingleOrDefault(cd =>cd.TotalCost == lessCost );
            this.next.listCandidate.Remove(choosenCandidate);
            //Adiciono no Set_S o nó referenciado , o nó anterior e o valor total para nó referencia
            this.set_S.Add(choosenCandidate.Destiny,choosenCandidate.Origin,choosenCandidate.TotalCost);
            //Ao se adicionar na Set_S o no fica como visitado
            choosenCandidate.Destiny.Visited = true;
            //e agora o nó atual que sera percorrido sera o no que foi salvo na Set_S
            actual = choosenCandidate.Destiny;
            this.TotalCost += lessCost;
        }

    }
}