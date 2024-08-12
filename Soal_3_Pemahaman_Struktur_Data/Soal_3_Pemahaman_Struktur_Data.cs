using System;
using System.Collections.Generic;

class Soal_3_Pemahaman_Struktur_Data
{
    static void Main()
    {
        StackUsingQueues stack = new StackUsingQueues();

        stack.Push(11);
        stack.Push(22);
        stack.Push(33);

        Console.WriteLine("Top element: " + stack.Top());
        Console.WriteLine("Pop element: " + stack.Pop());
        Console.WriteLine("Top element: " + stack.Top());
        Console.WriteLine("Is stack empty? " + stack.IsEmpty()); // Output: False
    }
}

public class StackUsingQueues
{
    private Queue<int> queue1;
    private Queue<int> queue2;

    public StackUsingQueues()
    {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }

    public void Push(int x)
    {
        queue2.Enqueue(x);

        while (queue1.Count > 0)
        {
            queue2.Enqueue(queue1.Dequeue());
        }

        var temp = queue1;
        queue1 = queue2;
        queue2 = temp;
    }

    public int Pop()
    {
        if (queue1.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return queue1.Dequeue();
    }

    public int Top()
    {
        if (queue1.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return queue1.Peek();
    }

    public bool IsEmpty()
    {
        return queue1.Count == 0;
    }
}
