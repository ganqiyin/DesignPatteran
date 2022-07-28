// See https://aka.ms/new-console-template for more information
// 也可以叫 Wrapper 模式

using ConsoleApp.Adapter;

IPrint print = new PrintBanner("你好");
print.PrintStrong();
print.PrintWeak();

print = new PrintDBanner("你好吗");
print.PrintStrong();
print.PrintWeak();
Console.Read();
