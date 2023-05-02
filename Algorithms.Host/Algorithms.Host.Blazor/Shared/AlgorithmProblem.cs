namespace Algorithms.Host.Blazor.Shared
{
    public class AlgorithmProblem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Statement { get; set; }

        public string Description { get; set; }

        public string Source { get; set; }

        public TagEnum Tag { get; set; }
    }
}
