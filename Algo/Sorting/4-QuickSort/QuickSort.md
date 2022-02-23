# Quick Sort

- QuickSort is a Divide and Conquer algorithm. It picks an element as pivot and partitions the given array around the picked pivot. 
- The pivot can be one of the below...
  - First element
  - Last element
  - Random element
  - Mid element
- Partition logic is used to sort elements around the pivot

### Steps
- Start from the leftmost element and keep track of index of smaller (or equal to) elements as `i` 
- While traversing, if we find a smaller element, we swap current element with `arr[i]`. Otherwise we ignore current element. 
- After the above loop, increase `i` and swap value with pivot position
- Return `i` as pivot position
- Recursive calls for QuickSort with low and high values around pivot 

## BigO
- O(n<sup>2</sup>) in worst case scenario
- O(n logn) in average cases