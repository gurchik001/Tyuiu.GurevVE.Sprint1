using Tyuiu.GurevVE.Sprint1.Task1.V0.Lib;
namespace Tyuiu.GurevVE.Sprint1.Task1.V0;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Гурьев В. Э. | Смартб-26-1";
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #1                                                             *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                           *");
        Console.WriteLine("* Задание #1                                                            *");
        Console.WriteLine("* Вариант #13                                                           *");
        Console.WriteLine("** Выполнил: Гурьев Владислав Эдуардович | Смартб-26-1                  *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                              *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные       *");
        Console.WriteLine("* данные, вычисляет результат по формуле x/(0.5*x)                      *");
        Console.WriteLine("* и печатает результат на экране.                                                                      *");
        Console.WriteLine("***************»*********************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
        Console.WriteLine("*************************************************************************");

        double x;
        Console.WriteLine("Введите значение x ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************»*********************************************************");
        Console.WriteLine("* Результат:                                                            *");
        Console.WriteLine("***************»*********************************************************");
        Console.WriteLine(ds.Calculate(x));

        Console.ReadLine();
    }
}