# Trees

Code-Challenge 15

*Author: Andrew Smith*

---
### Description

This library contains the methods and logic to create nodes, binary trees and 
binary search trees. The binary tree class has the three common binary tree 
traversal methods: 'PreOrder', 'InOrder' and 'PostOrder'. The binary search tree class
contains the 'insert' and 'contains' methods.

---

### Method Descriptions

**BinaryTree Class**

- PreOrder()
  - Pre order traversal method for a binary tree. The node that is passed in is evaluated
    before it's left and right child nodes. 
  - Time - O(n)
  - Space - O(n)
- InOrder()
  - In order traversal method for a binary tree. The node that is passed in is evaluated
    after it's left child node but before it's right child node.
  - Time - O(n)
  - Space - O(n)
- PostOrder()
  - Post order traversal method for a binary tree. The node that is passed in is evaluated
    after it's left and right child nodes. 
  - Time - O(n)
  - Space - O(n)

---

### Method Approaches

**BinaryTree Class**

- PreOrder()
- InOrder()
- PostOrder()

---

### Change Log

- 1.5 Unit tests for PostOrder() - 26 Jul 2020
- 1.4 PostOrer() - 26 Jul 2020
- 1.3 Unit tests for InOrder() - 26 Jul 2020
- 1.2 InOrder() - 26 Jul 2020
- 1.1 Unit tests for PreOrder() - 26 Jul 2020
- 1.0 PreOrder() - 26 Jul 2020