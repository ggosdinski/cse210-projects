public class GoalManager {
    private int _score = 0;
    private List<Goal> _goalList = new List<Goal>();
    public void Start()
    {
        Console.Clear();
        string userInput = "";
        while (userInput != "5") {
            DisplayGoals();
            DisplayScore();
            Console.WriteLine("Menu options:\n  1. Create new goal\n  2. Save goals\n  3. Load Goals\n  4. Record Event\n  5. Quit\nSelect a choice from the menu:");
            userInput = Console.ReadLine();
            if (userInput == "1") {
                CreateGoal();
            } else if (userInput == "2") {
                // call save
                Save();
                Console.Clear();
            } else if (userInput == "3") {
                // call load
                Load();
            } else if (userInput == "4") {
                // call complete
                RecordEvent();
            } else if (userInput == "5") {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                break;
            } else {
                Console.WriteLine("Please enter a valid menu option");
                Console.Clear();
            }
        }
    }
    public void DisplayScore() {
        Console.WriteLine($"Your score: {_score}");
    }
    public void CreateGoal() 
    {
        Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? "); 
        string goalType = Console.ReadLine();
        if (goalType == "1") {
            // name of the goal
            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();
            // description of the goal
            Console.WriteLine("What is a short description of your goal? ");
            string description = Console.ReadLine();
            // points string to int
            Console.WriteLine("What is the amount of points associated with each completion of this goal? ");
            string userInputPoints = Console.ReadLine();
            int points = int.Parse(userInputPoints);
            // new simple goal
            Goal goal = new SimpleGoal(name, description, points, false);
            // add the new goal to  the list
            _goalList.Add(goal);
            Console.Clear();
        } 
        else if (goalType == "2") {
            // name of the goal
            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();
            // description of the goal
            Console.WriteLine("What is a short description of your goal? ");
            string description = Console.ReadLine();
            // points string to int
            Console.WriteLine("What is the amount of points associated with each completion of this goal? ");
            string userInputPoints = Console.ReadLine();
            int points = int.Parse(userInputPoints);
            // new eternal goal
            Goal goal = new EternalGoal(name, description, points);
            // add goal to list
            _goalList.Add(goal);
            Console.Clear();
        } 
        else if (goalType == "3") {
            
            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();
            
            Console.WriteLine("What is a short description of your goal? ");
            string description = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated with each completion of this goal? ");
            string userInputPoints = Console.ReadLine();
            int points = int.Parse(userInputPoints);

            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            string userInputTimesToComplete = Console.ReadLine();
            int timesToComplete = int.Parse(userInputTimesToComplete);

            Console.WriteLine("What is the amount of points associated with the bonus for finishing this goal? ");
            string userInputBonusPoints = Console.ReadLine();
            int bonusPoints = int.Parse(userInputBonusPoints);
            Goal goal = new ChecklistGoal(name, description, points, 0, timesToComplete, bonusPoints);

            _goalList.Add(goal);
            Console.Clear();
        } 
        else {
            Console.Clear();
            Console.WriteLine("Please enter a valid menu option");
        }
    }
    public void RecordEvent() {
        if (_goalList.Count() == 0) {
            Console.Clear();
            Console.WriteLine("Nothing to record!");
        } else {
            try {
                Console.WriteLine("Which goal would you like to mark complete?");
                string userGoalchoice = Console.ReadLine();
                int goalChoice = int.Parse(userGoalchoice);
                Goal goal = _goalList[goalChoice - 1];
                int pointsEarned = goal.RecordEvent();
                _score += pointsEarned;
                Console.Clear();
            } catch {
                Console.Clear();
                Console.WriteLine("Please select an item on the list");
            }
        }
    }
    public void DisplayGoals() {
        if (_goalList.Count() == 0) {
        } else {
            foreach (Goal goal in _goalList) {
                Console.WriteLine(goal.GetDisplayString());
            }
        }
    }
    public void Save() 
    {
        Console.WriteLine("What is the name of the file you would like to save to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            // store score
            outputFile.WriteLine(_score);
            // store goal entries
            foreach (Goal goal in _goalList) {
                outputFile.WriteLine(goal.GetSaveData());
            }
        }
    }
    public void Load() 
    {
        Console.WriteLine("What is the name of the file you would like to load? ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName)) 
        {
            Console.Clear();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            // separates for each goal type and makes a new goal based on the goal
            foreach (string line in lines) {
                string[] parts = line.Split("|");
                if (parts[0] == "SimpleGoal") {
                    bool complete = bool.Parse(parts[4].ToLower());
                    _goalList.Add(new SimpleGoal(parts[1], parts[2], ToInt(parts[3]), complete));
                } else if (parts[0] == "EternalGoal") {
                    _goalList.Add(new EternalGoal(parts[1], parts[2], ToInt(parts[3])));
                } else if (parts[0] == "ChecklistGoal") {
                    _goalList.Add(new ChecklistGoal(parts[1], parts[2], ToInt(parts[3]), ToInt(parts[4]), ToInt(parts[5]), ToInt(parts[6])));
                } else {
                    _score = ToInt(parts[0]);
                }
            }
        } else {
            Console.Clear();
            Console.WriteLine("Sorry, that file does not exist!");
        }
        
    }
    public int GetScore() {
        return _score;
    }
    public int ToInt(string strint) {
        return int.Parse(strint);
    }
}