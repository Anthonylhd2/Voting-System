using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    public class Authentication
    {
        readonly List<User> userBase;
        
        private readonly SemaphoreSlim _semaphore;
        public Authentication(List<User> userBase)
        {
            this.userBase = userBase;
            // Initialize the semaphore with a count of 2 (maximum 2 users)
            _semaphore = new SemaphoreSlim(2);
        }
        public User getUserByID(int id, List<User> userBase)
        {
            foreach (User u in userBase)
            {
                if (u.Id == id)
                {
                    return u;
                }
            }
            return null;
        }

        public async Task<User> AuthenticateUser(string inputID, string inputPassword)
        {
           
           
            int.TryParse(inputID, out int IDentity);

            try
            {
                
                if (int.TryParse(inputID, out int ID))
                {
                    // Iterate through the user base to find the matching user
                    foreach (var user in userBase)
                    {
                        if (user.Id == ID && user.Password == inputPassword)
                        {
                            // Check if the user has already voted
                            if (user.GetHasVoted())
                            {

                                
                                MessageBox.Show(
                                    "You have already voted and cannot log in again to vote.",
                                    "Voting Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                                return null;
                            }

                            if (this.getUserByID(IDentity, userBase).Role == Role.voter)
                            {
                                await _semaphore.WaitAsync();
                            }
                            return user;
                        }
                    }

                    // If no user matches the ID and password
                    MessageBox.Show("Wrong Credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                else
                {
                    // Conversion failed
                    MessageBox.Show("ID must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            finally
            {

            }
        }

        public void LogoutUser(User u)
        {

            u.IsLoggedIn = false;
            // Release the semaphore slot when a user logs out
            _semaphore.Release();
        }
        public void LogoutAdmin(User u)
        {
            u.IsLoggedIn = false;
           
        }
    }
}