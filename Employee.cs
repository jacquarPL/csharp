namespace ChallangeApp
{
    public class Employee
    {
         //delegaty i eventy
         public delegate string GradeAddedDelegate(object sender, EventArgs args);
         
         public event GradeAddedDelegate GradeAdded;
         
         //private string name;     //zastąpione propercją
         private List<double> grades = new List<double>();
        public Employee(string name)
        {
             this.Name = name;
        }

        //public void AddGrade(double grade)
        public void AddGrade(string grade)
        {
            if(int.TryParse(grade, out int result))
            {
                if(result >= 0 && result <=100)
                {
                    this.grades.Add(result);
                    if(GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    //Console.WriteLine("Invalid value");
                    throw new ArgumentException($"Złe dane: {nameof(grade)}");
                }
            }
        }
        /*
        // udostepnienie zmiennej prywatnej w postaci propercji
        public string Name
        {
            get 
            {
                return this.name;
            }
        }
     */
        //to samo prosciej 
        public string Name { get; set; }
        //przeniesione do oddzielnej klasy
        // public void ShowStatistics()
        // {
        //     var result = 0.0;
        //     var highGrade = double.MinValue;
        //     var lowGrade = double.MaxValue;

        //     foreach(var n in this.grades)
        //     {
        //         lowGrade = Math.Min(lowGrade, n);
        //         highGrade = Math.Max(highGrade, n);
        //         result += n;
        //     }
        //     Console.WriteLine($"Max to: {highGrade:N2}");
        //     Console.WriteLine($"Min to: {lowGrade:N2}");
        // }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;

             foreach(var  grade in grades)
             {
                 result.Low = Math.Min(result.Low, grade);
                 result.High = Math.Max(result.High, grade);
                 result.Average += grade;
             }
             result.Average /= grades.Count;

             switch(result.Average)
             {
                 case var d when d >= 90:
                    result.Letter = 'A';
                    break;
                
                case var d when d >= 80:
                    result.Letter = 'B';
                    break;

                default:
                    result.Letter = 'Z';
                    break;
             }

             return result;
        }
    }
}