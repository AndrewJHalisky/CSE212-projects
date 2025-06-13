using System.ComponentModel.Design.Serialization;
using System.Transactions;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Interfaces;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }
    private Node? _root;
    
    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        else
        {
            return;
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (Data == value)
        {
            return true;
        }
        if (Left != null && Left.Contains(value))
        {
            return true;
        }
        else if (Right != null && Right.Contains(value))
        {
            return true;
        }
        else
        {
            return false;     
        }  
    }


    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Left == null && Right == null)
        {
            return 1;
        }
        int leftHeight = (Left != null) ? Left.GetHeight(): -1;
        int rightHeight = (Right != null) ? Right.GetHeight(): -1;
        // Replace this line with the correct return statement(s)
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}