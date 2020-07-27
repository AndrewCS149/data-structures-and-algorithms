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
  - Create new list
  - Call overloaded PreOrder method which will:
    - take in the list and root as parameters
    - add the root value to the list
    - check if roots left child is not null
      - call PreOrder with the list and the roots left child as arguments
    - check if roots right child is not null
      - call PreOrder with the list and the roots right child as arguments
  - Return the list
  
- InOrder()
  - Create new list
  - Call overloaded InOrder method which will:
    - take in the list and root as parameters
    - check if roots left child is not null
      - call InOrder with the list and the roots left child as arguments
    - add the root value to the list
    - check if roots right child is not null
      - call InOrder with the list and the roots right child as arguments
  - Return the list
  
- PostOrder()
  - Create new list
  - Call overloaded PostOrder method which will:
    - take in the list and root as parameters
    - check if roots left child is not null
      - call PostOrder with the list and the roots left child as arguments
    - check if roots right child is not null
      - call PostOrder with the list and the roots right child as arguments
    - add the root value to the list
  - Return the list

---

**BinarySearchTree Class**

- Add()
  - Create new node with the passed in value
  - if the root is null
    - assign root the new node
  - otherwise
    - call overloaded Add() method which takes the new node and the root in as 
      arguments.
      - If the new node's value is less than the root's value
        - if the roots left child is null
          - assign the new node to the root's left child
        - otherwise
          - re-assign the root the root's left child
          - call Add() with the new node and the root as arguments
      - If the new node's value is greater than the root's value
        - if the root's right child is null
          - assign the new node to the root's right child
        - otherwise
          - re-assign the root the root's right child
          - call Add() with the new node and the root as arguments

- Contains()
  - Initialize a bool names 'contains'
  - if the root is null
    - return false
  - if the root is not null
    - re-assign contains to the output of the overloaded method call Contains() which 
      takes in the passed in value and the root as arguments
      - Initialize another 'contains' variable to false
      - if the passed in value is equal the root's value
        - return true
      - if it is less than the root's value
        - if the root's left child is not null
          - re-assign root to the root's left child
          - re-assign contains to the output of the recursive call to Contains() with the 
            value and the new root as arguments
     - if it is greater than the root's value
       - if the root's right child is not null
         - re-assign root to the root's right child
         - re-assign contains to the output of the recursive call to Contains() with the 
           value and the new root as arguments
    - return contains
  - return contains

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