using System;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Enter your Roll number:");
int rollNo = (int) Convert.ToDouble (Console.ReadLine());


Console.WriteLine("Enter your marks:");
Console.WriteLine("________________________________________________________________________");

Console.WriteLine("Enter your Science marks:");
int sci = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Maths marks:");
int maths = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Maths marks:");
int eng = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Maths marks:");
int physics = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Maths marks:");
int computer = Convert.ToInt32(Console.ReadLine());

results myObj = new results();
    Console.WriteLine($"Total marks roll no {rollNo} obtained:");
   Console.WriteLine(myObj.totNum(sci , maths , eng , physics , computer));

Console.WriteLine($"Percentage of roll no {rollNo} :");
Console.WriteLine(myObj.ResultPer());




class results
{
    int sum;
    public int totNum(int a, int b, int c, int d, int e)
    {
         sum = a + b + c + d + e;
        return sum;
    }
    public float ResultPer()
    {
        float percentage = (sum / 500 * 100);
        return percentage;
    }
   
}