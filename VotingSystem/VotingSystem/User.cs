using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    public class User
    {
        private int id { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private Role role { get; set; }
        private bool HasVoted { get; set; }
        public bool IsLoggedIn { get; set; }

        public User(int id, string name, string email, string password, Role role)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
            this.HasVoted = false;
            this.IsLoggedIn = false;
        }

        // Read-only properties 
        public int Id => id;
        public string Password => password;
        public Role Role => role;

       
        internal void SetHasVoted(bool hasVoted)
        {
            HasVoted = hasVoted;
        }

        
        public bool GetHasVoted()
        {
            return HasVoted;
        }


    }
}
public enum Role{
    voter, administrator
}