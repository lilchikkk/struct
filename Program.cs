namespace strukt_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Struct");

            Coordinate point = new Coordinate(3, 5);
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);
            Console.WriteLine("------------------------");

            //add  name and age
            IntAndString person = new IntAndString("Lily", 16);
            Console.WriteLine($"Name: = {person.Name}");
            Console.WriteLine($"Age: = {person.Age}");
            Console.WriteLine("------------------------");

            //add city and postal code
            InsertedIntAndString data = new InsertedIntAndString("Tallinn", 1045);
            Console.WriteLine($"City: = {data.City}");
            Console.WriteLine($"PostalCode: = {data.PostalCode}");
        }
    }
    //Mis on struct?
    //see on väärtyustüüp (value type), mis sarnaeb klassile    
    struct Coordinate
    {
        public int X;
        public int Y;

        //teha konstruktor
        public Coordinate(int x, int y)
        {  
            X = x;
            Y = y;
        }
    } 

    //teha struct nimega InsertedIntAndString
    //string City ja int on PostalCode
    //kutsuda see struct Mains välja
    //structi  sees tuleb sellele anda juba väärtus
    struct IntAndString
    {
        public string Name;
        public int Age;
        public IntAndString(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

}
struct InsertedIntAndString
{
    public string City;
    public int PostalCode;
    public InsertedIntAndString(string city, int postalCode)
    {
        City = city;
        PostalCode = postalCode;
    }

}

