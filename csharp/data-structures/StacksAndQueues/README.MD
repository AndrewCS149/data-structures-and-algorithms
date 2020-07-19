# Linked List Library

*Author: Andrew Smith*

---
### Description

To better understand the theory behind stacks an queues, this is a group of classes
that create a simplified version of queues and stacks from scratch.

---

### Method Descriptions

**Stack Class**

- Push() - pushes a value to the top of the stack
- Pop() - pops off the value of the top node and returns its value
- Peek() - returns the value of the top node without removing it
- IsEmpty() - Checks whether a stack is empty or not

**Queue Class**

- Enqueue() - Places a node into the rear of the queue
- Dequeue() - Removes the front node and returns its value
- Peek() - Returns the front nodes value without removing it
- IsEmpty() - Checks whether a stack is empty or not

---

### Method Approaches

**Stack Class**

- Push()
  - Create new node
  - Assign new node.Next to top
  - Assign top to new node
- Pop() 
  - Create temporary node that is equal to top node
  - Assign top node to top.Next node
  - Return the new temporary's value
- Peek() 
  - Return tops value
- IsEmpty()
  - Check tops value
  - If null, return true
  - If not null, return false

**Queue Class**

- Enqueue() 
  - Create new node
  - If front node is null
    - Assign Front node to new node
    - Assign rear node to new node
  - If front node is not null
    - Assign rear.Next to new node
    - Assign rear to new node
- Dequeue() 
  - If front node is null
    - throw exception
  - Create temporary node and assign it to front node
  - Assign front node to front.Next node
  - Return temporary node
- Peek() 
  - If front node is null
    - throw exception
  - Return front node's value
- IsEmpty()
  - Check tops value
  - If null, return true
  - If not null, return false

---

### Change Log

- 1.5 IsEmpty() for Queue class - July 18 2020
- 1.4 Peek() - 18 July 2020
- 1.3 Dequeue() - 18 July 2020
- 1.2 Push() / Pop() / Peek() / IsEmpty() - 17 July 2020
- 1.1 Unit tests for Stack methods - 17 July 2020
- 1.0 Stack & Node Classes - 17 July 2020
