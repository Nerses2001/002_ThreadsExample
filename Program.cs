using _002_ThreadsExample;

CounterClass counter = new ();
Thread thread = new (counter.Method);

thread.Start();
thread.Join();

Console.WriteLine("Primary thread finished");

//Console.ReadLine();