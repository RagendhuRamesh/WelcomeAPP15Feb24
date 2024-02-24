// See https://aka.ms/new-console-template for more information
using WelcomeApp;

Console.WriteLine("Welcome to Auhtentication App");
SignIn obj = new SignIn();
Console.WriteLine(obj.Auhtenticate("admin", "admin@1256"));