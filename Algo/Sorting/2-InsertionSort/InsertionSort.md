# Insertion Sort

- Insertion sort is a simple sorting algorithm where the array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.
- Insertion sort is considered as an optimisation of Bubble sort since it avoids comparing with every element.

### Steps

- At the first pass, sorted array is considered as length 1 (first element of input array)
- The remaining elements are considered as unsorted. 
- On each pass of the unsorted part, the first element is compared with elements in the sorted part and placed accordingly

## BigO
- O(n<sup>2</sup>)