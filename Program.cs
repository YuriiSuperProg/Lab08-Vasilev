// PrintLine();
// Console.WriteLine("Привет!");

// static void PrintLine()
// {
//     Console.Write("^_^ ");    
// }

// Greet("Влад");
// Greet("Кирилл");

// static void Greet(string name)
// {
//     Console.WriteLine($"Привет, {name}!");
// }

// static  int Sum(int a, int b)
// {
//     return a + b;
// }

// int result = Sum(3, 5);
// Console.WriteLine(result);
// Console.WriteLine(Sum(10, 20));

// Задание 1

// PrintLine();
// Console.WriteLine("Отчет");
// PrintLine();

// PrintHeader("Заголовок 1");
// PrintHeader("Заголовок 2");


// static void PrintLine()
// {
//     Console.WriteLine("^_^");
// }

// static void PrintHeader(string title)
// {
//     PrintLine();
//     Console.WriteLine($"Заголовок: {title}");
//     PrintLine();
// }

// Задание 2.1

// int result = Max(5, 10);
// Console.WriteLine(result);

// static int Max(int a, int b)
// {
//     if (a > b)
//     {
//         return a;
//     }

//     else
//     {
//         return b;
//     }
// }

// int[] marks = {5, 4, 3, 5, 4};
// Console.WriteLine(SumArray(marks));

// static int SumArray(int[] arr)
// {
//     int sum = 0;
//     foreach(int x in arr)
//     {
//         sum += x;
//     }
//     return sum;
// }

// Задание 3

// double[] marks = {120, 45, 300, 80, 15, 210};

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine(Average(marks));
// Console.WriteLine($"Количество чисел больше {num}: {CountGreater(marks, num)}");

// static double Average(double[] arr)
// {
//     double sum = 0;
//     double count = 0;
//     foreach(double x in arr)
//     {
//         sum += x;
//         count++;
//     }
//     double avr = (double)sum / count;
//     return avr;
// }

// static int CountGreater(double[] arr, double limit)
// {
//     int count = 0;
//     foreach(int x in arr)
//     {
//         if (x > limit)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Задание 4

// Console.WriteLine(ToFahrenheit(0));
// Console.WriteLine(ToFahrenheit(100));
// Console.WriteLine(ToFahrenheit(37));
// static double ToFahrenheit(double celsius)
// {
//   double fahrenheit = celsius * 9 / 5 + 32;
//   return fahrenheit;  
// }


// Самостоятельные задания 

// Задание 5. Факториал и простое число.

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// long res = Factorial(num);
// Console.WriteLine($"Факториал: {num}: {res}");

// static long Factorial(int n)
// {
//     long result = 1;
//     for(int i = 2; i <= n; i++)
//     {

//        result *= i;

//     }
//     return result;
// }

// static bool isPrime(int n)
// {
//    if (n < 2) return false;
//    for (int i = 2; i * i <= n; i++)
//     {
//         if (n % i == 0) return false;
//     }
//     return true;
// }

// for (int i = 2; i <= 50; i++)
// {
//     if (isPrime(i))
//     {
//         Console.WriteLine($"{i} ");
//     }
// }

// Задание 6. Ввод с проверкой.

// int a = ReadPositive("Введите первое положительное число: ");
// int b = ReadPositive("Введите второе положительное число: ");
// Console.WriteLine($"Сумма: {a + b}");

// static int ReadPositive(string message)
// {
//     int value;
//     do
//     {
//         Console.Write(message);
//         value = int.Parse(Console.ReadLine());
//     } while (value <= 0);

//     return value;
// }


// Итоговая задача. «Меню-калькулятор»

// int num;

// do
// {
//     Console.WriteLine(">1 - сумма двух чисел");
//     Console.WriteLine(">2 - больше из двух чисел");
//     Console.WriteLine(">3 - факториал");
//     Console.WriteLine(">0 - выход");

//     Console.Write("Выберите команду: > ");
//     num = int.Parse(Console.ReadLine());

//     switch (num)
//     {
//         case 1:
//             int a = ReadPositive("Первое число: ");
//             int b = ReadPositive("Второе число: ");
//             Console.WriteLine($"Сумма: {Sum(a, b)}");
//             break;
//         case 2:
//             int x = ReadPositive("Первое число: ");
//             int y = ReadPositive("Второе число: ");
//             Console.WriteLine($"Больше: {Max(x, y)}");
//             break;
//         case 3:
//             int n = ReadPositive("Число: ");
//             Console.WriteLine($"Факториал {n} = {Factorial(n)}");
//             break;
//         case 0:
//             Console.WriteLine("Выход.");
//             break;
//         default:
//             Console.WriteLine("Неизвестная команда.");
//             break;
//     }
// } while (num != 0);

// static int ReadPositive(string message)
// {
//     int value;
//     do
//     {
//         Console.Write(message);
//         value = int.Parse(Console.ReadLine());
//     } while (value <= 0);
//     return value;
// }

// static int Sum(int a, int b)
// {
//     return a + b;
// };

// static int Max(int a, int b)
// {
//     if (a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// };

// static long Factorial(int n)
// {
//     long result = 1;
//     for (int i = 2; i <= n; i++) result *= i;
//     return result;
// }

// Дополнительное задание ★★★

// Console.WriteLine($"Gcd(48, 18) = {Gcd(48, 18)}"); 
// Console.WriteLine($"Lcm(4, 6)   = {Lcm(4, 6)}"); 

// static int Gcd(int a, int b)
// {
//     while (b != 0)
//     {
//         (a, b) = (b, a % b);  
//     }
//     return a;
// }

// static int Lcm(int a, int b)
// {
//     return a / Gcd(a, b) * b; 
// }