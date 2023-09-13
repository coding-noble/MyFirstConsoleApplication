internal class Program
{
    private static void Main(string[] args)
    {
        // Step 2: Create two variables to store your name and location
        string firstName, lastName, fullName, city, state, location;
        firstName = "Miles";
        lastName = "Noble";
        city = "Cora";
        state = "Wyoming";

        fullName = $"{firstName} {lastName}";
        location = $"{city} {state}";

        // Step 3: Output two WriteLine statements that display those two variables with proper labels using String Interpolation.
        Console.WriteLine($"My name is {fullName}");
        Console.WriteLine($"I am from {location}");

        // Step 4: Output the current date, but not the current time. (Ex: 04/06/1830)
        DateTime dateTime = DateTime.Now;

        Console.WriteLine(dateTime.Date.ToShortDateString());
        Console.WriteLine(dateTime.Date.ToLongDateString());

        // Step 5: Output the number of days until Christmas this year.
        DateTime christmusDate = new DateTime(dateTime.Year, 12, 25);

        Console.WriteLine($"There are {(int)(christmusDate - dateTime).TotalDays} days until Christmus!!");

        // Step 6: Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
        // Step 7: Add text labels to the code and make the code wait for the user to press a key.
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.Write("What is the width of the window: ");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.Write("What is the height of the window: ");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet");
        Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        Console.ReadKey();
    }
}