# Voting-System

How The Program Works:
The program portrays a voting system, where users log in to vote for their preferred candidate while the admin moderates the program.

The four users are:
User	ID	Password	Role
1	1	123	VOTER
2	2	123	VOTER
3	3	123	VOTER
4	4	123	ADMIN

INITIAL STEP (Login):
You will be logging in to the system using each previously registered user's ID number and Password.
A thread session is created for each user login.
By using a semaphore only 2 users with a voting role can log in at the same time. If a third voter tries to log in he/she will have to wait until a previously logged-in voter finishes his/her session. Then the system automatically logs in the third user when a slot opens up.
However, the administrator (user with role admin) can log in at any given time, to moderate the elections, even if there are two voters logged in and the semaphore is full.
SECOND STEP (Voting Process):
When the voter has logged in he/she will view a screen with the choice to vote for one of the two candidates. 
However, when two users are logged in, to avoid concurrency while voting, the system applies exclusive locking so that there would be no data loss while collecting the votes.
When the user decides whom he/she wants to vote for and confirms his/her vote, the system logs the user out automatically and logs in another user if there are any waiting.
After a voter has cast his/her vote, and tries to log back in, the system will not let the user in and will let him know that he has already voted.
THIRD STEP (Progress Reporting):
The administrator when logged in, with the help of asynchronous functions he/she can view in real-time the voting progress. 
He/she will see a progress bar showing the percentage of votes each candidate has.
ENDING ELECTIONS:
The Admin can end the elections to stop the voting using his/her END button.
After the voting has ended, the system will display the winner screen.
