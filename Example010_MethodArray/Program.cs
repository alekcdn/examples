int[] array = {1, 2, 3, 4, 67, 32, 76, 32};

int n = array.Length;
int find = 76;

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
