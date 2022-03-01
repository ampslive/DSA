# Big-O Notation
- Big-O notations represent the worst case scenario of an alogrithm in terms of cost (upper-bound)
- Big-Omega notation represent the best case scenario of an algorith in terms of cost (lower-bound)

## O(1)
Fixed/Constant time algorithm which takes the same time irrespective of input size

## O(n)
Iterating over a collection of data once often indicates an O(n) algorithm.

## O(log n)
- A function whose cost scales logarithmically with the input size
- These algorithms divide the input data into halves

## O(n<sup>2</sup>)
- A function that exhibits quadratic growth relative to the input size
- Doubly nested loop is an indication of these algortihms

## O(nm)
- A function which has two inputs that contribute to the cost
- A nested loop that iterates over two distinct collections of data is an indication of these algortihms

---

## Common patterns that can help determine Big-O...
- Random access to a given element in a collection is always O(1), depending on how the list is indexed. 
  - Arrays, for instance, allow you to access elements randomly if you know their index. 
  - HashSets allow you to access if you know what the value is (the hashed value is the index). 
  - Dictionaries allow you random access if you know what they key is, and so on. 
  
  These types of operations are always O(1) which means if they are combined with other Big-O, they will remain static or constant time.

- List iterations are always O(n)
- Nested Loops on the same collection are always at least O(n^2).
- Divide and Conquer is always O(log n).
- Iterations that use divide and conquer are always O(n log n).