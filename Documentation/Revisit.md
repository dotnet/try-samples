1. Where static value type member is allocated?  
**On `Loader Heap`**. It can be shared by multiple threads. It is not boxed. It is not allocated on the stack.   
 [**SO question*](https://stackoverflow.com/questions/25741795/is-a-static-value-type-field-boxed-in-the-heap-in-c)

1. What is the advantage of `Task`  over `Thread`?

1. `SynchronizationContext`

   https://docs.microsoft.com/en-us/archive/msdn-magazine/2011/february/msdn-magazine-parallel-computing-it-s-all-about-the-synchronizationcontext

   > 1) One aspect of SynchronizationContext is that it provides a way to queue a unit of work to a context. Note that this unit of work is queued to a context rather than a specific thread.


   > 2) Another aspect of SynchronizationContext is that every thread has a “current” context. A thread’s context isn’t necessarily unique; its context instance may be shared with other threads. It’s possible for a thread to change its current context, but this is quite rare.

   > 3) A third aspect of SynchronizationContext is that it **keeps a count of** outstanding asynchronous operations. 