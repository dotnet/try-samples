1. Where static value type member is allocated?  
**On `Loader Heap`**. It can be shared by multiple threads. It is not boxed. It is not allocated on the stack.   
 [**SO question*](https://stackoverflow.com/questions/25741795/is-a-static-value-type-field-boxed-in-the-heap-in-c)

 1. What is the advantage of `Task`  over `Thread`?

