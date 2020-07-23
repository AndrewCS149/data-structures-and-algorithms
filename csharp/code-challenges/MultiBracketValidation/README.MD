# Multi-Bracket Validation

Code Challenge 13

*Author: Andrew Smith*

---

### Method Description & Approach

```MultiBracketVal(string input)```

Given a string, test whether the strings containing brackets are *balanced*. Brackets include
`()` `{}` `[]`.

- Create open and close brackets arrays
- Initialize a state var to zero
- Initialize idx var to zero
- loop through each char in the passed in string
   - if the char is in the close array
     - if the state var is zero or the char doesn't equal the appropriate closing bracket
       - return false
     - decrease state by one
   - if the char is in the open array 
     - assign idx to the appropriate idx of the open array
     - increase state by one
- If state equals zero, return true

---

### Time/Space Complexity

Time - O(n)

Space - O(n)    

---

### White-board Visual

![whiteboard](../../assets/multiBracketValidationWB.jpg)

---

### Change Log

- 1.2 Add Unit tests - 22 Jul 2020
- 1.1 Add MultiBrackVal() - 22 Jul 2020
- 1.0 Add whiteboard visual to readme - 22 Jul 2020