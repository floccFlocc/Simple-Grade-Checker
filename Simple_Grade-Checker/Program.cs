// See https://aka.ms/new-console-template for more information

using System;

string userName = "";
string passWord = "";
string admin = "teacher";
string adminPassWord = "1234";
string student = "student";
string studentPassword = "1234";
string option = "";
string firstname = "";
string lastname = "";

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
else if (userName.ToLower() == student && passWord.ToLower() == studentPassword) {

    Console.WriteLine("Please provide your fill out this to view your grades.");
    Console.Write("First Name: ");
    firstname = Console.ReadLine();
    Console.Write("Last Name: ");
    lastname = Console.ReadLine();

    showGrade(firstname);

}
else
{
    Console.WriteLine("Access Denied. Please Try Again.");
    login();
}


void login()
{
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