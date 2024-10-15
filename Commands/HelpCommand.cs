public class HelpCommand : Command
{
    public HelpCommand(Program program) : base("help", program)
    {
    }

    public override void Execute(string[] commandArgs)
    {
        Console.WriteLine("Help commands:");
        Console.WriteLine("create-task - Create a task");
        Console.WriteLine("remove-task - Remove a task");
        Console.WriteLine("search-task - Search for a task");
    }
}