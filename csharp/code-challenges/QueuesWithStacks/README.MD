# Queue with Stacks

Code Challenge 11

*Author: Andrew Smith*

---
### Description

---

### Method Descriptions

**Enqueue()**

Enqueues a value into the PseudoQueue(stack) with a FIFO(first in first out) 
approach.

---

### Method Approaches

- **Enqueue**
  - Push value into stack if stack is null
  - Create new stack
  - While the current stack's top's value is not null
    - Pop the value of the current stack and store into new stack
  - Push passed in value into the new stack
  - While the new stack's top's value is not null
    - Pop the value of the new stack and push into the old stack


---

### White-board Visual

![whiteboard](../../assets/queueWithStackWB.png)

---

### Change Log

- 1.1 Unit test for Enqueue() - 20 July 2020
- 1.0 Enqueue() - 20 July 2020