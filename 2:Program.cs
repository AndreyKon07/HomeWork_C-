int a, b, c, max;

Console.WriteLine("Input first number");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number");
c = Convert.ToInt32(Console.ReadLine());

max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine(max);
