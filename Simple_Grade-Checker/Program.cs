// See https://aka.ms/new-console-template for more information

using System;

string userName = "";
string passWord = "";
string admin = "teacher";
string adminPassWord = "1234";
string[] studentAccounts = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
string[] studentPasswords = new string[] { "123", "456", "789", "012" };
string[] subjects = new string[] { "English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" };
string studentPassword = "1234";
string option = "";

Console.WriteLine("Hello! This is my first C# console project.\n\n");

Console.WriteLine("Please login to continue.");

login();

Console.Clear();

if (userName.ToLower() == admin && passWord.ToLower() == adminPassWord) {

    Console.WriteLine("What would you like to do?");

    Console.WriteLine("(1) Edit Grade");
    Console.WriteLine("(2) Remove A Studet");
    Console.WriteLine("(3) Add A Student");
    Console.WriteLine("(4) Compute A Student Grade");
    Console.WriteLine("(5) Logout");

    option = Console.ReadLine();

}
else
{
    for (int i = 0; i<studentAccounts.Length; i++)
    {
        if (studentAccounts[i].ToLower() == userName.ToLower() && studentPasswords[i].ToLower() == passWord.ToLower())
        {
            showGrade(studentAccounts[i]);
        }
        else
        {
            Console.Write("Access denied. Try again.");
            login();
        }
    }
}


void login()
{
    Console.Clear();
    Console.Write("Username:");
    userName = Console.ReadLine();

    Console.Write("Password:");
    passWord = Console.ReadLine();
}

void showGrade(string name)
{
    Console.Clear();
    Console.WriteLine("Hi! " + name + ".");
}