#region part 1

#region problem1
//using System;

//interface IVehicle
//{
//    void StartEngine();
//    void StopEngine();
//}

//class Car : IVehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Car engine started.");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Car engine stopped.");
//    }
//}

//class Bike : IVehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Bike engine started.");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Bike engine stopped.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        IVehicle car = new Car();
//        IVehicle bike = new Bike();

//        car.StartEngine();
//        car.StopEngine();

//        bike.StartEngine();
//        bike.StopEngine();
//    }
//} 
#endregion


#region problem2

//using System;

//abstract class Shape
//{
//    public abstract double GetArea();

//    public virtual void Display()
//    {
//        Console.WriteLine("This is a shape.");
//    }
//}

//class Rectangle : Shape
//{
//    private double width;
//    private double height;

//    public Rectangle(double width, double height)
//    {
//        this.width = width;
//        this.height = height;
//    }

//    public override double GetArea()
//    {
//        return width * height;
//    }

//    public override void Display()
//    {
//        Console.WriteLine("Rectangle: Width = {0}, Height = {1}, Area = {2}", width, height, GetArea());
//    }
//}

//class Circle : Shape
//{
//    private double radius;

//    public Circle(double radius)
//    {
//        this.radius = radius;
//    }

//    public override double GetArea()
//    {
//        return Math.PI * radius * radius;
//    }

//    public override void Display()
//    {
//        Console.WriteLine("Circle: Radius = {0}, Area = {1}", radius, GetArea());
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Shape[] shapes = { new Rectangle(5, 3), new Circle(4) };

//        foreach (Shape shape in shapes)
//        {
//            shape.Display();
//        }
//    }
//} 
#endregion


#region problem3

//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product : IComparable<Product>
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Price { get; set; }

//    public int CompareTo(Product other)
//    {
//        return Price.CompareTo(other.Price);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Product[] products = {
//            new Product { Id = 1, Name = "Product A", Price = 10.99 },
//            new Product { Id = 2, Name = "Product B", Price = 15.99 },
//            new Product { Id = 3, Name = "Product C", Price = 8.99 }
//        };

//        Array.Sort(products);

//        foreach (Product product in products)
//        {
//            Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
//        }
//    }
//} 
#endregion


#region problem4
//using System;

//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Grade { get; set; }

//    public Student(int id, string name, double grade)
//    {
//        Id = id;
//        Name = name;
//        Grade = grade;
//    }

//    // Deep copy constructor
//    public Student(Student other)
//    {
//        Id = other.Id;
//        Name = other.Name;
//        Grade = other.Grade;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student student1 = new Student(1, "Alice", 95.0);

//        // Shallow copy: Changes to student2 will affect student1
//        Student student2 = student1;

//        // Deep copy: Changes to student3 will not affect student1
//        Student student3 = new Student(student1);

//        student2.Name = "Bob";
//        student3.Name = "Charlie";

//        Console.WriteLine("Student 1: " + student1.Name);
//        Console.WriteLine("Student 2: " + student2.Name);
//        Console.WriteLine("Student 3: " + student3.Name);
//    }
//} 
#endregion


#region problem5
//using System;

//interface IWalkable
//{
//    void Walk();
//}

//class Robot
//{
//    public void Move()
//    {
//        Console.WriteLine("Robot is moving...");
//    }

//    void IWalkable.Walk()
//    {
//        Console.WriteLine("Robot is walking...");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Robot robot = new Robot();
//        robot.Move(); // Calls the regular Move() method

//        IWalkable walkableRobot = (IWalkable)robot;
//        walkableRobot.Walk(); // Calls the explicit interface implementation
//    }
//} 
#endregion


#region problem6
//using System;

//struct Account
//{
//    private int accountId;
//    private string accountHolder;
//    private double balance;

//    public int AccountId
//    {
//        get { return accountId; }
//        set { accountId = value; }
//    }

//    public string AccountHolder
//    {
//        get { return accountHolder; }
//        set { accountHolder = value; }
//    }

//    public double Balance
//    {
//        get { return balance; }
//        set { balance = value; }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Account account = new Account();
//        account.AccountId = 12345;
//        account.AccountHolder = "John Doe";
//        account.Balance = 1000.0;

//        Console.WriteLine("Account ID: " + account.AccountId);
//        Console.WriteLine("Account Holder: " + account.AccountHolder);
//        Console.WriteLine("Balance: " + account.Balance);
//    }
//} 
#endregion


#region problem7

//using System;

//public class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }

//    public Book()
//    {
//        Title = "Unknown";
//        Author = "Unknown";
//    }

//    public Book(string title)
//    {
//        Title = title;
//        Author = "Unknown";
//    }

//    public Book(string title, string author)
//    {
//        Title = title;
//        Author = author;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Book book1 = new Book();
//        Book book2 = new Book("The Lord of the Rings");
//        Book book3 = new Book("Pride and Prejudice", "Jane Austen");

//        Console.WriteLine("Book 1: Title = {0}, Author = {1}", book1.Title, book1.Author);
//        Console.WriteLine("Book 2: Title = {0}, Author = {1}", book2.Title, book2.Author);
//        Console.WriteLine("Book 3: Title = {0}, Author = {1}", book3.Title, book3.Author);
//    }
//}  
#endregion


#endregion




#region part 2


#region Create a Shape Series
//using System;

//interface IShapeSeries
//{
//    int CurrentShapeArea { get; set; }
//    void GetNextArea();
//    void ResetSeries();
//}

//class SquareSeries : IShapeSeries
//{
//    private int sideLength;

//    public int CurrentShapeArea { get; set; }

//    public void GetNextArea()
//    {
//        sideLength++;
//        CurrentShapeArea = sideLength * sideLength;
//    }

//    public void ResetSeries()
//    {
//        sideLength = 0;
//        CurrentShapeArea = 0;
//    }
//}

//class CircleSeries : IShapeSeries
//{
//    private int radius;

//    public int CurrentShapeArea { get; set; }

//    public void GetNextArea()
//    {
//        radius++;
//        CurrentShapeArea = (int)(Math.PI * radius * radius);
//    }

//    public void ResetSeries()
//    {
//        radius = 0;
//        CurrentShapeArea = 0;
//    }
//}

//class Program
//{
//    static void PrintTenShapes(IShapeSeries series)
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            series.GetNextArea();
//            Console.WriteLine($"Area of shape {i + 1}: {series.CurrentShapeArea}");
//        }
//        series.ResetSeries();
//    }

//    static void Main(string[] args)
//    {
//        SquareSeries squareSeries = new SquareSeries();
//        CircleSeries circleSeries = new CircleSeries();

//        Console.WriteLine("Square Series:");
//        PrintTenShapes(squareSeries);

//        Console.WriteLine("\nCircle Series:");
//        PrintTenShapes(circleSeries);
//    }
//} 
#endregion

#region Implement Sorting for Shapes

//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Shape : IComparable<Shape>
//{
//    public string Name { get; set; }
//    public double Area { get; set; }

//    public int CompareTo(Shape other)
//    {
//        return Area.CompareTo(other.Area);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        List<Shape> shapes = new List<Shape>();
//        shapes.Add(new Shape { Name = "Square", Area = 100 });
//        shapes.Add(new Shape { Name = "Circle", Area = 78.54 });
//        shapes.Add(new Shape { Name = "Rectangle", Area = 120 });

//        shapes.Sort();

//        foreach (Shape shape in shapes)
//        {
//            Console.WriteLine($"{shape.Name}: {shape.Area}");
//        }
//    }
//} 
#endregion

#region Extend the Shape Hierarchy

//using System;

//abstract class GeometricShape
//{
//    public double Dimension1 { get; set; }
//    public double Dimension2 { get; set; }

//    public abstract double CalculateArea();

//    public abstract double Perimeter { get; }
//}

//class Triangle : GeometricShape
//{
//    public override double CalculateArea()
//    {
//        return 0.5 * Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get
//        {
//            // Assuming it's a right-angled triangle
//            return Dimension1 + Dimension2 + Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
//        }
//    }
//}

//class Rectangle : GeometricShape
//{
//    public override double CalculateArea()
//    {
//        return Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get
//        {
//            return 2 * (Dimension1 + Dimension2);
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        GeometricShape triangle = new Triangle { Dimension1 = 3, Dimension2 = 4 };
//        GeometricShape rectangle = new Rectangle { Dimension1 = 5, Dimension2 = 2 };

//        Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
//        Console.WriteLine("Triangle Perimeter: " + triangle.Perimeter);

//        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
//        Console.WriteLine("Rectangle Perimeter: " + rectangle.Perimeter);
//    }
//}

#endregion



#region Implement Your Own Sorting
// static void SelectionSort(int[] numbers)
//{
//    int n = numbers.Length;

//    for (int i = 0; i < n - 1; i++)
//    {
//        int minIndex = i;
//        for (int j = i + 1; j < n; j++)
//            if (numbers[j] < numbers[minIndex])
//                minIndex = j;

//        // Swap the found minimum element with the first element
//        int temp = numbers[minIndex];
//        numbers[minIndex] = numbers[i];
//        numbers[i] = temp;
//    }
//} 
#endregion

#endregion