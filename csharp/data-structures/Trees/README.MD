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

**BinarySearchTree Class**

- Insert()
  - Inserts a value into the binary search tree based on the inserted value.
  - Time - O(h)
  - Space - O(1)
- Contains()
  - Returns true if the passed in value is found in the binary search tree.
    Returns false if passed in value is not found.
  - Time - O(h)
  - Space - O(1)
  - 
---

### Method Approaches

**BinaryTree Class**

- PreOrder()
- InOrder()
- PostOrder()

**BinarySearchTree Class**

- Insert()
- Contains()

---

### Change Log

- 1.9 Unit test for Contains() - 26 Jul 2020
- 1.8 Contains() for BinarySearchTree - 26 Jul 2020
- 1.7 Unit tests for Insert() - 26 Jul 2020
- 1.6 Insert() for BinarySearchTree class- 26 Jul 2020
- 1.5 Unit tests for PostOrder() - 26 Jul 2020
- 1.4 PostOrer() for BinaryTree class - 26 Jul 2020
- 1.3 Unit tests for InOrder() - 26 Jul 2020
- 1.2 InOrder() for BinaryTree class - 26 Jul 2020
- 1.1 Unit tests for PreOrder() - 26 Jul 2020
- 1.0 PreOrder() for BinaryTree class - 26 Jul 2020