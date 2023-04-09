namespace GeneticAlgorithm.MainApp
{
    internal class Creature
    {
        private const int chromosomeLength = 5;

        private static Random random = new Random();
        private string chromosone = "";

        public Creature()
        {
            chromosone = GenerateChromosome();
        }

        public int CalculateFitness()
        {
            return 0;
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
