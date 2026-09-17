int[] first = { 1, 2, 3 };
int[] second = { 4, 5, 6, 7 };

int[] result = MergeArrays(first, second);

for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}

Console.ReadKey();

int[] MergeArrays(int[] a, int[] b)
{
    int[] res = new int[a.Length + b.Length];

    for (int i = 0; i < a.Length; i++)
    {
        res[i] = a[i];
    }

    for (int i = 0; i < b.Length; i++)
    {
        res[a.Length + i] = b[i];
    }

    return res;
}