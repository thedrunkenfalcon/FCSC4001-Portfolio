
/*
//Playing Null references
Console.Write("Please enter a word ");
string? word = Console.ReadLine();
if (word != null)
{
    Console.WriteLine($"The word '{word}' is not null");
}
else
{
    Console.WriteLine($"The word is null");
}
*/

/*
//Password Validator
Console.Clear();
Console.WriteLine("Enter a password for validation: ");
string _EnteredPassword = Console.ReadLine();
PasswordValidator passwordValidator = new PasswordValidator(_EnteredPassword);

do
{
    Console.WriteLine("Enter a password for validation: ");
    _EnteredPassword = Console.ReadLine();
    passwordValidator = new PasswordValidator(_EnteredPassword);
}
while (!passwordValidator.Valid);



class PasswordValidator
{
    string password = "";
    private bool capitals = false;
    private bool lowercase = false;
    private bool numbers = false;
    private bool length = false;
    private bool illegalChar = false;
    private bool valid = false;

    public bool Valid
    {
        get => valid;
    }

    public PasswordValidator(string input)
    {
        //length check

        if (input.Length > 13 || input.Length < 6)
        {
            Console.WriteLine("Password Invalid: Please enter a password between six and thirteen characters.");
        }
        else
        {
            //length boolean set
            length = true;

            //searching through the input string
            foreach (char i in input)
            {   
                //Capital letter checks
                if (char.IsUpper(i))
                {
                    if (i == 'T')
                    {
                        Console.WriteLine("Password Invalid: Capital T is not allowed as Ingelmar has decreed.");
                        illegalChar = true;
                    }
                    else
                    {
                        capitals = true;
                    }
                }
                else if (char.IsLower(i))
                {
                    lowercase = true;

                }
                else if (char.IsNumber(i))
                {
                    numbers = true;
                }
                else if (i == '&')
                {
                    Console.WriteLine("Password Invalid: Ampersand is not allowed as Ingelmar has decreed.");
                    illegalChar = true;
                }
                else
                {
                    Console.WriteLine("Invalid, please enter a password containing a capital letter, lowercase letter and a number.");
                }
            }
        }
        if (capitals && lowercase && numbers && length && !illegalChar)
        {
            password = input;
            valid = true;
            Console.WriteLine($"Your current password is {password}");
        }

    }

}
*/


//The Old Robot

Robot robot1 = new Robot();

Console.WriteLine("The commands are as follows: on, off, north, south, east, west, next and finally run.");
Robot();




void Robot()
{
    string _input;
    int i = 0;

    while (i < 3)
    {
        _input = Console.ReadLine();
        switch (_input)
        {
            case "on":
                robot1.Commands[0] = new OnCommand();
            break;
            case "off":
                robot1.Commands[i] = new OffCommand();
            break;
            case "north":
                robot1.Commands[i] = new NorthCommand();
            break;
            case "south":
                robot1.Commands[i] = new SouthCommand();
            break;
            case "east":
                robot1.Commands[i] = new EastCommand();
            break;
            case "west":
                robot1.Commands[i] = new WestCommand();
            break;
            case "next":
                i++;
                Console.Clear();
            break;
            default:
                Console.WriteLine($"Why no work?");
                Console.WriteLine($"{robot1}");
            break;
        }
        
    }
    robot1.Run();

            
    
}


public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; set; } = new RobotCommand?[3];
    
    
    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X}  {Y}  {IsPowered}]");
        }
    }
}

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X--;
        }
    }
}

public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X++;
        }
    }
}


public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y--;
        }
    }
}

public class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y++;
        }
    }
}