using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    internal class Candidate
    {
        private string CandidateName {  get; set; }
        private int VoteCount { get; set; }
        
        public Candidate(string name) { 
            this.CandidateName = name;
            this.VoteCount = 0;
        }

        
        internal void SetVoteCount(int voteCount)
        {
            VoteCount = voteCount;
        }

       
        public int GetVoteCount()
        {
            return VoteCount;
        }



        //Read-only fields
        public string Name => this.CandidateName; 
        public int voteCount => this.VoteCount;

    }
}
