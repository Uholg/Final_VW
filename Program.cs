int count; 
Console.Write("Количество элементов массива:");
count = Convert.ToInt32(Console.ReadLine());

if (count<=0)
{
Console.WriteLine("Некорректное значение количества элементов массива.");
return;
}


string[] arr = new string[count];

Console.WriteLine("Введите элемент массива:");

      for (int i=0;i<arr.Length;i++)
      {
        Console.Write("arr[{0}] = ", i);
        arr[i] = Console.ReadLine();
      }
PrintArray(arr);
Console.Write(" -> ");

string[] arrnew = new string[count];
int j=0;

 for (int m=0;m<arr.Length;m++)
 {
    string str=arr[m];
    if (str.Length<=3)
    {arrnew[j]=str;
    Console.Write(arrnew[j]+", ");
    j++;
    }  
 }


void PrintArray(string[] array)
{
    int count = array.Length;
    for (int k=0;k<count;k++)
    {
        Console.Write(array[k] + ", ");
    }
}