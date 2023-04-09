namespace GeneticAlgorithm.MainApp
{
    internal class Creature
    {
        private const int chromosomeLength = 5;

        private static Random random = new Random();
        private string chromosone;

        public Creature()
        {
            chromosone = GenerateChromosome();
        }

        //// Fitness function: determine how well a chromosome solves the problem
        //// multiple criteria
        //public int EvaluateFitness(string chromosome)
        //{
        //    int numOnes = chromosome.Count(c => c == '1');
        //    int numZeroes = chromosome.Count(c => c == '0');
        //    int numRepeats = chromosome.Length - chromosome.Distinct().Count();

        //    // Calculate fitness score as a weighted sum of the criteria
        //    double fitnessScore = 0.5 * numOnes - 0.2 * numZeroes - 0.3 * numRepeats;
        //    return (int)Math.Round(fitnessScore);
        //}

        // Fitness function: determine how well a chromosome solves the problem
        // single criteria
        static int Fitness(string chromosome)
        {
            int score = 0;
            for (int i = 0; i < chromosomeLength; i++)
            {
                if (chromosome[i] == targetString[i])
                {
                    score++;
                }
            }
            return score;
        }

        // Generate a random chromosome
        private static string GenerateChromosome()
        {
            string chromosome = "";
            for (int i = 0; i < chromosomeLength; i++)
            {
                chromosome += (char)random.Next(65, 91); // add a random capital letter to the chromosome
            }
            return chromosome;
        }
    }
}
