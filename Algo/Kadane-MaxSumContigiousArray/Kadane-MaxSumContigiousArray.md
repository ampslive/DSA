# Kadane's Algorithm - Max Sum of Contigious elements in an array

#### Q. Write an efficient program to find the sum of contiguous subarray within a one-dimensional array of numbers that has the largest sum. 


### Steps
- Kadane’s algorithm looks for all positive contiguous segments of the array (`current_sum`). 
- Keep track of maximum sum contiguous segment among all positive segments (`max_sum` is used for this). 
- Each time we get a positive-sum compare it with `max_sum` and update `max_sum` if it is greater than `max_sum` 

### Big-O
- O(n)
