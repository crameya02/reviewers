// public class Node<T>
// {
//     public T Data;
//     public Node<T> Left;
//     public Node<T> Right;

//     public Node(T data)
//     {
//         Data = data;
//         Left = null;
//         Right = null;
//     }
// }


// public class BinaryTree<T>
// {
//     public Node<T> Root;

//     public BinaryTree(T rootData)
//     {
//         Root = new Node<T>(rootData);
//     }

//     public void InsertLeft(Node<T> parent, T data)
//     {
//         parent.Left = new Node<T>(data);
//     }

//     public void InsertRight(Node<T> parent, T data)
//     {
//         parent.Right = new Node<T>(data);
//     }

//     public void InOrderTraversal(Node<T> node)
//     {
//         if (node != null)
//         {
//             InOrderTraversal(node.Left);
//             Console.Write(node.Data + " ");
//             InOrderTraversal(node.Right);
//         }
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         // Create the root of the tree
//         BinaryTree<string> tree = new BinaryTree<string>("A");

//         // Insert nodes to form a perfect binary tree
//         tree.InsertLeft(tree.Root, "B");
//         tree.InsertRight(tree.Root, "C");
//         tree.InsertLeft(tree.Root.Left, "D");
//         tree.InsertRight(tree.Root.Left, "E");
//         tree.InsertLeft(tree.Root.Right, "F");
//         tree.InsertRight(tree.Root.Right, "G");

//         // Perform in-order traversal
//         Console.WriteLine("In-order traversal of the perfect binary tree:");
//         tree.InOrderTraversal(tree.Root);
//     }
// }

using System;
using CarLibrary;

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Test();

        // Accessing protected internal member from a derived class within the same assembly
        DerivedCar myDerivedCar = new DerivedCar();
        myDerivedCar.ShowModel();

        // Accessing protected internal member from a derived class in a different assembly
        ExternalDerivedCar myExternalDerivedCar = new ExternalDerivedCar();
        myExternalDerivedCar.DisplayModel();
    }
}

public class ExternalDerivedCar : Car
{
    public void DisplayModel()
    {
        // This works because `model` is protected and accessible in derived classes
        Console.WriteLine("Model from ExternalDerivedCar: " + model);
    }
}
