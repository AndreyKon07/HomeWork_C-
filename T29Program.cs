int[] Newarr(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i=0; i<size; i++)
        array[i]= new Random().Next(min, max +1);
        return array;
}

void NewArr(int[] array)

{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] myarray=Newarr(8,1,9096560);
NewArr(myarray);