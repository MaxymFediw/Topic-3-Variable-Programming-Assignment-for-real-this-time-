namespace Topic_3_Variable_Programming_Assignment__for_real_this_time_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Maxym

            //Part 1
            string courseName;

            int roomNumber;

            double price;

            courseName = "Computer Science";
            roomNumber = 29;
            price = 2.99;

            Console.WriteLine();

            Console.WriteLine("This is room #" + roomNumber + ".");
            Console.WriteLine();
            Console.WriteLine("The price is $" + price + ".");
            Console.WriteLine();
            Console.WriteLine("I am learning a bit about " + courseName + "!");

            Console.WriteLine();        
            
            //Part 2

            string name;

            int graduation;

            name = "Maxym Fediw";
            graduation = 2027;

           

            Console.WriteLine("My name is " + name + " and I'll graduate in the summer of " + graduation + ".");

            Console.WriteLine();    

            //Part 3

            const double Pi = 3.14159;
            double radius;

            radius = 12.0;
            double area;

            area = Pi * radius * radius;

           

            Console.WriteLine("The area of the circle is: " + area + ".");

            Console.WriteLine();

            //Tried to round it, but the methods Google was giving was not working...

            //Part 4

            //If we have a birthday cake, and its lenght is 20cm, and width is 12cm. If how long of a bow will we need to go along the perimeter of the cake?


            int width;

            int length;

            width = 12;

            length = 20;

            int perimiter;

            perimiter =  width + width + length + length;

            Console.WriteLine("The length of the bow that will be needed to wrap around the perimeter of the cake will be " + perimiter + "cm." );

           


            

            

           

          

            










        }
    }
}
