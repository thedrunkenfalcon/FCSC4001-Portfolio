/*All the variables program
//Integers:
byte _ByteMin = 0;
byte _ByteMax = 255;
short _ShortMin = -32768;
short _ShortMax = 32767;
int _IntegerMin = -2147483648;
int _IntegerMax = 2147483647;
long _LongMin = -9223372036854775808;
long _LongMax = 9223372036854775807;
sbyte _SByteMin = -128;
sbyte _SByteMax = 127;
ushort _UShortMin = 0;
ushort _UShortMax = 65535;
uint _UIntegerMin = 0;
uint _UIntegerMax = 4294967293;
ulong _ULongMin = 0;
ulong _ULongMax = 18446744073709551615;

//Text:
char _Char = 'F';
string _String = "This is a String";

//Floating point, or decimal point:
float _Float = 7f;
double _Double = 15.5;
decimal _Decimal = 28.5m;

//Booly boi:
bool _isbool = true;

//Division between program and declarations

//integers:
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"A bytes minimum value is {_ByteMin} and it's maximum is {_ByteMax}");
Console.WriteLine($"A shorts minimum value is {_ShortMin} and it's maximum is {_ShortMax}");
Console.WriteLine($"An integers minimum value is {_IntegerMin} and it's maximum is {_IntegerMax}");
Console.WriteLine($"A longs minimum value is {_LongMin} and it's maximum is {_LongMax}");
Console.WriteLine($"An sbytes minimum value is {_SByteMin} and it's maximum is {_SByteMax}");
Console.WriteLine($"A Ushorts minimum value is {_UShortMin} and it's maximum is {_UShortMax}");
Console.WriteLine($"A Uintegers minimum value is {_UIntegerMin} and it's maximum is {_UIntegerMax}");
Console.WriteLine($"A Ulongs minimum value is {_ULongMin} and it's maximum is {_ULongMax}");

//Text
Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine("The next Line is an example of \'char\' or character variable:");
Console.WriteLine(_Char);
Console.WriteLine("The next line is an example of a string:");
Console.WriteLine(_String);

//Floating Points
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine($"A float is roughly accurate to {_Float} decimal places");
Console.WriteLine($"A double is roughly accurate to {_Double} decimal places");
Console.WriteLine($"A decimal is roughly accurate to {_Decimal} decimal places");

//The lonely bool
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("The next line is an example of a \'bool\' or boolean variable");
Console.WriteLine(_isbool);
*/

/*
//The Triangle Farmer
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("Please enter the base size of the triangle:");
int _base = int.Parse(Console.ReadLine());
Console.WriteLine("Thank you, now please enter the height:");
int _height = int.Parse(Console.ReadLine());
Console.WriteLine($"The area of the triangle is: {(_base * _height) / 2} squared");
*/

/*
//Four sisters and the the Duckbear
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Please enter how many eggs were collected today:");
int eggs = int.Parse(Console.ReadLine());
Console.WriteLine($"Each sister found {eggs / 4} each! The ducker bear is left with {eggs % 4}");
*/

/*
//The Dominion of Kings
Console.BackgroundColor = ConsoleColor.DarkYellow;
int estates;
int duchies;
int provinces;
Console.WriteLine("Enter the amount of esates in your name:");
estates = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the amount of duchies in your name:");
duchies = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the amount of provinces in your name:");
provinces = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine($"With: {estates} estates, {duchies} duchies and {provinces} provinces.\n The total point value is {estates + (duchies * 3) + (provinces * 6)}");
*/

/*
//Testing the read key method
Console.Write("Press any key to continue\n");
Console.ReadKey(true);
Console.Write("You continued!");
*/

/*
//Testing a some cosmetic things aswell as the beep
Console.WriteLine("Press any key to beep");
Console.ReadKey(true);
Console.Beep();
Console.WriteLine("Press any key to beep and change the foreground colour to magenta");
Console.ReadKey(true);
Console.Beep();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Press any key to beep and change the background colour to white");
Console.ReadKey(true);
Console.Beep();
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Press any key to change the title of the console... and beep");
Console.ReadKey(true);
Console.Beep();
Console.Title = "I changed the title!";
Console.WriteLine(@"This is a test of the verbatim string modifier which allows \ / '' @ ; : , but not double quotations.");
Console.WriteLine("That's all for now, press any key to clear the console, beep and end the program");
Console.ReadKey(true);
Console.Beep();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
*/

/*
//Formating and layout stuff~
Console.WriteLine("Please enter a name:");
string name1 = Console.ReadLine();
Console.WriteLine("Please enter a pet name");
string name2 = Console.ReadLine();
Console.WriteLine($"Name: {name1, 20}");
Console.WriteLine($"Pet Name: {name2, 17}");
*/

//--------------------------------------------------------------------------------------------------------
/*
//Changing it into Percantages, in an almost game
float _MaxHealth = 20f;
float _CurrentHealth = 20f;
float _BanditMaxHealth = 20f;
float _BanditCurrentHealth = 20f; 
bool _FirstTurn = true;
string _Input = "";

void Menu()
{
    Console.WriteLine($"You are currently at {_CurrentHealth/_MaxHealth:0.0%} Health");
    Console.WriteLine($"The Bandit is currently at {_BanditCurrentHealth/_BanditMaxHealth:0.0%} Health");
    if(_BanditCurrentHealth <= 0 && _CurrentHealth <= 0)
    {
        Console.WriteLine("Well... That wasn't the expected outcome. Now you both dead");
    }
    else if(_CurrentHealth <= 0)
    {
        Console.WriteLine("Oh no! You died~ That was silly...");
    }
    else if(_BanditCurrentHealth <= 0)
    {
        Console.WriteLine("Congratulations! You Beat the Bandit!");
    }
    else
    {
        if (_FirstTurn)
        {
            Console.WriteLine("You stand face to face with a bandit, do you \"Attack\" \"Defend\" or \"Run\"");
            _Input = Console.ReadLine();
            Options();
            _FirstTurn = false;
        }
        else
        {
            Console.WriteLine("Do you \"Attack\" \"Defend\" or \"Run\"");
            _Input = Console.ReadLine();
            Options();
        }
    }
    

}

void Options()
{
    
    switch (CapitalizeFirstLetter(_Input))
    {
        case "Attack":
            Console.WriteLine("You Hit the bandit!");
            _BanditCurrentHealth -= 4;
            Console.ReadKey(true);
            Console.WriteLine("The bandit strikes back!");
            _CurrentHealth -= 3;
            break;
        case "Defend":
            Console.WriteLine("The Bandit strikes! You defend, blocking most of the damage.");
            _CurrentHealth -= 1;
            break;
        case "Run":
            Console.WriteLine("You attempt to run away...");
            Console.ReadKey(true);
            Console.WriteLine("The bandit seizes the oppotunity and strikes at your back!");
            _CurrentHealth -= 6;
            break;
        default:
            Console.WriteLine("I'm afraid I didn't understand what you wrote.");
            //Options();
            break;

    
    }
    Menu();
}
static string CapitalizeFirstLetter(string input)
{
    if (string.IsNullOrEmpty(input))
        return input;

    return char.ToUpper(input[0]) + input.Substring(1);
}
Menu();
*/
//------------------------------------------------------------------------------------------------------------

/*
//Repairing the Clock tower
int _Input;

Console.WriteLine("Please enter a number:");
_Input = int.Parse(Console.ReadLine());
if ((_Input % 2) == 0)
{
    Console.Write("Tick");
}
else
{
    Console.Write("Tock");
}
*/

/*
//While Loop
int counter = 0;
while(counter < 7)
{
    Console.WriteLine($"This is the {counter + 1} iteration");
    counter++;
}
*/

/*
//For Loop
for (int i = 0; i < 5; i++)
{
    Console.Write($"{i + 1} and a ");
}
*/

/*
//Do while loop
int counter = 1;
int max = 10;
do
{
    Console.WriteLine($"This is number {counter} of {max}");
    counter++;
}
while(counter < max);
*/

/*
//The Prototype
int _PilotInput;
int _HunterGuess;

Console.WriteLine("Pilot, Please enter a number between zero and a hundred");
_PilotInput = int.Parse(Console.ReadLine());

while (_PilotInput > 100 || _PilotInput < 1)
{
    Console.WriteLine("Pilot, Please enter a number between zero and a hundred");
    _PilotInput = int.Parse(Console.ReadLine());
}
Console.Clear();
Console.WriteLine("Hunter, Please enter your guess");
_HunterGuess = int.Parse(Console.ReadLine());
while (_HunterGuess != _PilotInput)
{
    if (_HunterGuess > _PilotInput)
    {
        Console.WriteLine("Lower");
        _HunterGuess = int.Parse(Console.ReadLine());
    }
    else if (_HunterGuess < _PilotInput)
    {
        Console.WriteLine("Higher");
        _HunterGuess = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Well Done! You guessed correctly!");
*/

/*
//Replicator of D'to
int[] _Numbers = new int[5];
int[] _MoreNumber = new int[5];
for (int _index = 0; _index < _Numbers.Length; _index++)
{
    Console.WriteLine($"This is {_index}");
    Console.WriteLine("Please enter a number:");
    //I can't be bothered to put in an if statement to check for errors or blank space xp
    _Numbers[_index] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Press any key to copy the array and print it");
Console.ReadKey(true);

for (int _index = 0; _index < _Numbers.Length; _index++)
{
    _MoreNumber[_index] = _Numbers[_index];
    Console.WriteLine($"{_Numbers[_index]} and {_MoreNumber[_index]}");
}
*/

/*
//Taking a number
string _Question1 = "How many are their in the solar system?";
string _Question2 = "How likely am I to kill myself?";

int AskForANumber(string text)
{
    Console.WriteLine(text);
    string _ReturnedNumberAsString = Console.ReadLine();
    if (_ReturnedNumberAsString.IsWhiteSpace())
    {
        AskForANumber(text);
    }
    int _ReturnNumber = int.Parse(_ReturnedNumberAsString);
    return _ReturnNumber;
}

int AskForANumberWithinRange(string text, int min, int max)
{
    Console.WriteLine(text);
    string _Answer = Console.ReadLine();
    if (_Answer.IsWhiteSpace())
    {
        AskForANumberWithinRange(text, min, max);
    }
    int _AnswerNum = int.Parse(_Answer);
    if (_AnswerNum < min)
    {
        Console.WriteLine("Too low");
        AskForANumberWithinRange(text, min, max);
    }
    else if (_AnswerNum > max)
    {
        Console.WriteLine("Too high");
        AskForANumberWithinRange(text, min, max);
    }
    return _AnswerNum;
}

AskForANumber(_Question1);
AskForANumberWithinRange(_Question2, 60, 90);
*/

/*
//Countdown
void Countdown(int num)
{
    Console.WriteLine(num);
    if (num < 1)
    {
        return;
    }
    else
    {
        num--;
        Countdown(num);
    }
}
Countdown(10);
*/

/*
//Hunting the Manticore
int _Round = 1;
int _ManticoreHealth = 10;
int _CityHealth = 15;
int _ManticoreDist;

SetManticoreDist();
OverallGameLoop();
Outcome();

void SetManticoreDist()
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("Player 1: Please select the starting distance between 1 - 100 from the city for the Manticore:");
    _ManticoreDist = int.Parse(Console.ReadLine());
    if (_ManticoreDist > 100 || _ManticoreDist < 1)
    {
        SetManticoreDist();
    }
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
}

void OverallGameLoop()
{
    int _Aim;
    Console.WriteLine("Player 2, it is now your turn.");
    do
    {
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine($"Status: Round {_Round}  City: {_CityHealth}/15  Manticore: {_ManticoreHealth}/10");
        Console.WriteLine($"The Cannon is expected to do {CannonDamage(_Round)} damage this turn.");
        Console.Write("Entered desired cannon range: ");
        _Aim = int.Parse(Console.ReadLine());
        AccuracyCheck(_ManticoreDist, _Aim);
        Console.WriteLine("-----------------------------------------------------------------------------------");
        if (_ManticoreHealth > 0)
        {
            _CityHealth--;
        }
        _Round++;
    }
    while (_ManticoreHealth > 0 && _CityHealth > 0);
}

int CannonDamage(int round)
{
    int _CannonDamage;
    if ((round % 3) == 0 && (round % 5) == 0)
    {
        _CannonDamage = 10;
    }
    else if ((round % 3) == 0 || (round % 5) == 0)
    {
        _CannonDamage = 3;
    }
    else
    {
        _CannonDamage = 1;
    }
    return _CannonDamage;
}

void AccuracyCheck(int target, int aim)
{
    if (target > aim)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("That round FELL SHORT of the target!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (target < aim)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("That round OVERSHOT the target!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ForegroundColor = ConsoleColor.White;
        _ManticoreHealth -= CannonDamage(_Round);
    }
}

void Outcome()
{
    if (_ManticoreHealth < 1 && _CityHealth > 0)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("The Manticore had been destroyed! The city of Consolas is saved!");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (_ManticoreHealth > 0 && _CityHealth < 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("The city of Consolas has fallen. You have failed.");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
}
*/

/*
//Simula's Test
_ChestState chestState = _ChestState.Locked;
string _input = "";

void Chesting()
{
    Console.WriteLine("You have a chest in front of you");
    Console.WriteLine("Enter: Open, Close, Lock or Unlock to manipulate the chest.");
    Console.WriteLine("Entering an invalid option will end the program to prevent an infinite loop.");

    _input = Console.ReadLine();
    switch (_input)
    {
        case "Unlock":
            if (chestState == _ChestState.Locked)
            {
                Console.WriteLine("You Unlocked the Chest");
                chestState = _ChestState.Unlocked;
            }
            else
            {
                Console.WriteLine("The chest is already unlocked!");
            }
            Chesting();
        break;

        case "Lock":
            if (chestState == _ChestState.Unlocked)
            {
                Console.WriteLine("You lock the chest.");
                chestState = _ChestState.Locked;
            }
            else if (chestState == _ChestState.Locked)
            {
                Console.WriteLine("The chest is already locked!");
            }
            else
            {
                Console.WriteLine("The Chest is open, you need to close it to lock it.");
            }
            Chesting();
        break;

        case "Open":
            if (chestState == _ChestState.Unlocked)
            {
                Console.WriteLine("You open the chest");
                chestState = _ChestState.Open;
            }
            else if (chestState == _ChestState.Locked)
            {
                Console.WriteLine("The chest is locked, you have to unlock it to open it.");
            }
            else
            {
                Console.WriteLine("The chest is already open!");
            }
            Chesting();
        break;

        case "Close":
            if (chestState == _ChestState.Open)
            {
                Console.WriteLine("You close the chest.");
                chestState = _ChestState.Unlocked;
            }
            else
            {
                Console.WriteLine("The chest is already closed");
            }
            Chesting();
        break;

        default:
            Console.WriteLine("Invalid input, ending program.");
        break;
    }
}


Chesting();

enum _ChestState
{
    Unlocked,
    Locked,
    Open
}
*/

/*
//Simula's Soup
string _input = "";
(_FoodType foodType, _MainIngredient mainIngredient, _Seasonings seasonings) _Menu;

AskForFoodType();

void AskForFoodType()
{
    Console.WriteLine("What type of food do you want out of: Soup, Stew or Gumbo?");
    _input = Console.ReadLine();
    switch (_input)
    {
        case "Soup":
            _Menu.foodType = _FoodType.Soup;
        break;
        case "Stew":
            _Menu.foodType = _FoodType.Stew;
        break;
        case "Gumbo":
            _Menu.foodType = _FoodType.Gumbo;
        break;
        default:
            Console.WriteLine("Sorry I didn't understand that.");
            AskForFoodType();
        break;
    }
    AskForMainIngredient();
}

void AskForMainIngredient()
{
    Console.WriteLine("What main ingredient would you prefer from: Mushrooms, Chicken, Carrots or Potatoes?");
    _input = Console.ReadLine();
    switch (_input)
    {
        case "Mushrooms":
            _Menu.mainIngredient = _MainIngredient.Mushrooms;
        break;
        case "Chicken":
            _Menu.mainIngredient = _MainIngredient.Chicken;
        break;
        case "Carrots":
            _Menu.mainIngredient = _MainIngredient.Carrots;
        break;
        case "Potatoes":
            _Menu.mainIngredient = _MainIngredient.Potatoes;
        break;
        default:
            Console.WriteLine("I'm afraid I didn't understand that.");
            AskForMainIngredient();
        break;
    }
    AskForSeasoning();
}

void AskForSeasoning()
{
    Console.WriteLine("How would you like it seasoned? Spicy, Salty or Sweet?");
    _input = Console.ReadLine();
    switch (_input)
    {
        case "Spicy":
            _Menu.seasonings = _Seasonings.Spicy;
        break;
        case "Salty":
            _Menu.seasonings = _Seasonings.Salty;
        break;
        case "Sweet":
            _Menu.seasonings = _Seasonings.Sweet;
        break;
        default:
            Console.WriteLine("I didn't quite get that.");
            AskForSeasoning();
        break;
        
    }
    DisplayChoice();
}

void DisplayChoice()
{
    Console.WriteLine($"You have chosen a {_Menu.seasonings} {_Menu.mainIngredient} {_Menu.foodType}");
}





enum _FoodType
{
    Soup,
    Stew,
    Gumbo
}

enum _MainIngredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum _Seasonings
{
    Spicy,
    Salty,
    Sweet
}
*/

/*
//Vin Fletcher's Arrows
void Vin()
{
    Fletching _Fletching = new Fletching();
    string _Input;
    Console.WriteLine("Please choose the material for the arrow head:");
    Console.WriteLine("Obsidian, Steel or Wood");
    _Input = Console.ReadLine();
    switch (_Input)
    {
        case "Obisian":
            _Fletching.SetArrowHeadMat(Fletching._ArrowHeadMaterial.Obsidian);
        break;
        case "Steel":
            _Fletching.SetArrowHeadMat(Fletching._ArrowHeadMaterial.Steel);
        break;
        case "Wood":
            _Fletching.SetArrowHeadMat(Fletching._ArrowHeadMaterial.Wood);
        break;
    }
    Console.Clear();
    Console.WriteLine("Please select the fletching you require:");
    Console.WriteLine("Plastic, Turkey Feathers, Goose Feathers");
    _Input = Console.ReadLine();
    switch (_Input)
    {
        case "Plastic":
            _Fletching.SetFletching(Fletching._FletchingMaterial.Plastic);
        break;
        case "Turkey Feathers":
            _Fletching.SetFletching(Fletching._FletchingMaterial.TurkeyFeathers);
        break;
        case "Goose Feathers":
            _Fletching.SetFletching(Fletching._FletchingMaterial.GooseFeathers);
        break;
    }
    Console.Clear();
    Console.WriteLine("Please enter the length of arrow you would prefer in centimeters.");
    Console.WriteLine("Between 60 to 100 centimeters are allowed.");
    _Input = Console.ReadLine();

    if (Convert.ToSingle(_Input) > 100f)
    {
        Console.WriteLine("Too large, setting the length to the maximum of 100");
        _Fletching.SettArrowLength(100f);
    }
    else if (Convert.ToSingle(_Input) < 60f)
    {
        Console.WriteLine("Too small, setting the size to the smallest size of 60");
        _Fletching.SettArrowLength(60f);
    }
    else
    {
        _Fletching.SettArrowLength(Convert.ToSingle(_Input));
    }

    Console.Clear();
    Console.WriteLine($"With an {_Fletching.GetArrowHead()} head, {_Fletching.GetFletchingMaterial()}");
    Console.WriteLine($"and a length of {_Fletching.GetLength()}cm.");
    Console.WriteLine($"The cost of the arrows will be {_Fletching.GetCost()} gold.");

}

Vin();



class Fletching
{
    private _ArrowHeadMaterial _ArrowHead;
    private _FletchingMaterial _Fletching;
    private float _ArrowLength;

    public Fletching(_ArrowHeadMaterial _ArrowMat, _FletchingMaterial _FletchingMat, float _Length)
    {
        _ArrowHead = _ArrowMat;
        _Fletching = _FletchingMat;
        _ArrowLength = _Length;
    }

    public Fletching()
    {
        _ArrowHead = _ArrowHeadMaterial.Wood;
        _Fletching = _FletchingMaterial.GooseFeathers;
        _ArrowLength = 60f;
    }

    public float GetCost()
    {
        float _HeadCost;
        float _FletchingCost;
        float _LengthCost;

        switch (_ArrowHead)
        {
            case _ArrowHeadMaterial.Steel:
                _HeadCost = 10f;
            break;
            case _ArrowHeadMaterial.Wood:
                _HeadCost = 3f;
            break;
            case _ArrowHeadMaterial.Obsidian:
                _HeadCost = 5f;
            break;
            default:
                Console.WriteLine("Invalid Arrow head material, defaulting to zero");
                _HeadCost = 0f;
            break;
        }

        switch (_Fletching)
        {
            case _FletchingMaterial.Plastic:
                _FletchingCost = 10f;
            break;
            case _FletchingMaterial.TurkeyFeathers:
                _FletchingCost = 5f;
            break;
            case _FletchingMaterial.GooseFeathers:
                _FletchingCost = 3f;
            break;
            default:
                Console.WriteLine("Invalid Fletching Selection, defaulting to zero");
                _FletchingCost = 0f;
            break;
        }

        _LengthCost = _ArrowLength * 0.05f;
        return _HeadCost + _FletchingCost + _LengthCost;
    }

    public _ArrowHeadMaterial GetArrowHead() => _ArrowHead;

    public _FletchingMaterial GetFletchingMaterial() => _Fletching;

    public float GetLength() => _ArrowLength;

    public void SetArrowHeadMat(_ArrowHeadMaterial input) => _ArrowHead = input;

    public void SetFletching(_FletchingMaterial input) => _Fletching = input;

    public void SettArrowLength(float input) => _ArrowLength = input;


    public enum _ArrowHeadMaterial
    {
        Steel,
        Wood,
        Obsidian
    }

    public enum _FletchingMaterial
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }
}
*/


/*
//Testing class accessibility
Area _rectangle = new Area();
Console.WriteLine($"Current area is {_rectangle.GetArea()}");
Console.WriteLine($"This is due to the length being {_rectangle.GetLength()} and the width being {_rectangle.GetWidth()}");
Console.ReadKey(true);
Console.Write("Please now enter a new length: ");
_rectangle.SetLength(Convert.ToSingle(Console.ReadLine()));
Console.WriteLine($"The new area is now {_rectangle.GetArea()}");
Console.Write("Please now enter a new width: ");
_rectangle.SetWidth(Convert.ToSingle(Console.ReadLine()));
Console.WriteLine($"The new area is now {_rectangle.GetArea()}");

class Area
{
    private float _Length;
    private float _Width;
    private float _Area;

    public Area(float length, float width)
    {
        _Length = length;
        _Width = width;
        UpdateArea();
    }

    public Area()
    {
        _Length = 1f;
        _Width = 1;
        UpdateArea();
    }

    internal void UpdateArea() => _Area = _Length * _Width;

    public void SetLength(float length) => _Length = length;

    public void SetWidth(float width) => _Width = width;

    public float GetLength() => _Length;

    public float GetWidth() => _Width;

    public float GetArea()
    {
        UpdateArea();
        return _Area;
    }
}
*/


//Properties of Arrows

void Vin()
{
    Fletching _Fletching = new Fletching();
    string _Input;
    Console.WriteLine("Please choose the material for the arrow head:");
    Console.WriteLine("Obsidian, Steel or Wood");
    _Input = Console.ReadLine();
    switch (_Input)
    {
        case "Obisian":
            _Fletching.ArrowHead = Fletching._ArrowHeadMaterial.Obsidian;
        break;
        case "Steel":
            _Fletching.ArrowHead = Fletching._ArrowHeadMaterial.Steel;
        break;
        case "Wood":
            _Fletching.ArrowHead = Fletching._ArrowHeadMaterial.Wood;
        break;
    }
    Console.Clear();
    Console.WriteLine("Please select the fletching you require:");
    Console.WriteLine("Plastic, Turkey Feathers, Goose Feathers");
    _Input = Console.ReadLine();
    switch (_Input)
    {
        case "Plastic":
            _Fletching.Fletch = Fletching._FletchingMaterial.Plastic;
        break;
        case "Turkey Feathers":
            _Fletching.Fletch = Fletching._FletchingMaterial.TurkeyFeathers;
        break;
        case "Goose Feathers":
            _Fletching.Fletch = Fletching._FletchingMaterial.GooseFeathers;
        break;
    }
    Console.Clear();
    Console.WriteLine("Please enter the length of arrow you would prefer in centimeters.");
    Console.WriteLine("Between 60 to 100 centimeters are allowed.");
    _Input = Console.ReadLine();

    if (Convert.ToSingle(_Input) > 100f)
    {
        Console.WriteLine("Too large, setting the length to the maximum of 100");
        _Fletching.ArrowLength = 100f;
    }
    else if (Convert.ToSingle(_Input) < 60f)
    {
        Console.WriteLine("Too small, setting the size to the smallest size of 60");
        _Fletching.ArrowLength = 60f;
    }
    else
    {
        _Fletching.ArrowLength = (Convert.ToSingle(_Input));
    }

    Console.Clear();
    Console.WriteLine($"With a {_Fletching.ArrowHead} head, {_Fletching.Fletch}");
    Console.WriteLine($"and a length of {_Fletching.ArrowLength}cm.");
    Console.WriteLine($"The cost of the arrows will be {_Fletching.GetCost()} gold.");

}

Vin();



class Fletching
{
    private _ArrowHeadMaterial _ArrowHead;
    private _FletchingMaterial _Fletching;
    private float _ArrowLength;

    public Fletching(_ArrowHeadMaterial _ArrowMat, _FletchingMaterial _FletchingMat, float _Length)
    {
        _ArrowHead = _ArrowMat;
        _Fletching = _FletchingMat;
        _ArrowLength = _Length;
    }

    public Fletching()
    {
        _ArrowHead = _ArrowHeadMaterial.Wood;
        _Fletching = _FletchingMaterial.GooseFeathers;
        _ArrowLength = 60f;
    }

    public float GetCost()
    {
        float _HeadCost;
        float _FletchingCost;
        float _LengthCost;

        switch (_ArrowHead)
        {
            case _ArrowHeadMaterial.Steel:
                _HeadCost = 10f;
            break;
            case _ArrowHeadMaterial.Wood:
                _HeadCost = 3f;
            break;
            case _ArrowHeadMaterial.Obsidian:
                _HeadCost = 5f;
            break;
            default:
                Console.WriteLine("Invalid Arrow head material, defaulting to zero");
                _HeadCost = 0f;
            break;
        }

        switch (_Fletching)
        {
            case _FletchingMaterial.Plastic:
                _FletchingCost = 10f;
            break;
            case _FletchingMaterial.TurkeyFeathers:
                _FletchingCost = 5f;
            break;
            case _FletchingMaterial.GooseFeathers:
                _FletchingCost = 3f;
            break;
            default:
                Console.WriteLine("Invalid Fletching Selection, defaulting to zero");
                _FletchingCost = 0f;
            break;
        }

        _LengthCost = _ArrowLength * 0.05f;
        return _HeadCost + _FletchingCost + _LengthCost;
    }

    public _ArrowHeadMaterial ArrowHead
    {
        get => _ArrowHead;
        set => _ArrowHead = ArrowHead;
    }

    public _FletchingMaterial Fletch
    {
        get => _Fletching;
        set => _Fletching = Fletch;
    }

    public float ArrowLength
    {
        get => _ArrowLength;
        set => _ArrowLength = value;
    }

    public enum _ArrowHeadMaterial
    {
        Steel,
        Wood,
        Obsidian
    }

    public enum _FletchingMaterial
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }
}

