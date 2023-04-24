using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        // Llamo a la funcion de bienvenida

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        // Creo dos variables y les asigno el valor retornado por estas funciones

        int squaredNumber = SquareNumber(userNumber);
        // Creo la variable squareNumber y le asigno el resultado de la funcion SquareNumber
        // Al mismo tiempo, le estoy pasando como parametro el numero que el usuario ingreso
        // en la funcion anterior.

        DisplayResult(userName, squaredNumber);
        // Llamo a esta ultima funcion con los parametros que necesita para devolver el nombre
        // del usuario y el numero que ingresó pero al cuadrado.
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}