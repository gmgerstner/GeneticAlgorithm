using GeneticAlgorithm.MainApp;

internal class Program
{
    private static void Main(string[] args)
    {
        string? inputText;
        Console.WriteLine("Enter:");

        Console.Write("> Population Size = ");
        inputText = Console.ReadLine();
        int populationSize = Convert.ToInt32(inputText);

        Console.Write("> Number of Generations = ");
        inputText = Console.ReadLine();
        int numberOfGenerations = Convert.ToInt32(inputText);

        Console.Write("> Mutation Rate = ");
        inputText = Console.ReadLine();
        int mutationRate = Convert.ToInt32(inputText);

        Context context = new Context(populationSize, numberOfGenerations, mutationRate);
        context.RunSimulation();
    }
}