string str = Console.ReadLine();

if (str.Length<3)
{
    Console.WriteLine("Third number does not exist");
}
else {
    Console.WriteLine(Thirdnumber(str));
}

char Thirdnumber(string number)
{
    char num = number[2];
    return num;

}
