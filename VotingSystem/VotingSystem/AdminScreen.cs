using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace VotingSystem
{
    public partial class AdminScreen : Form
    {
        private Authentication _authenticationSystem;
        private User _user;
        private Progress<int> donaldProgress;
        private Progress<int> paulProgress;
        private Form _loginForm;

        public AdminScreen(User user, Authentication authenticationSystem, Form loginForm)
        {
            _authenticationSystem = authenticationSystem;
            InitializeComponent();
            _user = user;
            _loginForm = loginForm;

            // Initialize Progress objects for UI updates
            donaldProgress = new Progress<int>(value =>
            {
                progressBarDonald.Value = value;
                lblDonaldvoteCount.Text = $"{value}%";
            });

            paulProgress = new Progress<int>(value =>
            {
                progressBarPaul.Value = value;
                lblDrPaulvoteCount.Text = $"{value}%";
            });
        }

        private async void AdminScreen_Load(object sender, EventArgs e)
        {
            await UpdateProgressBarsAsync();
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            _authenticationSystem.LogoutAdmin(_user);
            this.Close();
        }

        private async Task UpdateProgressBarsAsync()
        {
            while (true) 
            {
                var donald = VotingContext.Candidates.FirstOrDefault(c => c.Name == "Donald Trump");
                var paul = VotingContext.Candidates.FirstOrDefault(c => c.Name == "Dr. Paul Akiki");

                if (donald != null && paul != null)
                {
                    int totalVotes = donald.voteCount + paul.voteCount;
                    int donaldPercentage = totalVotes > 0 ? (donald.voteCount * 100) / totalVotes : 0;
                    int paulPercentage = totalVotes > 0 ? (paul.voteCount * 100) / totalVotes : 0;

                    // Report progress to update UI
                    ((IProgress<int>)donaldProgress).Report(donaldPercentage);
                    ((IProgress<int>)paulProgress).Report(paulPercentage);
                }

                await Task.Delay(1000); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var confirmation = MessageBox.Show(
                "Are you sure you want to end the elections?",
                "End of Elections Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                // Fetch candidates
                var donald = VotingContext.Candidates.FirstOrDefault(c => c.Name == "Donald Trump");
                var paul = VotingContext.Candidates.FirstOrDefault(c => c.Name == "Dr. Paul Akiki");

                if (donald == null || paul == null)
                {
                    MessageBox.Show("Candidates not found. Please verify the election setup.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                string winner;
                if (donald.voteCount > paul.voteCount)
                {
                    // Release the semaphore slot
                    _authenticationSystem.LogoutUser(_user);
                   
                    
                    //Checks if the current thread calling the hide method for login form is not the UI thread it was created on.
                    if (_loginForm.InvokeRequired)
                    {
                        _loginForm.Invoke(new MethodInvoker(() => _loginForm.Close()));
                    }
                    this.Hide();
                    
                    var trumpWinsForm = new TrumpWinsForm();
                    trumpWinsForm.ShowDialog();
                    this.Close();
                }
                else if (paul.voteCount > donald.voteCount)
                {
                    // Release the semaphore slot
                    _authenticationSystem.LogoutUser(_user);
                   
                    
                    if (_loginForm.InvokeRequired)
                    {
                        _loginForm.Invoke(new MethodInvoker(() => _loginForm.Hide()));
                    }
                    this.Hide();
                    var PaulWinsForm = new DrPaulWinsForm();
                    PaulWinsForm.ShowDialog();
                    this.Close();
                    if (_loginForm.InvokeRequired)
                    {
                        _loginForm.Invoke(new MethodInvoker(() => _loginForm.Close()));
                    }
                }
                else
                {
                    winner = $"It's a tie! Both candidates received {donald.voteCount + paul.voteCount} votes.";
                    // Display no winner
                    this.Close();
                    if (_loginForm.InvokeRequired)
                    {
                        _loginForm.Invoke(new MethodInvoker(() => _loginForm.Hide()));
                    }
                    MessageBox.Show(winner, "Election Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_loginForm.InvokeRequired)
                    {
                        _loginForm.Invoke(new MethodInvoker(() => _loginForm.Close()));
                    }
                }

                

                

                
                
            }
        }
    }
}
