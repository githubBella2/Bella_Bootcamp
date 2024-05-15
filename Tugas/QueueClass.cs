namespace Tugas;

public class QueueClass
{
     private Queue<string> queue = new Queue<string>();

    public void Enqueue(string value)
    {
        queue.Enqueue(value);
    }

    public void PrintQueue()
    {
        int count = queue.Count;
        for (int i = 0; i < count; i++)
        {
            Console.Write(queue.Dequeue());
            if (i < count - 1)
            {
                Console.Write(", ");
            }
            
        }
        Console.WriteLine();
    }
}
