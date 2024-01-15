namespace stackLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackLL s1 = new StackLL();
            

            s1.Push("Nat");
            s1.Push("Bob");
            s1.Push("Mahmood");
            s1.Push("Zarah");
            s1.printAllNodes();
            Console.WriteLine("\nPeek at the top of the stack");
            Console.WriteLine("The top of the stack: " + s1.Peek());
            Console.WriteLine();
            Console.WriteLine("\npop off top");
            
            s1.Pop();
            s1.printAllNodes();

            Console.WriteLine("The size of the stack is: " + s1.Size());

            Console.WriteLine("\nReversed Stack:");

            s1.Reverse();
            s1.printAllNodes();
        }
    }
}