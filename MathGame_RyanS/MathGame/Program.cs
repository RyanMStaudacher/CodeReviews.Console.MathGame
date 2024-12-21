bool gameShouldRun = true;
List<string> gameHistory = new List<string>();

do
{
    MathGameFunction();
}while(gameShouldRun);


void MathGameFunction()
{
    Console.WriteLine("Hello! Welcome to Ryan's Miraculous Math Game!!\nPlease choose an operation to perform:\n\n:Addition:\n:Subtraction:\n:Multiplication:\n:Division:\n:Random Game:\n:Past Games:\n:Quit Game:\n");
    var operationChoice = Console.ReadLine();

    switch (operationChoice)
    {
        case ":Addition:":
        AdditionFunction();
        break;
        case ":Subtraction:":
        SubtractionFunction();
        break;
        case ":Multiplication:":
        MultiplicationFunction();
        break;
        case ":Division:":
        DivisionFunction();
        break;
        case ":Random Game:":
        RandomGameFunction();
        break;
        case ":Past Games:":
        PastGamesFunction();
        break;
        case ":Quit Game:":
        QuitGame();
        break;
    }
}

void AdditionFunction()
{
    Console.WriteLine("Solve the following problem: \n");

    Random rnd = new Random();
    int num1 = rnd.Next(1, 100);
    int num2 = rnd.Next(1, 100);
    int sum = num1 + num2;

    string question = num1 + " + " + num2 + " = ?";
    Console.WriteLine(question + "\n");

    var guessString = Console.ReadLine();
    int guess = Convert.ToInt32(guessString);
    Console.WriteLine();
    string rightOrWrong = "";

    if(guess == sum)
    {
        Console.WriteLine("That is correct!\n");
        rightOrWrong = "CORRECT";
    }
    else if(guess != sum)
    {
        Console.WriteLine("That is incorrect.\n");
        rightOrWrong = "INCORRECT";
    }

    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
    Console.Clear();

    string addToHistory = question + " --- Answer: " + guess + " - " + rightOrWrong;
    gameHistory.Add(addToHistory);
}

void SubtractionFunction()
{
    Console.WriteLine("Solve the following problem: \n");

    Random rnd = new Random();
    int num1 = rnd.Next(1, 100);
    int num2 = rnd.Next(1, 100);
    int difference = num1 - num2;

    string question = num1 + " - " + num2 + " = ?";
    Console.WriteLine(question + "\n");

    var guessString = Console.ReadLine();
    int guess = Convert.ToInt32(guessString);
    Console.WriteLine();
    string rightOrWrong = "";

    if (guess == difference)
    {
        Console.WriteLine("That is correct!\n");
        rightOrWrong = "CORRECT";
    }
    else if (guess != difference)
    {
        Console.WriteLine("That is incorrect.\n");
        rightOrWrong = "INCORRECT";
    }

    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
    Console.Clear();

    string addToHistory = question + " --- Answer: " + guess + " - " + rightOrWrong;
    gameHistory.Add(addToHistory);
}

void MultiplicationFunction()
{
    Console.WriteLine("Solve the following problem: \n");

    Random rnd = new Random();
    int num1 = rnd.Next(1, 100);
    int num2 = rnd.Next(1, 100);
    int product = num1 * num2;

    string question = num1 + " * " + num2 + " = ?";
    Console.WriteLine(question + "\n");

    var guessString = Console.ReadLine();
    int guess = Convert.ToInt32(guessString);
    Console.WriteLine();
    string rightOrWrong = "";

    if (guess == product)
    {
        Console.WriteLine("That is correct!\n");
        rightOrWrong = "CORRECT";
    }
    else if (guess != product)
    {
        Console.WriteLine("That is incorrect.\n");
        rightOrWrong = "INCORRECT";
    }

    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
    Console.Clear();

    string addToHistory = question + " --- Answer: " + guess + " - " + rightOrWrong;
    gameHistory.Add(addToHistory);
}

void DivisionFunction()
{
    int num1 = 0;
    int num2 = 0;
    int moduloResult = 1;
    int quotient = 0;

    do
    {
        Random rnd = new Random();
        num1 = rnd.Next(1, 100);
        num2 = rnd.Next(1, 100);
        moduloResult = num1 % num2;
    } while(moduloResult != 0);

    quotient = num1 / num2;

    string question = num1 + " / " + num2 + " = ?";
    Console.WriteLine(question + "\n");

    var guessString = Console.ReadLine();
    int guess = Convert.ToInt32(guessString);
    Console.WriteLine();
    string rightOrWrong = "";

    if (guess == quotient)
    {
        Console.WriteLine("That is correct!\n");
        rightOrWrong = "CORRECT";
    }
    else if (guess != quotient)
    {
        Console.WriteLine("That is incorrect.\n");
        rightOrWrong = "INCORRECT";
    }

    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();
    Console.Clear();

    string addToHistory = question + " --- Answer: " + guess + " - " + rightOrWrong;
    gameHistory.Add(addToHistory);
}

void RandomGameFunction()
{
    Random rnd = new Random();
    int choice = rnd.Next(1, 4);

    switch(choice)
    {
        case 1:
            AdditionFunction();
            break;
        case 2:
            SubtractionFunction();
            break;
        case 3:
            MultiplicationFunction();
            break;
        case 4:
            DivisionFunction();
            break;
        case 0:
            Console.WriteLine(choice);
            break;
        case 5:
            Console.WriteLine(choice);
            break;
    }
}

void PastGamesFunction()
{
    foreach(string a in gameHistory)
    {
        Console.WriteLine(a);
    }
    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();
    Console.Clear();
}

void QuitGame()
{
    gameShouldRun = false;
}