# Binary Search

- Binary Search is done on a sorted array

## Steps to perform Binary Search

1. Find mid index => floor((low index + high index)/2)
2. If mid index value is the key, return
3. If key is greater than mid index value... 
   - Discard left side of the array 
   - Repeat from Step 1 with low index = mid+1
4. If key is lesser than mid index value... 
   - Discard right side of the array 
   - Repeat from Step 1 with high index = mid-1

## BigO Notation
- O(log n) - Time Complexity
- O(log n) - Space Complexity