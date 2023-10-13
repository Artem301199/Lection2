// напишите программу , которая будет выдавать название дня недели по заданному номеру 
Console.WriteLine("введите номер : ");
int a = Convert.ToInt32(Console.ReadLine());
 if (a == 1)
{
Console.WriteLine("понедельник");
}
else if (a == 2)
{
Console.WriteLine("вториник");
}
else if (a == 3)
{
Console.WriteLine("среда");
}
else if (a == 4)
{
Console.WriteLine("четверг");
}
else if (a == 5)
{
Console.WriteLine("пятница");
}
else if (a == 6)
{
Console.WriteLine("суббота");
}
else if (a == 7)
{
Console.WriteLine("Воскресенье");
}
else
{
    System.Console.WriteLine("Такого числа нет");
}