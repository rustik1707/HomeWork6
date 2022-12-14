//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int []createArray(int numbers)
{
    int []array = new int[numbers];
    Random rnd = new Random();

    for (int i = 0; i < numbers; i++)
    {
        array[i] = rnd.Next(0,1000);
    }

return array;

}
void Printarray(int[]array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write( $"{array[i]} ");
    }
Console.WriteLine();
}

int []Copyarray(int[]array)
{   
    int numbers = array.Length;
    int []array01 = new int[numbers];
    
    for (int i = 0; i < array.Length; i++)
    {
        array01[i] = array[i];
    }

    return array01;
}






int[]array = createArray(10);
Printarray(array);
int[] secondarray = Copyarray(array);
Printarray(secondarray);
