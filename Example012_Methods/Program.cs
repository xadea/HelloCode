//типы методов

// 1 - ничено не принимает и ничего не возвращает

void Method1()
{
    Console.WriteLine("Text...");
}
Method1();

// 2 - принимают аргументы, но ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
       
Method21("text", 4);
 // варианты вызова метода:
 // Method21 (msg: "text", count: 4);
 // Method21 (count: 4 , msg: "text");


 // 3 - возвращают, но не принимают

 int Method3()
 {
    return DateTime.Now.Year;
 }
 int year = Method3(); 
 Console.WriteLine(year);


 // 4 - принимает и возвращает

 string Method4(int count, string text)
 {
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
 }

 string res = Method4(4, "la-la-");
 Console.WriteLine(res);

 // 4-й метод с циклом for

 string Method41(int count1, string text1)
 {
    string result1 = String.Empty;

    for(int i=0; i < count1; i++)
    {
        result1 = result1 + text1;
    }
    return result1;
 }

 string res1 = Method41(4, "tra-la-la ");
 Console.WriteLine(res1);


 // таблица умножения

 for (int i=2; i<=10; i++)
 {
    for (int j=2; j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
 }

//
// пример с заменой символов

string text = "Alas, my love, you do me wrong,"
            + "To cast me off discourteously."
            + "For I have loved you well and long,"
            + "Delighting in your company.";

// string s = "qwerty"
//             012345
// s [3] // r    

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i=0; i<length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string NewText = Replace(text, ' ', '|');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace(NewText, 'a', 'A');
Console.WriteLine(NewText);
Console.WriteLine();

// упорядочивание массива

int[] arr = {9, 3, 5, 7, 2, 6, 8, 1, 3};

void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i=0; i<array.Length-1; i++)
    {
        int minPosition = i;
        for(int j=i+1; j<array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i]= array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);