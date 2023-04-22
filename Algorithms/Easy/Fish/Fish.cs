namespace Algorithms.Easy.Fish
{
    public class Fish
    {
        public int Id { get; set; }

        public int Size { get; set; }

        public Direction Direction { get; set; }

        public Fish(int id, int size, Direction direction)
        {
            Id = id;
            Size = size;
            Direction = direction;
        }
    }
}
