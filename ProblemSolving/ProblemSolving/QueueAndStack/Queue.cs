namespace ProblemSolving.QueueAndStack
{
    /// <summary>
    /// Build in queue 
    /// if implement using fixed array 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueImplementation<T>
    {
        Queue<T> queue = new Queue<T>();

        public void Enqueue(T value)
        {
            queue.Enqueue(value);
        }
        public T Dequeue()
        {
            if (!IsEmpty())
                return queue.Dequeue();

            throw new InvalidOperationException("Queue is empty");
        }
        public bool IsEmpty()
        {
            return queue.Count == 0;
        }
        public T GetFront()
        {
            return queue.Peek();
        }
        public void Clear()
        {
            queue.Clear();
        }

        public void Run()
        {
            QueueImplementation<int> _queue = new QueueImplementation<int>();
            _queue.Enqueue(0);
            _queue.Enqueue(1);
            _queue.Enqueue(2);
            _queue.Enqueue(3);
            _queue.Enqueue(4);

            // Check if the queue is empty after adding elements
            Console.WriteLine($"Is the queue empty? {_queue.IsEmpty()}");

            // Dequeue an element
            Console.WriteLine($"Dequeued element: {_queue.Dequeue()}");

            // Peek at the next element
            Console.WriteLine($"Next element to dequeue: {_queue.GetFront()}");

            // Clear the queue
            _queue.Clear();
            Console.WriteLine($"Is the queue empty after clearing? {_queue.IsEmpty()}");
        }
    }

}
