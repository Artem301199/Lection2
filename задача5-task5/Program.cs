// Напишите программу которая на входе принимает трехзначное число и на выходе 
//..показывает последнюю цифру этого числа ^ 456 -> 6
System.Console.WriteLine("Введите ваше число : ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 10;
System.Console.WriteLine(b);
