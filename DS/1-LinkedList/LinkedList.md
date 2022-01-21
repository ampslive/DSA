# LinkedList

A class containing data and the reference to the next node

```csharp
public class Node
{
  public int Value { get; set; }
  public Node Next { get; set; }
  
  public Node(int value, Node next = null)
  {
     this.Value = value;
     this.Next = next;
  }
}
```

#### Example of LinkedList
<iframe src="https://try.dot.net/?bufferId=linkedlist.cs&fromGist=306e4531f4a94bab44ebae258f9a9f93&canshowgithubpanel=true"> </iframe>



## Doubly Linked List
A linked list that provides forward iteration from the start to the end of the list, and reverse iteration, from end to start.


---
## Big-O Notation for Linked List
| Operation  | Complexity |
| ---------- | ----- |
| AddHead    | O(1)  |
| AddTail    | O(1)  |
| FindItem   | O(n)  |
| Contains   | O(n)  |
| RemoveItem | O(n)  |