#pragma warning disable IDE0160
namespace Hw3.Exercise5;
#pragma warning restore IDE0160

public static class BinaryTreeSorter
{
    public static List<int> Sort(BinaryNode? node)
    {
        if (node is null)
        {
            return new List<int>();
        }

        var list = new List<int>
        {
            node.Value
        };

        if (node.Left != null)
        {
            list.Add(node.Left.Value);
        }
        if (node.Right != null)
        {
            list.Add(node.Right.Value);
        }

        list.AddRange(InnerSort(node.Left));
        list.AddRange(InnerSort(node.Right));

        return list;
    }

    // Can be private and IEnumerable<int>
    private static IEnumerable<int> InnerSort(BinaryNode? node)
    {
        if (node is null)
        {
            return new List<int>();
        }

        var list = new List<int>();

        if (node.Left != null)
        {
            list.Add(node.Left.Value);
        }
        if (node.Right != null)
        {
            list.Add(node.Right.Value);
        }

        if (node.Left == null)
        {
            if (node.Right == null)
            {
                return list;
            }
            list.AddRange(InnerSort(node.Right));
        }
        else
        {
            list.AddRange(InnerSort(node.Left));
            if (node.Right == null)
            {
                return list;
            }
            list.AddRange(InnerSort(node.Right));
        }

        return list;
    }
}
