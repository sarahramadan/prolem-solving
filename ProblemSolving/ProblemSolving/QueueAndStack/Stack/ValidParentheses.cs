namespace ProblemSolving.QueueAndStack.Stack
{
    public class ValidParentheses
    {
        List<char> openParentheses = new List<char>() { '(', '[', '{' };
        List<char> closeParentheses = new List<char>() { ')', ']', '}' };

        public void Run()
        {
            Console.WriteLine("Is valid {0}", IsValid("()"));
            Console.WriteLine("Is valid {0}", IsValid("["));
            Console.WriteLine("Is valid {0}", IsValid("]"));

        }
        public bool IsValid(string s)
        {
            Stack<char> stackQueue = new Stack<char>();
            List<char> openParentheses = new List<char>() { '(', '[', '{' };
            List<char> closeParentheses = new List<char>() { ')', ']', '}' };
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (openParentheses.Any(a => a == chars[i]))
                    stackQueue.Push(chars[i]);
                else
                {
                    if (stackQueue.Count == 0 || !isMatchPairs(stackQueue.Pop(), chars[i])) return false;
                }
            }
            return stackQueue.Count == 0;
        }
        private static bool isMatchPairs(char openParentheses, char closeParentheses)
        {
            return (openParentheses == '(' && closeParentheses == ')') ||
                (openParentheses == '[' && closeParentheses == ']') ||
                 (openParentheses == '{' && closeParentheses == '}');
        }
    }
}
