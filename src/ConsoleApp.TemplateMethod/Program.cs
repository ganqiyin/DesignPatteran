// See https://aka.ms/new-console-template for more information

using ConsoleApp.TemplateMethod;

AbstractDisplay charDispaly = new CharDisplay('G');
AbstractDisplay strDispaly = new StringDisplay("hello, word.");
AbstractDisplay strDispaly2 = new StringDisplay("你好，世界。");
charDispaly.Display();
strDispaly.Display();
strDispaly2.Display();
Console.ReadLine();
