namespace Assignment7
{
    internal class Program
    {
        #region 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
        //struct Point
        //{
        //    public double x { get; set; }
        //    public double y { get; set; }
        //    public Point(double _x, double _y)
        //    {
        //        x = _x;
        //        y = _y;
        //    }

        //    public override string ToString()
        //    {
        //        return $"({x},{y})";
        //    }
        //}
        //static Point CreatePoint()
        //{
        //    Point point = new Point();

        //    Console.Write("X: ");
        //    point.x = double.Parse(Console.ReadLine());

        //    Console.Write("Y: ");
        //    point.y = double.Parse(Console.ReadLine());

        //    return point;
        //}

        //static double CalcDistance(Point p1, Point p2)
        //{
        //    return Math.Sqrt(Math.Pow(p1.x-p2.x, 2) + Math.Pow(p1.y-p2.y, 2));
        //}
        #endregion

        #region 2.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        //struct Person
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }

        //    public Person(string _name, int _age)
        //    {
        //        Name = _name;
        //        Age = _age;
        //    }

        //    public override string ToString()
        //    {
        //        return $"Name: {Name} , Age: {Age}";
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter The First Point");

            //Point p1 = CreatePoint();

            //Console.WriteLine("Enter The Second Point");

            //Point p2 = CreatePoint();

            //Console.WriteLine($"Distance = {CalcDistance(p1, p2)}");
            #endregion

            #region 2.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Console.Write("Enter Numbers of Person You will Entry:");
            //int num = int.Parse(Console.ReadLine());

            //Person[] persons = new Person[num];

            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    persons[i] = DisplayPerson();
            //}

            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            //static Person DisplayPerson()
            //{
            //    Console.Write("Enter Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Enter Age: ");
            //    int age = int.Parse(Console.ReadLine());

            //    return new Person(name, age);
            //}
            #endregion
        }
    }
}
