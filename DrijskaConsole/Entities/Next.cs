using System;
using System.Collections.Generic;

namespace DrijskaConsole.Entities
{
    public class Next
    {
        public List<Candidate> listCandidate ; 

        public void Add(){
            throw new NotImplementedException();
        }

        

        public class Candidate{
            public double TotalDistance { get; set; }
            public Node Origin { get; set; }
            public Node Destiny { get; set; }

            public Candidate(double totalDistance, Node origin, Node destiny)
            {
                this.TotalDistance = totalDistance;
                Origin = origin;
                Destiny = destiny;
            }
        }
        
    }
}