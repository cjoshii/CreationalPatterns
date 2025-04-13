using Singleton;
using Prototype;
using AbstractFactory;
using Builder;
using FactoryMethod;
using FactoryMethod.Logistics;
using FactoryMethod.Dialog;
using AbstractFactory.Furniture;

Console.WriteLine("Hello! Welcome to Singleton Pattern Example");

var instance1 = SimpleSingletonExample.Instance;
var instance2 = SimpleSingletonExample.Instance;

if (instance1.Equals(instance2))
{
    Console.WriteLine("Both instances are the same");
}
else
{
    Console.WriteLine("Both instances are different");
}


Console.WriteLine("Prototype Example!");

var shapes = new List<Shape>();

var circle = new Prototype.Circle();
circle.X = 10;
circle.Y = 10;
circle.Radius = 20;

shapes.Add(circle);
for (int i = 0; i < 9; i++)
{
    shapes.Add(circle.Clone());
}


var rectangle = new Prototype.Rectangle();
rectangle.X = 10;
rectangle.Y = 10;
rectangle.Width = 20;
rectangle.Height = 30;

shapes.Add(rectangle);

for (int i = 0; i < 9; i++)
{
    shapes.Add(rectangle.Clone());
}

foreach (var shape in shapes)
{
    Console.WriteLine(shape);
}

for (int i = 1; i < shapes.Count; i++)
{
    if (shapes[i].Equals(shapes[i - 1]))
    {
        Console.WriteLine("Shapes are the same");
    }
    else
    {
        Console.WriteLine("Shapes are different");
    }
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Welcome to the Shape Factory! Chose a shape to draw:");
Console.WriteLine("1. Rectangle");
Console.WriteLine("2. Square");
Console.WriteLine("3. Circle");
Console.WriteLine("4. Triangle");

var input = Console.ReadLine();
ShapeFactory? factorym = null;

if (input == "1")
{
    factorym = new RectangleFactory();
}
else if (input == "2")
{
    factorym = new SquareFactory();
}
else if (input == "3")
{
    factorym = new CircleFactory();
}
else if (input == "4")
{
    factorym = new TriangleFactory();
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
}

if (factorym != null)
{
    var shape = factorym.GetShape();
    shape.Draw();
}



//-----------------------------Drawing Pad Example--------------------------------//


Console.WriteLine("Hello! Welcome to the Drawing Pad! Please select a category to draw from:");
Console.WriteLine("1. Animals");
Console.WriteLine("2. Vehicles");
Console.WriteLine("3. Science");

input = Console.ReadLine();

DrawingPad? drawingPad = null;

if (input == "1")
{
    drawingPad = new AnimalDrawingPad();
}
else if (input == "2")
{
    drawingPad = new VehicleDrawingPad();
}
else if (input == "3")
{
    drawingPad = new ScienceDrawingPad();
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
}

if (drawingPad != null)
{
    drawingPad.Draw();
}


//-----------------------------Logistics Example--------------------------------//
Console.WriteLine("Hello! Welcome to the Logistics System! Please select a logistics type:");
Console.WriteLine("1. Road");
Console.WriteLine("2. Sea");
Console.WriteLine("3. Air");
input = Console.ReadLine();
Logistics? logistics = null;
if (input == "1")
{
    logistics = new RoadLogistics();
}
else if (input == "2")
{
    logistics = new SeaLogistics();
}
else if (input == "3")
{
    logistics = new AirLogistics();
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
}

if (logistics != null)
{
    var transport = logistics.CreateTransport();
    transport.Deliver();
}

//-----------------------------Dialog Example--------------------------------//
var dialog = new WinDialog();
dialog.Render();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,! Welcome to the Computer Store!");

IComputerBuilder builder = new ComputerBuilder();
ComputerBuilderDirector director = new ComputerBuilderDirector(builder);

IComputer gamingPC = director.BuildGamingPC();
IComputer miningPC = director.BuildMiningPC();
IComputer developmentPC = director.BuildDevelopmentPC();
IComputer customPC = director.BuildCustomPC("Intel i9", "64GB", "Nvidia RTX 3090", "2TB SSD");

Console.WriteLine("Gaming PC:");
gamingPC.Display();

Console.WriteLine("Mining PC:");
miningPC.Display();

Console.WriteLine("Development PC:");
developmentPC.Display();


Console.WriteLine("Custom PC:");
customPC.Display();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! What animal kind of animal do you want to play with?");
Console.WriteLine("1. Wild");
Console.WriteLine("2. Domestic");

int choice = 0;

while (true)
{
    try
    {
        input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("Invalid choice, please try again");
            continue;
        }

        choice = int.Parse(input);
        break;
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid choice, please try again");
    }
}

IAnimalFactory? factory = null;

switch (choice)
{
    case 1:
        factory = WildAnimalFactory.Instance;
        break;
    case 2:
        factory = DomesticAnimalFactory.Instance;
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

if (factory != null)
{
    IDog dog = factory.CreateDog();
    Console.WriteLine((choice == 1 ? "Wild" : "Domestic") + " Dog " + dog.Speak());

    ICat cat = factory.CreateCat();
    Console.WriteLine((choice == 1 ? "Wild" : "Domestic") + " Cat " + cat.Speak());
}

//Lets use new furniture factory
var furnitureFactory = choice == 1 ? ModernFurnitureFactory.Instance : ClassicFurnitureFactory.Instance;
var furnitureClient = new FurnitureClient(furnitureFactory);
furnitureClient.DescribeFurniture();