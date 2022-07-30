// See https://aka.ms/new-console-template for more information

using ConsoleApp.Singleton;

var d = Singleton4.Instance;
var d2 = Singleton4.Instance;
if(d==d2)
{
    Console.WriteLine("d 与 d2 是同一个实例");
}
else
{

    Console.WriteLine("d 与 d2 [不]是同一个实例");
}

Console.Read();
