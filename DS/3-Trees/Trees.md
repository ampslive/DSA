# Trees
- A data structure where nodes have a 1:N parent-child relationship
- Number of children depend on the type of the tree
- `Root` is where tree begins
- `Degree` of tree denotes number of children a node can have
- `Leaf` is a node that does not contain any children
- `Level` refers to the height of a tree. Root is 1, children of Root is 2, etc
- Tree can be represented as an array...
  - Parent is i (ex: 0th index of array)
  - Left child is at 2i + 1 (ex: 1st index)
  - Right child is at 2i + 2 (ex: 2nd index of array)
  - To find parent... CEIL[i/2] - 1 (ex: if i = 4; parent is at 1st index)
  - To find leaf nodes... FLOOR[n/2] + 1 to n (ex: if n = 7; 3 + 1 to 7; 4 to 7 nodes are leaf nodes)

## Binary Trees
- Tree that can at most contain two children (left, right)

## Binary Search Tree
- Binary Tree where nodes with lesser value are placed on left of the root, and nodes with equal or greater values are placed to the right of the root
- Left most leaf node will be the least value
- Right most leaf node will be the max value

## Tree Traversal Algorithms
- Pre-Order : The node is visited before it's children
- In-Order : The left child is visited before the node, then the right child
- Post-Order : The left and right children are visited before the node

---
## Big-O Notation for Binary Search Tree
| Operation | Complexity                  |
| --------- | --------------------------- |
| Insertion | O(log n)                    |
|           | O(n) as worst case          |
| Rmoval    | O(log n)                    |
|           | O(n) as worst case          |
