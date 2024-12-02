namespace ProblemSolving.QueueAndStack
{
    /// <summary>
    /// define by fixed array and two pointer
    /// </summary>
    public class CircleQueue
    {
        readonly int size = 5;
        readonly int[] arr;
        int head = -1, tail = -1;

        public CircleQueue()
        {
            arr = new int[size];
        }
        public bool Enquque(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Full queue");
                return false;
            }
            if (IsEmpty())
            {
                head = 0;
            }
            tail = (tail + 1) % size;
            arr[tail] = value;
            return true;
        }
        public int Dequque()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            if (tail == head)
            {
                head = -1;
                tail = -1;
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            var currentHead = head;
            head = (head + 1) % size;
            return arr[currentHead];
        }
        public bool IsFull()
        {
            return head == ((tail + 1) % size);
        }
        public bool IsEmpty()
        {
            return head == -1;
        }
        public int Peek()
        {
            return arr[head];
        }
        public void Run()
        {
            CircleQueue queue = new CircleQueue();

            // Enqueue some elements
            queue.Enquque(1);
            queue.Enquque(2);
            queue.Enquque(3);
            queue.Enquque(4);
            queue.Enquque(5);

            // Try to enqueue another element
            queue.Enquque(6); // This will print "Queue is full!"

            // Dequeue elements
            Console.WriteLine("Dequeued: " + queue.Dequque());
            Console.WriteLine("Next element to dequeue: " + queue.Peek());

            // Dequeue remaining elements
            while (!queue.IsEmpty())
            {
                Console.WriteLine("Dequeued: " + queue.Dequque());
            }

            // Try to dequeue from an empty queue
            queue.Dequque(); // This will print "Queue is empty!"
        }
    }
}
