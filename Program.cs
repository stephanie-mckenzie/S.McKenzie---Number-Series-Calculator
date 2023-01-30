namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

//Declare variables:
            int number = 0;
            string series = "";

//Set up while/break to catch incorrect entries:
            while (true)
            {
                Console.WriteLine("Please enter a number between 1-100.");
                number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= 100)
                {
                    break;
                }
            }

//Series selection prompt:
            Console.WriteLine("Please type either \"even\" or \"odd\" to generate your desires series.");
            series = (Console.ReadLine());
            
//Thanks for your entry prompt:
            Console.WriteLine("Thank you for your entry :) Please click the Enter/Return key to proceed.");
            Console.ReadLine();

//Odd series prompt:
            if (series == "odd")
            {
                Console.WriteLine("You have selected the " + series + " series. The " + series + " numbers between 0 and " + number + " are: ");
                for (int i = 1; i < number; i= i + 2)
                {
                    Console.WriteLine(i);
                }
            }

//Even prompt
            if (series == "even")
            {
                Console.WriteLine("You have selected the " + series + " series. The " + series + " numbers between 0 and " + number + " are: ");
                for (int i = 0; i < number; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }


            
        }
    }
}