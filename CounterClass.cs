namespace _002_ThreadsExample
{
    internal class CounterClass
    {
      //  [ThreadStatic]
        public static int counter;

        public void Method()
        {
            if (counter < 100)
            {
                counter++;
                Console.WriteLine(counter + " Start " + Thread.CurrentThread.GetHashCode());

                var thread = new Thread(Method);
                thread.Start();
                
                thread.Join();

            }
            Console.WriteLine("Thread {0} finished", Thread.CurrentThread.GetHashCode());
        }
    }
}
