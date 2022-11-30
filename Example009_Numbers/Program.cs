
int[] array = {1, 12, 31, 4, 15, 16, 17, 18};

int n = array.Length;
int find = 4;

int index = 0;


while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}



void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}



void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
      Console.WriteLine(col[position]);
      position++;  
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
         position = index;   
         break;
        }
        index++;
    }
    return position;
}

int[] arrayOne = new int[10];


FillArray(arrayOne);
PrintArray(arrayOne);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
