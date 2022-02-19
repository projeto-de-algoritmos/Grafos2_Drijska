using System;
using System.Collections.Generic;
using System.Linq;

namespace DrijskaConsole.Entities
{
    public class Next
    {
        public List<Candidate> listCandidate = new List<Candidate>();

        public void Add(double totalCost ,Node destiny, Node origin){
            //Verificando se o destiny ja esta presente na Next
            var candidateDestinyinNext = this.listCandidate.SingleOrDefault(cd => cd.Destiny.Title == destiny.Title);
            if(candidateDestinyinNext != null){
                if (totalCost < candidateDestinyinNext.TotalCost){                    
                    candidateDestinyinNext.TotalCost = totalCost;
                    candidateDestinyinNext.Origin=origin;
                    return;
                } 
                return;
            }
            this.listCandidate.Add(new Candidate(totalCost,destiny,origin));
        }

        

        public class Candidate{
            public double TotalCost { get; set; }
            public Node Origin { get; set; }
            public Node Destiny { get; set; }

            public Candidate(double totalCost,Node destiny, Node origin)
            {
                this.TotalCost = totalCost;
                this.Destiny = destiny;
                this.Origin = origin;
            }
        }
        
    }
}