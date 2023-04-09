namespace GeneticAlgorithm.MainApp
{
    internal class Context
    {
        private readonly int populationSize;
        private readonly int numberOfGenerations;
        private readonly int mutationRate;


        public Context(int populationSize, int numberOfGenerations, int mutationRate)
        {
            // Get parameters: population size, # of generations, mutation rate
            this.populationSize = populationSize;
            this.numberOfGenerations = numberOfGenerations;
            this.mutationRate = mutationRate;

            Console.WriteLine("Parameters initialized.");
        }

        internal void RunSimulation()
        {
            Console.WriteLine("Simulation started.");

            // 2) Initialize population of successors randomly
            // 3) Evaulate fitness of each successors in the population
            // 4) Select parents for reproduction based on the fitness (higher fitness successors are likely more chosen)
            // 5) Apply crossover/mutation to selected parents to create successors (offspring)
            // 6) Evaulate fitness of each successors in the population
            // 7) Select top N candidates w/ highest fitness
            // 8) Check if max # of generations reached, solution found, fitness threshold achieved
            // 9) If criterion was not met, reselect parents (step 4)
        }
    }
}
