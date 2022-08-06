// See https://aka.ms/new-console-template for more information
using ConsoleApp.Prototype.Framework;
using ConsoleApp.Prototype;

var manager = new Mananger();
var pen = new UnderlinePen('~');
var mbox = new MessageBox('*');
var sbox = new MessageBox('/');

manager.Register("strong message", pen);
manager.Register("warning box", mbox);
manager.Register("slash box", sbox);

var p1 = manager.Create("strong message");
var p2 = manager.Create("warning box");
var p3 = manager.Create("slash box");
p1.Use("你好，世界。");
p2.Use("你好，世界。");
p3.Use("你好，世界。");
Console.Read();