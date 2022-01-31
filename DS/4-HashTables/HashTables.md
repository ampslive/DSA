# Hash Table

## Associative Array
- A collection of key/value pairs where the key can only exist once in the collection
- These are similar to arrays but can be indexed with any datatypes (int, string, etc)

## Hash-Table
An associative array container that provides O(1) insert, delete and search operations.

## Hash Function
- A function that maps data of arbitrary size to data of a fixed size.
- Example of hash function... For a given string input, the hash can be integer with the sum of ascii values of each input character
- 3 properties of hash function...
  - Hash Function should be stable (same hash value is returned when same input is given)
  - Hash function should be uniform (distribute hash value uniformly in the output space)
  - Hash function should be secure and not easily inverted to original input

## Steps to Insert into Hash-Table
- Find the Hash value for the input data using a Hash Function
- Find the index position for the hash value (eg. index = hashValue % lengthOfHash-Table )
- If no value is present in the index position, then we can insert the value
- If a value is already present at the index... then a `collusion` has occurred
- In the case of a `collusion`, the value is inserted along with the existing values in a linked list format

## Steps to Find in Hash-Table
- Use the hash function to find the hash value of the search input
- Find the index position using the Indexer
- Check if the value exists in the Hash-Table at the index location

## Steps to iterate through Hash-Table
- Iterate through each index location of the Hash-Table

## Growth and Fill Factor
- Based on the `Fill Factor`, the length of Hash-Table can be increased.
  - If fill factor is 0.8, then when 80% of Hash-Table is filled, the length can be increased
- The length by which a Hash-Table can be increased is determined by `Growth Factor`
  - If `growth factor` is 2, then the new length will be... `2 * lengthOfHash-Table`
- When the length of Hash-Table is increased, the index position of each data has to be rearranged since indexer is dependent on length of Hash-Table.