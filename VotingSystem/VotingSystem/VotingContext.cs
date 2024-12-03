using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    internal static class VotingContext
    {
        public static List<Candidate> Candidates { get; private set; } = new List<Candidate>();

        static VotingContext()
        {
            Candidates.Add(new Candidate("Donald Trump"));
            Candidates.Add(new Candidate("Dr. Paul Akiki"));
        }
    }
}
