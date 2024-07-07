namespace FIFOandLIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //queue (first in, frist out) and stack (last in, first out) test
            Console.WriteLine("Queue test:");
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("pierwszy w kolejce");
            myQueue.Enqueue("drugi w kolejce");
            myQueue.Enqueue("trzeci w kolejce");
            myQueue.Enqueue("ostatni w kolejce");

            //metoda .Peek podgląda pierwszy element bez usuwania go z kolejki
            Console.WriteLine($"Metoda .Peek() zwróciła:\n{myQueue.Peek()}");

            //metoda .Dequeue pobiera następny element z POCZĄTKU kolejki
            Console.WriteLine($"Pierwsze wywołanie .Dequeue() zwróciło:\n{myQueue.Dequeue()}");
            Console.WriteLine($"Drugie wywołanie .Dequeue() zwróciło:\n{myQueue.Dequeue()}");

            //metoda .Clear usuwa wszystkie elementy z kolejki
            Console.WriteLine($"Count przed wywołaniem .Clear():\n{myQueue.Count}");
            myQueue.Clear();
            Console.WriteLine($"Count po wywołaniu .Clear():\n{myQueue.Count}");

            //stack test
            Console.WriteLine("\n\nStack test:");
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Pierwszy w stosie");
            myStack.Push("Drugi w stosie");
            myStack.Push("Trzeci w stosie");
            myStack.Push("Ostatni w stosie");

            //metoda .Peek działa dla stosu tak samo jak dla kolejki
            Console.WriteLine($"Metoda .Peek() zwróciła:\n{myStack.Peek()}");

            //metoda .Pop pobiera następny element z WIERZCHOŁKA stosu
            Console.WriteLine($"Pierwsze wywołanie .Pop() zwróciło:\n{myStack.Pop()}");
            Console.WriteLine($"Drugie wywołanie .Pop() zwróciło:\n{myStack.Pop()}");

            //metoda .Clear usuwa wszystkie elementy ze stosu
            Console.WriteLine($"Count przed wywołaniem .Clear():\n{myStack.Count()}");
            myStack.Clear();
            Console.WriteLine($"Count po wywołaniem .Clear():\n{myStack.Count()}");

            //Stack, Queue i List można używać wymiennie z pomocą przeciążonego konstruktora
            myStack.Push("Pierwszy");
            myStack.Push("Drugi");
            myStack.Push("Trzeci");
            myStack.Push("Ostatni");

            Queue<string> anotherQueue = new Queue<string>(myStack);
            List<string> myList = new List<string>(anotherQueue);
            Stack<string> anotherStack = new Stack<string>(myList);
            Console.WriteLine($"\n\nanotherQueue zawiera {anotherQueue.Count} elementy" +
                $"\nmyList zawiera {myList.Count} elementy" +
                $"\nanotherStack zawiera {anotherStack.Count} elementy");
        }
    }
}
