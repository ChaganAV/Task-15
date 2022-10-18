// программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day>0 && day <=7)
{
    if (day > 5)
        Console.WriteLine("Да, это выходной");
    else
        Console.WriteLine("Нет, это будни");
}
else
    Console.WriteLine("Извините, такого дня недели нет!");
