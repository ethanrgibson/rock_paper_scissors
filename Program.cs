internal class Program
{

  private static void Main()
  {
    Console.WriteLine("Rock, Paper, Scissors. Choose or Die!");

    string userHand = ChooseHand();
    string computerHand = GetComputerHand();

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
    if (userInput == "2")
    { Console.WriteLine("Player Chooses Paper"); }
    if (userInput == "3")
    { Console.WriteLine("Player Chooses Scissors"); }

    if (userInput != "1" && userInput != "2" && userInput != "3")
    {
      Console.WriteLine("Please Select a number");
      return ChooseHand();
    }

    return "";
  }

  static string GetComputerHand()
  {
    int randomNumber = new Random().Next(1, 4);

    if (randomNumber == 1)
    { Console.WriteLine("Computer Chooses Rock"); }
    if (randomNumber == 2)
    { Console.WriteLine("Computer Chooses Paper"); }
    if (randomNumber == 3)
    { Console.WriteLine("Computer Chooses Scissors"); }


    return "";

  }
}