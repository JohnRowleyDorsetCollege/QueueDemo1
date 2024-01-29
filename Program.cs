// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Queue Demo");
Queue<int> callerIds = new Queue<int>();

callerIds.Enqueue(1);
callerIds.Enqueue(2);
callerIds.Enqueue(3);
callerIds.Enqueue(4);

Console.WriteLine($"Q has {callerIds.Count} items");

if (callerIds.Count > 0)
{
    Console.WriteLine($"First item is {callerIds.Peek()}");
}

foreach (var id in callerIds)
{
    Console.Write(id);
}


while (callerIds.Count > 0)
{
    var queueItem = callerIds.Dequeue();
    Console.WriteLine($"Processing item [{queueItem}]");
    if (callerIds.Contains(3))
    {
        Console.WriteLine($"The id 3 is still in the Q");
    }
}

Console.WriteLine($"Processed Q has {callerIds.Count} items");

// should throw exception
try
{
    // throw new Exception("Boom");
    callerIds.Dequeue();
}
catch (InvalidOperationException e)
{
    Console.WriteLine($"Warning: There is nothing left in the Q to process");
}
catch (Exception e)
{
    Console.WriteLine($"Warning: Unknown Exception {e.Message}");
}
