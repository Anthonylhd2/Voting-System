/*
Course Number: CSC 413
Name                    |ID          |Major
Anthony Lahoud          |20221658    |Computer Science
Anthony Nasry Massaad   |20221135    |Computer Science
Hovig Chavoushian       |20221450    |Computer Science

Presented to: Dr. Paul Akiki 
 */
namespace VotingSystem
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            


            //Defining users
            User user1 = new(1, "Hovig", "Hovig@gmail.com", "123", Role.voter);
            User user2 = new(2, "Anthony", "Anthony@gmail.com", "123", Role.voter);
            User user3 = new(3, "Massaad", "Massaad@gmail.com", "123", Role.voter);
            User user4 = new(4, "Lahoud", "Lahoud@gmail.com", "123", Role.administrator);

            //list of all users in our system
            List<User> usersBase = new List<User> { user1,user2,user3,user4};

            //To authenticate Users
            Authentication authenticationSystem = new(usersBase);

            // Pass authentication system to the LoginForm
            Application.Run(new LoginForm(authenticationSystem));

            Candidate candidate1 = new( "Candidate 1");
            Candidate candidate2 = new( "Candidate 2");

        }
    }
}