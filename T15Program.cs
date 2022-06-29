void Dayofweek(int x)

{
    if ( x >= 1 &&  x < 6) Console.WriteLine("Work Day");
    if ( x >= 6 &&  x <= 7) Console.WriteLine("Holliday");
    if ( x < 1 ||  x > 7) Console.WriteLine("Please, input correct number");

}

Console.Write("Day's number: ");

int x = Convert.ToInt32(Console.ReadLine());

Dayofweek(x);

