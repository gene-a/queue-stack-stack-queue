using StackQueue;

var stackQueue = new StackQueue<int>();
stackQueue.Enqueue(1);
stackQueue.Enqueue(2);
stackQueue.Enqueue(3);

Console.WriteLine($"Size: {stackQueue.Size()}");
var dequeuedItem1 = stackQueue.Dequeue();
Console.WriteLine($"Dequeued: {dequeuedItem1}");
Console.WriteLine($"Size after dequeue: {stackQueue.Size()}");
Console.WriteLine($"Is empty? {stackQueue.IsEmpty()}");
Console.WriteLine("Items:");
stackQueue.PrintStackQueue();
Console.ReadLine();
