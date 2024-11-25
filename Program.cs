// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Math.Implementations;

Console.WriteLine("Nazwa grupy: Impakt. Scrum master: tirey93.");
Console.WriteLine("DevOps Engineer: hubert-cywka");
Console.WriteLine("Dev1: tirey93");
Console.WriteLine("Dev2: lukasz-kkk");

var a = 10;
var b = 5;
var mathService = new MathService();

var additionResult = mathService.Addition(a, b);

Console.WriteLine("\n** Arithmetic operations **");
Console.WriteLine("Addition test: {0} + {1} = {2}", a, b, additionResult);