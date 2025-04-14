internal class Program
{

  private static void Main()
  {
    Console.WriteLine("Rock, Paper, Scissors. Choose or Die!");

    string userHand = ChooseHand();

  }

  static string ChooseHand()
  {

Console.Clear();

    Console.WriteLine("Choose A Hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");

    string? userInput = Console.ReadLine();

    if (userInput == "1")
    { Console.WriteLine("Player Chooses Rock"); }

return userInput;

  }

}