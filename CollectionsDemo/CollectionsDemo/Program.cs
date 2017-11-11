using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var playersDictionary = new Dictionary<string, string>
            {
                {"Center", "Kevin Love"},
                {"Power Forward", "Lebron James"},
                {"Small Forward", "Jae Crowder"},
                {"Shooting Guard", "Dwyane Wade"},
                {"Playmaker", "Isiah Thomas"}
            };

            foreach (var player in playersDictionary)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }

            Console.WriteLine();

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("1 in Queue: {0}", queue.Contains(1));

            Console.WriteLine("Remove 1: {0}", queue.Dequeue());

            Console.WriteLine("Peek 1: {0}", queue.Peek());

            object[] numArray = queue.ToArray();

            Console.WriteLine(string.Join(", ", numArray));

            //queue.Clear();

            foreach (var o in queue)
            {
                Console.WriteLine($"Queue: {o}");
            }

            Console.WriteLine();

            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            foreach (var o in stack)
            {
                Console.WriteLine($"Stack: {o}");
            }

            Console.WriteLine("Peek 1: {0}", stack.Peek());

            Console.WriteLine("Pop 1: {0}", stack.Pop());

            Console.ReadLine();
        }
    }
}
