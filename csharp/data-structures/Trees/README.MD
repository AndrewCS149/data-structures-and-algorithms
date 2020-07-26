# Trees

Code-Challenge 15

*Author: Andrew Smith*

---
### Description

---

### Method Descriptions

**BinaryTree Class**

- Push() - pushes a value to the top of the stack
  - Time - O(1)
  - Space - O(n)
- Pop() - pops off the value of the top node and returns its value
  - Time - O(1)
  - Space - O(n)
- Peek() - returns the value of the top node without removing it
  - Time - O(1)
  - Space - O(1)
- IsEmpty() - Checks whether a stack is empty or not
  - Time - O(1)
  - Space - O(1)

**Queue Class**

- Enqueue() - Places a node into the rear of the queue
  - Time - O(1)
  - Space - O(n)
- Dequeue() - Removes the front node and returns its value
  - Time - O(1)
  - Space - O(n)
- Peek() - Returns the front nodes value without removing it
  - Time - O(1)
  - Space - O(1)
- IsEmpty() - Checks whether a stack is empty or not
  - Time - O(1)
  - Space - O(1)

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
