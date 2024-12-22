namespace ProblemSolving.QueueAndStack.Stack
{
    public class DailyTemperature
    {
        public void Run()
        {
            DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });

        }
        public int[] DailyTemperatures(int[] temperatures)
        {
            int size = temperatures.Length;
            Stack<int> currentStack = new Stack<int>();
            int[] result = new int[size];


            for (int i = size - 1; i >= 0; i--)
            {
                while (currentStack.Count > 0 && temperatures[i] >= temperatures[currentStack.Peek()])
                {
                    currentStack.Pop();
                }
                //wrong1: it important to check stack is empty or not
                //wrong2: that calculate before pushing 
                if (currentStack.Count > 0 && temperatures[i] < temperatures[currentStack.Peek()])
                {
                    result[i] = i - currentStack.Peek();
                    currentStack.Push(i);
                }
                else
                {
                    result[i] = -1;
                    currentStack.Push(i);
                }
            }
            return result;
        }
    }
}
