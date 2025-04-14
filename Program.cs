using System.Text.Json;

internal class Program
{
  static int PlayerWins = 0;
  static int ComputerWins = 0;

  private static void Main()
  {
    LoadGame();
    Console.WriteLine("Rock, Paper, Scissors. Choose or Die!");

    Console.WriteLine($"Current Score: You: {PlayerWins} || Computer: {ComputerWins}");

    string userHand = ChooseHand();
    string computerHand = GetComputerHand();



    Console.WriteLine($"You chose {userHand}");
    Console.WriteLine($"Computer Chose {computerHand}");

    if (userHand == computerHand)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("It's A Tie!");
      Console.ResetColor();
      SaveGame();
    }

    else if (userHand == "Rock" && computerHand == "Scissors" || userHand == "Paper" && computerHand == "Rock" || userHand == "Scissors" && computerHand == "Paper")
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("You Win!");
      Console.ResetColor();
      Console.WriteLine($"Your Score: {PlayerWins += 1}");
      SaveGame();
    }

    else
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("You Loose!");
      Console.ResetColor();
      Console.WriteLine($"Computer Score: {ComputerWins += 1}");
      SaveGame();
    }

    bool wantsToPlayAgain = GetUsersChoice();

    if (wantsToPlayAgain)
    {
      Main();
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

  public static bool GetUsersChoice()
  {

    Console.WriteLine("Want to play again?");
    Console.WriteLine("y/n");
    char userInput = Console.ReadKey().KeyChar;

    if (userInput != 'y' && userInput != 'n')
    {
      return GetUsersChoice();
    }
    Console.Clear();
    return userInput == 'y';
  }

  static void SaveGame()
  {
    SaveData save = new(PlayerWins, ComputerWins);
    string saveData = JsonSerializer.Serialize(save);
    File.WriteAllText("saveGame.json", saveData);
  }

  static void LoadGame()
  {
    if (!File.Exists("saveGame.json")) return;
    string jsonString = File.ReadAllText("saveGame.json");
    SaveData? data = JsonSerializer.Deserialize<SaveData>(jsonString);

    if (data != null)
    {
      PlayerWins = data.PlayerWins;
      ComputerWins = data.ComputerWins;
    }

  }

}


internal class SaveData
{

  public int PlayerWins { get; set; }
  public int ComputerWins { get; set; }

  public SaveData(int playerWins, int computerWins)
  {
    PlayerWins = playerWins;
    ComputerWins = computerWins;
  }
}