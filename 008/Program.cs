int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1=213, b1=13, c1=132, a2=12333, b2=35, c2=324, a3=76, b3=185, c3=55;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max (max1, max2, max3);

Console.WriteLine(max);
