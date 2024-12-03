using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    internal class VotingManager
    {
        object locker = new();

        public void IncrementCount(Candidate c)
        {
            c.SetVoteCount(c.GetVoteCount() + 1);
        }

        public void CastVote(string candidateName)
        {
            // Find the candidate by name
            var candidate = VotingContext.Candidates.FirstOrDefault(c => c.Name == candidateName);
            if (candidate != null)
            {
                lock(locker)
                {
                    IncrementCount(candidate); 
                }
            }
            else
            {
                throw new Exception("Candidate not found.");
            }
        }

        public void updateVoterStatus(User user)
        {
            user.SetHasVoted(true);
        }
    }
}
