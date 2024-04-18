using Interfaces;

IFruit banana = new Banana();

string output = banana.Peel();
System.Console.WriteLine(output);

var orange = new Orange();

var fruitSalad = new List<IFruit>();
fruitSalad.Add(orange);
fruitSalad.Add(new Banana());
fruitSalad.Add(new Grape());

foreach (var fruit in fruitSalad)
{
    System.Console.WriteLine(fruit.Name);
    System.Console.WriteLine(fruit.Peel());
}

System.Console.WriteLine(orange.Squeeze());

namespace Interfaces
{
    public interface IFruit
    {
        string Name { get; }        // Property iwth only a Get
        bool Peeled { get; set; }   // Property with a Get and Set
        string Peel();              // Method with only a return type and no parameters
    }

    public class Banana : IFruit
    {
        public string Name
        {
            get { return "Banana"; }
        }

        public bool Peeled { get; set; }

        public string Peel()
        {
            Peeled = true;
            return "You peel the banana.";
        }
    }

    public class Orange : IFruit
    {
        public string Name
        {
            get { return "Orange"; }
        }

        public bool Peeled { get; set; }

        public string Peel()
        {
            Peeled = true;
            return "You peel the orange.";
        }

        public string Squeeze()
        {
            return "You squeeze the orange and juice comes out.";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get { return "Grape"; }
        }

        public bool Peeled { get; set; }

        public string Peel()
        {
            return "Who peels grapes?";
        }
    }
}