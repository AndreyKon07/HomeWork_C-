int Secnumber()
{
    int ran = new Random().Next(100, 1000);
    Console.WriteLine("Random number is: " + ran);
    int dec = ran / 10;
    int ed = dec %10;
    return ed;

}
int sec = Secnumber();
Console.WriteLine("Second number is: " + sec);
