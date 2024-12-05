namespace ProblemSolving.QueueAndStack
{
    public class Node
    {
        public readonly int value;
        public List<Node> Neighbors = new List<Node>();
        public Node(int value)
        {
            this.value = value;
        }
    }
    public class BFSQueue
    {
        public void Run()
        {
            // Create nodes
            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            // Connect nodes (build the graph)
            node0.Neighbors.Add(node1);
            node0.Neighbors.Add(node2);
            node1.Neighbors.Add(node0);
            node1.Neighbors.Add(node3);
            node1.Neighbors.Add(node4);
            node2.Neighbors.Add(node0);
            node2.Neighbors.Add(node5);
            node2.Neighbors.Add(node6);
            node3.Neighbors.Add(node1);
            node4.Neighbors.Add(node1);
            node5.Neighbors.Add(node2);
            node6.Neighbors.Add(node2);

            // Call BFS starting from node 0
            GetBFSGraphByNode(node0);
            var step = GetBFSShortedPath(node0, 5);
            Console.WriteLine("The steps {0}", step);
        }
        public int GetBFSShortedPath(Node root, int target)
        {
            Queue<Node> queue = new Queue<Node>();
            HashSet<Node> visited = new HashSet<Node>();
            int step = 0;

            queue.Enqueue(root);
            visited.Add(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Node current = queue.Dequeue();
                    if (current.value == target)
                    {
                        return step;
                    }
                    foreach (var item in current.Neighbors)
                    {
                        if (!visited.Contains(item))
                        {
                            queue.Enqueue(item);
                            visited.Add(item);
                        }
                    }
                }
                step++;
            }
            return -1;
        }

        public void GetBFSGraphByNode(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            HashSet<Node> visited = new HashSet<Node>();

            queue.Enqueue(root);
            visited.Add(root);
            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                Console.WriteLine($"Visited node: {current.value}");
                foreach (var item in current.Neighbors)
                {
                    if (!visited.Contains(item))
                    {
                        queue.Enqueue(item);
                        visited.Add(item);
                    }
                }
            }
        }
    }
}
