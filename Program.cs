using loputoo;
using System;

class Program
{
    static void Main()
    {


        Console.WriteLine("Millist kujundit soovid? ul1 p1,ul2 p2, ul3");
        string valik = Console.ReadLine().ToLower();

        switch (valik)
        {
            case "ul1 p1":
                Where();//ul 1 part 1
                break;
            case "ul1 p2":
                Average();//ul 1 part 2
                break;
            case "ul2":
                IfandElse();
                break;
            case "ul3":
                NumberPyramid();//ul3
                break;
            default:
                Console.WriteLine("Sellist kujundit ei ole valikus.");
                break;
        }
    }

    static void Where()
    {
        var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

        foreach (var people in peopleAge)
        {
            Console.WriteLine(people.Name);
        }
    }

    static void Average()
    {
        Console.WriteLine("Average LINQ");

        var averageResult = PeopleList.peoples
            .Average(x => x.Age);

        Console.WriteLine(averageResult);
    }
    static void IfandElse()
    {
        Console.WriteLine("Kas tahad uut faili teha?");

        string ja = Console.ReadLine();

        if (ja == "ja")
        {
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filePath = @"C:/Users/Ingvar/Desktop/WriteToFile.txt";//tootab kui on oige directory see on lihtsalt example
            string inputText = Console.ReadLine();

            File.WriteAllText(filePath, inputText);
        }
        else
        {
            Console.WriteLine("ei taha");
        }
    }

    static void NumberPyramid()
    {
        int i, j, rows;
        int t = 1;
        Console.WriteLine("Numbri püramiid");

        Console.WriteLine("Sisesta ridade arv");

        rows = Convert.ToInt32(Console.ReadLine());


        for (i = 0; i <= rows; i++)
        {
            for (j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (j = 1; j <= 1 * i - 1; j++)
            {
                Console.Write("{0} ", t++);
            }
            Console.Write("\n");
        }

        }
    }
