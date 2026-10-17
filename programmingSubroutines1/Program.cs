namespace programmingSubroutines1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("How many hours worked: ");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many trains made: ");
            double trainsMade = Convert.ToDouble(Console.ReadLine());
            double totalWages = CalculateWages(hoursWorked, trainsMade);
            Console.WriteLine($"Total wages: £{totalWages}");*/


            //FISH TANK VOLUME CHALLENGE
            /*Console.WriteLine("Enter the length of the tank in cm: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the depth of the tank in cm: ");
            double depth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the tank in cm: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double volume = fishTankVolume(length, depth, height);
            Console.WriteLine($"The volume of the tank is: {(volume/1000.0)} litres ({volume/3785.41178} gallons)");*/


            //STRING MANIPULATION FUNCTIONS
            Console.WriteLine("Enter a string: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Which string manipulation function would you like to use ('ToUpper()', 'ToLower()', '.Length', '.Substring', 'Left(str,int)', 'Right(str,int)', 'Mid()', 'IndexOf()')");
            string functionChoice = Console.ReadLine();
            myString = stringFunction(myString, functionChoice);
            Console.WriteLine($"The result of the string manipulation is: {myString}");
        }
        /*static double CalculateWages(double hoursWorked, double trainsMade)
        {
            double wages = (hoursWorked * 9.0) + (trainsMade * 0.6);
            return wages;
        }*/


        /*static double fishTankVolume(double length, double depth, double height)
        {
            double volume = length * depth * height;
            return volume;
        }*/


        static string stringFunction(string myString, string functionChoice)
        {
            switch (myString)
            {
                case "ToUpper()":
                    myString = myString.ToUpper();
                    break;
                case "ToLower()":
                    myString = myString.ToLower();
                    break;
                case ".Length":
                    myString = Convert.ToString(myString.Length);
                    break;
                case ".Substring":
                    Console.WriteLine("Which position would you like to start at (index starts at zero)?: ");
                    int startPos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many characters would you like to take?: ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    myString = myString.Substring(startPos, length);
                    break;
                case "Left(str,int)":
                    Console.WriteLine("How many characters would you like to take from the left hand side of the string (index starts at 0)?: ");
                    int leftLength = Convert.ToInt32(Console.ReadLine());
                    myString = myString.Substring(0, leftLength);
                    break;
                case "Right(str,int)":
                    Console.WriteLine("How many characters would you like to take from the right hand side of the string (index starts at 0)?: ");
                    int rightLength = Convert.ToInt32(Console.ReadLine());
                    myString = myString.Substring(myString.Length - rightLength);
                    break;
                case "Mid()":
                    Console.WriteLine("Where would you like to start your string (index starts at 0)?: ");
                    int stringStart = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many characters would you like to extract from the string?: ");
                    int stringExtract = Convert.ToInt32(Console.ReadLine());
                    myString = myString.Substring(stringStart, stringExtract);
                    break;
                case "IndexOf()":
                    Console.WriteLine("Which index would you like to take (index starts at 0)?: ");
                    int indexTaken = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(myString[indexTaken]);
                    break;
            }
            return myString;
        }
    }
}