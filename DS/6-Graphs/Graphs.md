# Graphs

- A Graph is a non-linear data structure consisting of nodes and edges.
- The nodes are also referred to as vertices and the edges are lines or arcs that connect any two nodes in the graph.
- Graphs are used to represent networks. The networks may include paths in a city or telephone network or circuit network. Graphs are also used in social networks like linkedIn, Facebook. For example, in Facebook, each person is represented with a vertex(or node). Each node is a structure and contains information like person id, name, gender, locale etc.

## Graph Representation
The following two are the most commonly used representations of a graph. 

- Adjacency Matrix 
- Adjacency List 

## Graph Traversal
Graph can be traversed using...

### DFS (Depth First Traversal or Search)
  - A starting node is picked and subsequent random children of the node is picked to traverse until destination is found
  - If a node that is already visited is encountered, then it is skipped
  - Stack is used to keep track of current node
  - Backtracking is done if no other child nodes are found

### BFS (Breadth First Traversal or Search)
  - A starting node is picked and all the nearest child nodes are checked for destination
  - If destination is not found, the subsequent child nodes of the above are picked and checked for destination
  - If a node that is already visited is encountered, then it is skipped
  - Queues are used to keep track of current node
  - BFS helps in finding the shortest path to the destination