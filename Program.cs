// Список методов:

// Введение числа не равного нулю через сообщение msg и проверка, что введено именно число:

int GetNumber(string msg)
{
    while(true)
    {
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();
    

        if(int.TryParse(valueFromConsole, out int number))
        {
            if(number != 0)
                return number;
                else
                {
                    Console.WriteLine("Число должно отличаться от 0. Введите другое число");
                }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля");
        }
    }
}  

// проверка положительного числа:

bool IsNumberPositive(int number)
{
    return number > 0;
}

// Введение числа:

string GetNumber()
{
    return Console.ReadLine();
} 

// определение четверти:

int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x > 0 && y < 0)
        return 4;
    else if(x < 0 && y < 0)
        return 3;
    else 
        return 2;
}

// Сумма от 1 до заданного числа:

int GetSummFromOneToNumber(int number)
{
    int summ = 0;

    for (int i = 1; i <= number; i++)
        summ += i; //sum =sum + i
    return summ;
}

// Количество цифр в числе:

int GetCountNumber(string str)
{
    int number = int.Parse(str);
    int count = 0;
    
    while(number != 0)
    {
        number = number / 10;
        count++;
    }
    
    return count;
}


// Произведение чисел от 1 до заданного:

int GetProdofNum(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    prod *= i;

    return prod;
}

// Введение массива вручную:

int [] GetArrayManual(int length)
{
    int [] arr = new int[length];

    for(int i = 0; i < length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

// Создание массива случайных чисел 1 и 2:

void GetFillArray(int[] collection)
{
    Random randomaiser = new Random();
    for( int i = 0; i < collection.Length; i++)
    {
        collection[i] = randomaiser.Next(0, 2);
    }
}

// или:

int [] InitArray(int length)
{
    int [] arr = new int[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

// или:

int[] arrayCreation(int length){
    int[] arr = new int[length];
    Random rnd = new Random();
    for ( int i = 0 ; i< length ; i ++){
        arr[i] = rnd.Next(-9,10);
    }
return arr;}

// Сумма положительных и отрицательных чисел:

int GetPositiveSummFromArray(int [] arr)
{
    int summ = 0;

    foreach(int item in arr)
    {
        if(item > 0);
            summ += item;
    }
    return summ;
}

int GetNegativeSummFromArray(int [] arr)
{
    int summ = 0;

    foreach(int item in arr)
    {
        if(item < 0);
            summ += item;
    }
    return summ;
}

// Вывести массив:

void PrintArray(int [] arr)
{
    foreach(int item in arr)
        Console.WriteLine($"{item}");
}

// или:

string PrintArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) result = "[ " + Convert.ToString(array[i]) + ", ";//string builder
        else if (i < array.Length-1)
            result = result + Convert.ToString(array[i]) + ", ";
        else result = result + Convert.ToString(array[i]) + "]";
    }
return result;
}

// Сумма чисел в массиве:

(int, int)GetSummsFromArray(int [] arr)
{
int positiveSumm = 0;
int negativeSumm = 0;

foreach(int item in arr)
{
    if(item > 0)
        positiveSumm += item;
    else
        negativeSumm += item;
}

return (positiveSumm, negativeSumm);
}

//метод, который инициализирует массив из 12 элементов в промежутке от [-9, 9]

int [] InitArray(int length)
{
    //length12515asgagzxvas = length, значимый тип, value type
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(-9, 10); // [a,b)
}

return arr;
}

// Произведение отриц чисел:

int [] MultipleNegative(int [] array)
{
    int [] newArray = new int [array.Length];
    for(int i = 0; i < array.Length; i++)
    {
       newArray[i] = array[i] * (-1);
    }
    return newArray;
}

// Проверка массива:

string LookUp(int[] array,string lookUpNumber)
{
    string result = "Нет";
    int LookUpNumber = int.Parse(lookUpNumber);
    foreach (int item in array){
        if ( item == LookUpNumber) result = "Да";
    }
return result;
}

// или:

int GetFindNumbers(int [] array)
{
    int count = 0;
    foreach(int item in array)
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99);
            count++;
    }
    return count;
}

// Умножение пар чисел:

int [] Multiple (int[] array) 
{ 
    int length = 0; 
    bool even =false; 
    if (array.Length % 2 == 0) 
    { 
        length = array.Length / 2; 
        even = true; 
    } 
    
    else  
    length = array.Length / 2 + 1; 
    int[] newArray = new int[length]; 
    for (int i = 0; i < array.Length/2;i++) 
    { 
        newArray[i] = array[i] * array[array.Length -1 - i]; 
         
    } 
    if (even == false) 
    { 
        newArray[newArray.Length -1] = array[array.Length/2]; 
         
    } 
 
    return newArray; 
 
 
} 

// Печать двумерного массива:

void PrintArray(int [,] matr);
{
    for(int i = 0; i < matr.GetLength(0); i++);
    {
        for(int j = 0; j < matr.GetLength(1); j++);
        {
            Console.Write($"{matr[i, j]}");
        }
    }
    Console.WriteLine();
}

// Создать двумерный массив случайных чисел:

void FillArray(int [,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++);
    {
        for(int j = 0; j < matr.GetLength(1); j++);
        {
            matr[i,j] = new Random().Next(1,10); // [1,10]
        }
    }
}

// посчитать четные числа

int GetCountEven(int [] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
            count++;
    }
    return count;
}