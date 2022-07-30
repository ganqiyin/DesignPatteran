// See https://aka.ms/new-console-template for more information
using ConsoleApp.FactoryMethod.Framework;
using ConsoleApp.FactoryMethod.IdCard;

Factory factory = new IDCardFactory();
var product1 = factory.Create("小米");
var product2 = factory.Create("小明");
var product3 = factory.Create("小兔");
product1.Use();
product2.Use();
product3.Use();
Console.Read();
