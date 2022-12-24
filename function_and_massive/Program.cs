int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (result < arg2) result = arg2;
  if (result < arg3) result = arg3;
  return result;
};


int a1 = 58;
int b1 = 96;
int c1 = 11;
int a2 = 74;
int b2 = 894;
int c2 = 197;
int a3 = 88;
int b3 = 5;
int c3 = 95;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// применение фунции
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// применение вложенной функции
int max = Max(
  Max(a1, b1, c1), 
  Max(a2, b2, c2), 
  Max(a3, b3, c3));

Console.WriteLine(max);