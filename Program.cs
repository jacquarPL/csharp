namespace ChallangeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 3;
           /*
            var a= 10.0f;
            var b = 11.324324234;
            var name = "Jacek";
            var dd = name + a;

            var result = a * b;

            var numbers = new double[3];
            numbers[0] = 12.9;
            numbers[1] = 3;
            numbers[2] = 0.333;

            result = numbers[0];
            result += numbers[1];
            result += numbers[2];
            
            var result2 = numbers.Sum();

            numbers = new[] {12.5, 5, 0.333};
            result = 0;
            foreach(var n in numbers)
            {
                result += n;
            }

            var numbers2 = new List<double>(){12.4, 5, 0.33};
            result = 0.0;
            foreach(var n in numbers2)
            {
                result += n;
            }

            result /= numbers2.Count;

            Console.WriteLine($"Średnia to: {result:N3}");
            
            //Console.WriteLine(args[0]);
            //Console.WriteLine("Hello, World!");
            
            if(args.Length > 0){
                Console.WriteLine($"Hello {args[0]}");
            } else {
                Console.WriteLine("Hello, World!");
            }
*/
            //dzien 5. Klasy
            var employee = new Employee("Mieszko");
            employee.GradeAdded += OnGradeAdded;

            //zadanie domowe dzień 9 - string parse na int
            employee.AddGrade("24");
            employee.AddGrade("4");
            employee.AddGrade("2.4");
            var stat = employee.GetStatistics();
            Console.WriteLine($"Średnia {stat.Average:N2}");
            Console.WriteLine($"Max {stat.High}");
            Console.WriteLine($"Min {stat.Low}");

            //dzien 11. petla for
            var names = new [] {"Adam", "Jan", "Tomasz", "Mieszko"};
            var ages = new[] {27, 29, 36, 5};
            for(var i = 0; i < names.Count(); i++)
            {
                Console.WriteLine($"{names[i]} {ages[i]}");
            }

            //dzien 12. INPUT
            while(true)
            {
                Console.WriteLine($"Cześć. Podaj ocenę dla {employee.Name}");
                var input = Console.ReadLine();
                
                if(input == "q")
                {
                    break;
                }
                try
                {
                    //var grade = double.Parse(input); gdyby byly doublami
                    employee.AddGrade(input);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                /*
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Finaly");
                }
                */
            }
            stat = employee.GetStatistics();
            Console.WriteLine($"Średnia {stat.Average:N2}");
            Console.WriteLine($"Max {stat.High}");
            Console.WriteLine($"Min {stat.Low}");
            Console.WriteLine($"Litera: {stat.Letter}");
        }
        static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine($"Nowa ocena dodana");
        }
    }
    //przesiesiona do nowego pliku
    // public class Employee
    // {
    //     private string name;
    //     public Employee(string name)
    //     {
    //         this.name = name;
    //     }
    // }
    
}