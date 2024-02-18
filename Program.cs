//Берётся первый массив
string[] array = {"34325", "qwerty", "22", "Git", "Branch_1", "0", "USA", "d3", "h7g322v1"};
int i = 0;
int j = 0; 
Console.WriteLine("Имеющийся массив:"); //для наглядности
while(i < array.Length)
{
    Console.WriteLine(array[i]);
    i++;
}
i=0;

//Считается количество значений в массиве, удовлетворяющих условию <= 3 символа
while(i<array.Length)
{
    if(array[i].Length<=3)
    {
        j++;
    }
    i++;
}
i=0;
Console.WriteLine();
//Console.WriteLine($"Количество подходящих значений в массиве: {j}.");

//Cоздаётся массив для переноса значений
string[] arraySort = new string[j];
j=0;
while(i<array.Length)
{
    if(array[i].Length <= 3)
    {
        arraySort[j] = array[i];
        j++;
    }
    i++;
}
j=0;

//Выводится отсортированный массив
Console.WriteLine($"Удовлетворяющие условию значения в массиве: ");
while(j < arraySort.Length)
{
    Console.WriteLine(arraySort[j]);
    j++;
}