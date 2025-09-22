//int n = int.Parse(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if (i + j == n - 1) Console.Write("?");
//        else if (i - j == 0) Console.Write("*");
//        else Console.Write(" ");
//    }
//    Console.WriteLine();
//}


//int n = int.Parse(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if (n / 2 == j) Console.Write("*");
//        else if (n / 2 == i) Console.Write("-");
//        else Console.Write(" ");
//    }
//    Console.WriteLine();
//}

//for (int i = 10; i < 100; i++)
//{
//    if(i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}


//int sum = 0;
//for(int i = 100; i < 1000; i++)
//{
//    if(i % 2 != 0)
//    {
//        sum = sum + i;
//    }
//}
//Console.WriteLine(sum);


//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//if (a / b % 2 == 0) 
//    Console.WriteLine("Tak");


//int a = int.Parse(Console.ReadLine());
//int suma = 0;
//for (int i = a; i > a; i++)
//{
//    if (a % 2 == 0) 
//    {
//        suma = suma + i;
//    }
//}
//Console.WriteLine(suma);


//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//if (a != b && a != c && b != c);
//Console.WriteLine("tak");

//for (int i = 10; i < 100; i++)
//{
//    if(i % 13 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    if (a - b == b / 2)
        Console.WriteLine("tak");
    else
        Console.WriteLine("Nie");
} 