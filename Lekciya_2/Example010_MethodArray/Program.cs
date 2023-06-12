int[] array = {1,2,32,43,43,333,23,32,4};

int n = array.Length;
int find = 43;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}