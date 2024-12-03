using Microsoft.VisualBasic.ApplicationServices;

namespace VotingSystem
{
    public partial class LoginForm : Form
    {
        private Authentication _authenticationSystem;

        public LoginForm(Authentication authenticationSystem)
        {
            InitializeComponent();
            _authenticationSystem = authenticationSystem;
        }
        

        private async void button1_Click(object sender, EventArgs e)
        {
            String inputID = txtLoginID.Text;
            String inputPassword = txtLoginPassword.Text;

            var user = await _authenticationSystem.AuthenticateUser(inputID, inputPassword);

            

            if (user == null)
            {
                
                return;
            }
                if (user.IsLoggedIn)
                {
                    MessageBox.Show("User is already logged in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            
            user.IsLoggedIn = true;

            if (user != null )
            {
                
                Thread userThread = new Thread(() => UserSession(user));
                userThread.Start();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Method to handle user activity on a separate thread
        private void UserSession(User user)
        {
            
               
                if (user.Role == Role.administrator)
                {
                    Application.Run(new AdminScreen(user, _authenticationSystem, this));
                }
                else if (user.Role == Role.voter)
                {
                    Application.Run(new VoterScreen(user, _authenticationSystem));
                }
                
            
          
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}