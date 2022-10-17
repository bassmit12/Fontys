// See https://aka.ms/new-console-template for more information


using System.Drawing;

class ChristmasTree
{   
    
    static void Main ()
    {
        int length;
        char character;
        int xCoordinate;
        int yCoordinate;

        Console.WriteLine("Please enter length of christmasTree: ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Enter character used for christmasTree: ");
        character = Convert.ToChar(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Enter X coordinate to be used: ");
        xCoordinate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Enter Y coordinate to be used: ");
        yCoordinate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        ConsoleColor();

        Tree(length, character, xCoordinate, yCoordinate);

        Console.ResetColor();
    }

    static void Tree(int length, char character, int x, int y)
    {
        Console.Clear();

        for (int i = 1; i < length + 1; i++)
        {
            Console.SetCursorPosition(x - (length - 1), y + (i - 1));
            string star = new(character, i - 1);
            string space = new(' ', length - i);
            Console.WriteLine(space + star + character + star + space);
        }

      
    }

    static void ConsoleColor()
    {
        Console.WriteLine("\nPlease enter desired text color for this screen: ");

        string textRaw = Console.ReadLine();


        if (textRaw.StartsWith("dark"))
        {
            string resDark = textRaw.Remove(0, 4);

            string firstCharacter = resDark.Substring(0, 1).ToUpper();
            string res = resDark.Remove(0, 1);

            string text = "Dark" + firstCharacter + res;
            Console.WriteLine(text);

            if (Enum.TryParse(text, out ConsoleColor foreground))
            {
                Console.ForegroundColor = foreground;
            }
        }

        else
        {
            string firstCharacter = textRaw.Substring(0, 1).ToUpper();
            string res = textRaw.Remove(0, 1);

            string text = firstCharacter + res;

            if (Enum.TryParse(text, out ConsoleColor foreground))
            {
                Console.ForegroundColor = foreground;
            }
        }

            

       
        
    }
}

