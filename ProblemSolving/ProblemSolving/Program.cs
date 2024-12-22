// See https://aka.ms/new-console-template for more information
using ProblemSolving.QueueAndStack;
using ProblemSolving.QueueAndStack.Stack;

Console.WriteLine("==============================================Queue==============================================");
//Implement  https://leetcode.com/explore/learn/card/queue-stack/228/first-in-first-out-data-structure/1366/
(new QueueImplementation<int>()).Run();

Console.WriteLine("==============================================Cirlcle Queue==============================================");
//Implement  https://leetcode.com/explore/learn/card/queue-stack/228/first-in-first-out-data-structure/1366/
(new CircleQueue()).Run();


Console.WriteLine("==============================================BFS Queue==============================================");
//Implement  https://leetcode.com/explore/learn/card/queue-stack/228/first-in-first-out-data-structure/1366/
(new BFSQueue()).Run();

Console.WriteLine("==============================================Min Stack==============================================");
(new MinStack()).Run();

Console.WriteLine("==============================================Valid Parentheses==============================================");
(new ValidParentheses()).Run();

Console.WriteLine("==============================================Daily Temperatures==============================================");
(new DailyTemperature()).Run();