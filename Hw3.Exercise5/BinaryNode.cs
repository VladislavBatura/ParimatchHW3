namespace Hw3.Exercise5;

public class BinaryNode
{
    public BinaryNode? Left;
    public BinaryNode? Right;
    public int Value;

    public BinaryNode(BinaryNode? left, BinaryNode? right, int value)
    {
        Left = left;
        Right = right;
        Value = value;
    }
}
