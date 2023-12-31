# 002_ThreadsExample
## Project Description

The "_002_ThreadsExample" project is an example showcasing the use of threads in C# to demonstrate asynchronous operations.

### Codebase

#### CounterClass

The `CounterClass` class defines a method named `Method` which increments the static variable `counter` up to the value of 100 and outputs the current value along with the thread identifier. When the value reaches 100, the method terminates. The `Thread` class is used to create new threads.

If the `[ThreadStatic]` attribute before the declaration of `counter` is uncommented, each thread will have its own copy of the `counter` variable. Otherwise, all threads will operate on a shared value of the `counter` variable.

#### thread.Join()

The `thread.Join()` method is utilized to wait for the completion of the `thread` execution. This allows the main thread to wait for the created thread to finish before proceeding with its work.

### Running the Program

To run the program, an instance of `CounterClass` is created, and a new thread with the `counter.Method` method is started. The main thread waits for its completion using `thread.Join()`. Upon the thread's completion, a message "Primary thread finished" is displayed.
