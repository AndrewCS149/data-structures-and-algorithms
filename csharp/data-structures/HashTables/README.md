# Hashtable

Code-Challenge 30

*Author: Andrew Smith*

---
### Description

To further understand hashtables, this code challenge consists of a hashtable
that is built from scratch. It includes typical hashtable behaviors such as
add, contains and get value.

---

### Method Descriptions

- GetValue(string key)

Returns the value at a specified key

- GetHash(string key)

Given a key, create a hash code based on the individual character's ACSII codes. 

- Count()

Counts the number of keys inside of a hashtable.

- Contains(string key)

Checks to see if a key exists within the hashtable.

- Add(string key, string value)

Adds a key value pair to the hashtable.

---

### Method Approaches

- GetValue(string key)
  - Define idx as the hash result of the passed in key
  - Define location at map[idx]
  - If location is null
    - return null
  - Otherwise return the value at the location
- GetHash(string key)
  - Define total as zero
  - loop through the keys individual characters
    - Add up how many characters there are to the total 
  - Define a prime value as the total divided by 599
  - Return the prime value modulus the length of the map
- Count()
  - Define count as zero
  - Loop through the keys in the map
    - Increment count variable
  - Return count
- Contains(string key)
  - Define idx as the hash results of the passed in key
  - Define location as the position in the map of the idx
  - If the location is not null
    - Define a current node to the first node in the map
    - While the current node is not null
      - If the current node's key is equal to the passed in key
        - return true
  - return false
- Add(string key, string value)
  - Define idx as the hash result of the passed in key
  - Define a node with the key value pair of the passed in key and value
  - Define a new linked list containing the node
  - If the map at position idx is null
    - Assign that position to the linked list
  - Otherwise add it to the last position in that idx

---

### Efficiency 

- GetValue(string key)
  - Time - O(n)
  - Space - O(1)
- GetHash(string key)
  - Time - O(n)
  - Space - O(1)
- Count()
  - Time  - O(n)
  - Space - O(1)
- Contains(string key)
  - Time - O(n^2)
  - Space - O(1)
- Add(string key, string value)
  - Time - O(1)
  - Space - O(1)

---

### Change Log

- 1.7 - Unit test for all methods - 15 Aug 2020
- 1.6 - Contains() for hashtable - 15 Aug 2020
- 1.5 - GetValue() for hashtable - 15 Aug 2020
- 1.4 - Count() for hashtable - 15 Aug 2020
- 1.3 - GetHash() for hashtable - 14 Aug 2020
- 1.2 - Add() for hashtable - 14 Aug 2020
- 1.1 - Constructor for hashtable - 14 Aug 2020
- 1.0 - Node class - 14 Aug 2020
