int Max(int arg1, int arg2, int arg3) // ф-ция Мах
{
    int result = arg1; 
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; 
}



int[] array = {11, 21, 35, 57, 78, 14, 511, 68, 45};  //помним, что индексы массивов начинаются с нуля
// array[0] = 12; //так можно обратиться к массиву и записать в него значение
// Console.WriteLine(array[0]); //выводит значение элемента массива с указанным индексом

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);