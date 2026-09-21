using Tyuiu.GurevVE.Sprint1.Task0.V13.Lib;
namespace Tyuiu.GurevVE.Sprint1.Task0.V13;


class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Гурьев В. Э. | Смартб-26-1";
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #1                                                             *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                      *");
        Console.WriteLine("* Задание #1.0                                                          *");
        Console.WriteLine("* Вариант #13                                                           *");
        Console.WriteLine("** Выполнил: Гурьев Владислав Эдуардович | Смартб-26-1                  *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                              *");
        Console.WriteLine("Написать программу, которая вычисляет выражение 24 / (6 * 2) - 24 / 6 / 4");
        Console.WriteLine("* и печатает результат на экране.                                       *");
        Console.WriteLine("*                                                                       *");
        Console.WriteLine("***************»*********************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("24 / (6 * 2) - 24 / 6 / 4                                               *");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(ds.Calculate());
        Console.ReadKey();
    }
    
}