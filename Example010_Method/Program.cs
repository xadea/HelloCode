//показать индекс искомого числа

int[] array = {1, 22, 95, 56, 33, 47, 77, 95, 18};

int n = array.Length;
int find = 95;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
};