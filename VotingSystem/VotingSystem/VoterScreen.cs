using System;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class VoterScreen : Form
    {
        private Authentication _authenticationSystem;
        private User _user;
        private VotingManager _votingManager;

        public VoterScreen(User user, Authentication authenticationSystem)
        {
            _authenticationSystem = authenticationSystem;
            InitializeComponent();
            _user = user;
            _votingManager = new VotingManager();
        }

        private void btnVoterLogout_Click(object sender, EventArgs e)
        {
            // Release the semaphore slot
            _authenticationSystem.LogoutUser(_user);

            this.Close();
        }

        private void VoterScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPaulVote_Click(object sender, EventArgs e)
        {
            try
            {
                
                var confirmation = MessageBox.Show(
                    "Are you sure you want to vote for Candidate 2?",
                    "Confirm Vote",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    _votingManager.CastVote("Candidate 2");
                    MessageBox.Show("Excellent choice! Candidate 2 appreciates your support. Together, we will make programming great again!", "Vote Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                    _votingManager.updateVoterStatus(_user);
                    
                    // Release the semaphore slot
                    _authenticationSystem.LogoutUser(_user);

                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDonaldVote_Click(object sender, EventArgs e)
        {
            try
            {
              
                var confirmation = MessageBox.Show(
                    "Are you sure you want to vote for Candidate 1?",
                    "Confirm Vote",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    _votingManager.CastVote("Candidate 1");
                    MessageBox.Show("You successfully voted for Candidate 1!", "Vote Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    _votingManager.updateVoterStatus(_user);

                    // Release the semaphore slot
                    _authenticationSystem.LogoutUser(_user);

                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
