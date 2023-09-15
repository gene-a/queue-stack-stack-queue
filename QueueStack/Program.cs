using QueueStack;

var queueStack = new QueueStack<int>();
queueStack.Push(1);
queueStack.Push(2);
queueStack.Push(3);

Console.WriteLine($"Size: {queueStack.Size()}");
var poppedItem1 = queueStack.Pop();
Console.WriteLine($"Popped: {poppedItem1}");
Console.WriteLine($"Size after pop: {queueStack.Size()}");

Console.WriteLine($"Is empty? {queueStack.IsEmpty()}");
Console.WriteLine("Items:");
queueStack.PrintQueueStack();
Console.ReadLine();
