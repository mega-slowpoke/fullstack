// See https://aka.ms/new-console-template for more information

using Evaluation;

Day1Demo demo1 = new Day1Demo();
Console.WriteLine(demo1.MyAdd(2, 3, 4, 1, 12));
Console.WriteLine(demo1.OptionalVal(7,12));
int returnVal1 = demo1.OutTest(5, out int returnVal2, out int returnVal3);
Console.WriteLine(returnVal1 + " " + returnVal2 + " " + returnVal3);

Console.WriteLine("abba".IsPan());