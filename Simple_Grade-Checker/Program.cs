// See https://aka.ms/new-console-template for more information

string userName = "";
string passWord = "";
string admin = "teacher";
string adminPassWord = "1234";
string option = "";
string name = "";

Console.WriteLine("Hello! This is my first C# console project.\n\n");

Console.WriteLine("Please login to continue.");

Console.WriteLine("Username:");
userName = Console.ReadLine();

Console.WriteLine("Password:");
passWord = Console.ReadLine();

Console.Clear();

if (userName.ToLower() == admin && passWord.ToLower() == adminPassWord) {

    Console.WriteLine("What would you like to do?");

    Console.WriteLine("(1) Edit Grade");
    Console.WriteLine("(2) Remove A Studet");
    Console.WriteLine("(3) Add A Student");
    Console.WriteLine("(4) Compute A Student Grade");

    option = Console.ReadLine();

}
else {

    Console.WriteLine("Please provide your full name to view your grades");
    name = Console.ReadLine();
}
