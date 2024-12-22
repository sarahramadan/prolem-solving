namespace ProblemSolving.QueueAndStack.Stack
{
    public class MinStack
    {

        public void Run()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine(minStack.GetMin());// return -3
            minStack.Pop();
            minStack.Top();    // return 0
            Console.WriteLine(minStack.GetMin()); // return -2
        }
        Stack<int> stackQueue = new Stack<int>();
        Stack<int> minStackQueue = new Stack<int>();
        public MinStack()
        {

        }

        public void Push(int val)
        {
            stackQueue.Push(val);
            if (minStackQueue.Count == 0)
            {
                minStackQueue.Push(val);
            }
            else
            {
                minStackQueue.Push(Math.Min(val, minStackQueue.Peek()));
            }
        }

        public void Pop()
        {
            if (stackQueue.Count > 0) stackQueue.Pop();
            if (minStackQueue.Count > 0) minStackQueue.Pop();
        }
        public int Top()
        {
            return stackQueue.Peek();
        }

        public int GetMin()
        {
            return minStackQueue.Peek();
        }
    }
}
