int points = 0;
int questionNum = 0;
string answer1;


string[][] questions = {
    new string[] {"\nFråga 1.\nWhat is David's's name \na) mario \nb) David \nc) wigo \nd) pytor dragetovich idi nahui", "b"},
    new string[] {"\nFråga 2.\n2+2? \na) 1 \nb) 2 \nc) 8 \nd) 4", "d"},
    new string[] {"\nFråga 3.\nWho is Ropenis? \na) A random guy  \nb) Him \nc) Yes \nd) That Guy", "b"},
    new string[] {"\nFråga 4.\nwhat color do you like? \na) blue \nb) red \nc) black", "e"}
};
Console.WriteLine("Welcome to the quiz, what is your name?");
string name = Console.ReadLine();

Console.WriteLine($"Welcome {name} to the quiz! Answer questinons by writing a, b, c or d");
Console.ReadLine();

void askQuestion(string question, string correct){
    answer1 = null;

    do {
    Console.WriteLine(question);
    answer1 = Console.ReadLine().Trim();
    } while (answer1 != "a" && answer1 != "b" && answer1 != "c" && answer1 != "d" && answer1 != "e");

    if (answer1 == correct){
        Console.WriteLine("wow you are smart:)))()");
        points += 1;
    }
    else{
        Console.WriteLine("Wrong, you are bad");
    }

    questionNum += 1;

    if (questionNum >= questions.Count()){
        Console.WriteLine($"\nlets see if you won or not... \n\n{points}");

        if (points == 0){
            Console.WriteLine("0 points? You are very bad");
        }
        else if (points == questions.Count()){
            Console.WriteLine("Full points?? you are ok");
        }
        else if (points <= questions.Count() / 2 && points >= 1){
            Console.WriteLine($"less than half? Bad");
        }
        else if (points >= questions.Count() / 2 && points <= questions.Count()){
            Console.WriteLine("More than half? I have seen worse");
        }

    }
    else {
        askQuestion(questions[questionNum][0], questions[questionNum][1]);
    }
}

askQuestion(questions[questionNum][0], questions[questionNum][1]);


Console.ReadLine();