# Heap

- Heap is Tree type Data Structure
- There are two types of Heap...
  - Min Heap (Root is the least value)
  - Max Heap (Root is the max value)
- When an node is added, they need to be added from left to right of the parent node
- After adding the new node, the heap will be rearranged (heapify) to make sure the min/max heap is maintained.
- Heap is good for insertion, finding min or max

---
## Big-O
| Operation    | Complexity |
| ------------ | ---------- |
| Insert       | O(log N)   |
| Search       | O(N)       |
| Find Min/Max | O(1)       |
| Delete Min   | O(log n)   |