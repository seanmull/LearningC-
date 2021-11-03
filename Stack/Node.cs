namespace LearningC_.Stack
{
    public class Node
    {
        public Node above { get; set; } = null;
        public readonly int _value;

        public Node(int value)
        {
            _value = value;

        }
    }
}