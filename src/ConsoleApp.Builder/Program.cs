// See https://aka.ms/new-console-template for more information
using ConsoleApp.Builder;

var txtBuilder = new TextBuilder();
var director = new Director(txtBuilder);
director.Construct();
var txt = txtBuilder.GetResult();
Console.WriteLine(txt);

var htmlBilder = new HtmlBulder();
 director = new Director(htmlBilder);
director.Construct();
txt = htmlBilder.GetResult();
Console.WriteLine(txt);

Console.ReadLine();