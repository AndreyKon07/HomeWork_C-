
int Findsumnumb()
{
    int s = 0;
    int v = int.Parse(Console.ReadLine());

    while(v > 0)
    {
        s = s + (v % 10);
        v = v/10;
    }
    return s;

}

Console.Write("Input number: ");

Console.WriteLine("Sum is :" + Findsumnumb());

