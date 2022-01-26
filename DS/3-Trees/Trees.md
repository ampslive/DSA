# Trees
- A data structure where nodes have a 1:N parent-child relationship
- Number of children depend on the type of the tree
- `Root` is where tree begins
- `Degree` of tree denotes number of children a node can have
- `Leaf` is a node that does not contain any children
- `Level` refers to the height of a tree. Root is 1, children of Root is 2, etc

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
| Insertion | O(log n) O(n) as worst case |

