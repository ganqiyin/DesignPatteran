// See https://aka.ms/new-console-template for more information
using ConsoleApp.Builder;

var txtBuilder = new TextBuilder();
var director = new Director(txtBuilder);
director.Construct();
var txt = txtBuilder.GetResult();
Console.WriteLine(txt);

Console.ReadLine();