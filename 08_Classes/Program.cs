using Classes;

Donut veryBerry = new Donut("Jam Filled");
// veryBerry.donutType = "Jam Filled";
System.Console.WriteLine(veryBerry.GetDonutType());
veryBerry.SetDonutType("Jelly Filled");
System.Console.WriteLine(veryBerry.GetDonutType());

namespace Classes
{
    class Donut
    {
        private string donutType;

        // public Donut(){}

        public Donut(string type)
        {
            donutType = type;
        }

        public string Filling { get; set; }
        public string Topping { get; set; }
        public double Price { get; set; }
        public bool IsSpecial { get; set; }
        

        public string GetDonutType()
        {
            return donutType;
        }

        public void SetDonutType(string type)
        {
            donutType = type;
        }

    }
}