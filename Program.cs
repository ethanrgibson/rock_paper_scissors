internal class Program
{

  private static void Main()
  {
    Console.WriteLine("Rock, Paper, Scissors. Choose or Die!");

    string userHand = ChooseHand();


    string computerHand = GetComputerHand();

    Console.WriteLine($"You chose {userHand}");
    Console.WriteLine($"Computer Chose {computerHand}");

    if (userHand == computerHand){
      Console.WriteLine("It's A Tie!");
    }

  }

  static string ChooseHand()
  {



    Console.WriteLine("Choose A Hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");

    string? userInput = Console.ReadLine();


    if (userInput == "1")
    { return "Rock"; }
    if (userInput == "2")
    { return "Paper"; }
    if (userInput == "3")
    { return "Scissors"; }

    if (userInput != "1" && userInput != "2" && userInput != "3")
    {
      Console.WriteLine("Please Select a number");
      return ChooseHand();
    }

    return userInput;
  }

  static string GetComputerHand()
  {
    int randomNumber = new Random().Next(1, 4);

    if (randomNumber == 1)
    { return "Rock"; }
    if (randomNumber == 2)
    { return "Paper"; }
    if (randomNumber == 3)
    { return "Scissors"; }

    return "";

  }
}