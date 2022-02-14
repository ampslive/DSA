// See https://aka.ms/new-console-template for more information
var g1 = new Graph();
g1.Add("Chicago");
g1.Add("Atlanta");
g1.Add("Orlando");
g1.Add("Las Vegas");
g1.Add("SFO");
g1.Add("Dallas");

g1.AddEdge("Chicago", "Dallas");
g1.AddEdge("Chicago", "Atlanta");
g1.AddEdge("Atlanta", "Orlando");
g1.AddEdge("Atlanta", "Chicago");
g1.AddEdge("Orlando", "Las Vegas");
g1.AddEdge("Orlando", "SFO");
g1.AddEdge("Orlando", "Atlanta");
g1.AddEdge("Las Vegas", "SFO");
g1.AddEdge("Las Vegas", "Orlando");
g1.AddEdge("SFO", "Orlando");
g1.AddEdge("SFO", "Dallas");
g1.AddEdge("SFO", "Las Vegas");
g1.AddEdge("Dallas", "Chicago");
g1.AddEdge("Dallas", "SFO");

var paths = new List<string>();
g1.DFS("Las Vegas", paths);

foreach (var path in paths)
{
    Console.WriteLine(path);
}

g1.BFS("Las Vegas");

Console.ReadLine();

public class Graph
{
    public List<Vertex> AdjacencyList { get; set; } = new List<Vertex>();

    public void Add(string newVertex)
    {
        if (AdjacencyList.Any(x => x.Name == newVertex))
        {
            Console.WriteLine($"{newVertex} is present in Graph");
            return;
        }

        AdjacencyList.Add(new Vertex(newVertex));
        Console.WriteLine($"{newVertex} added to graph");
    }

    public void AddEdge(string parentVertex, string newVertex)
    {
        if (AdjacencyList.Any(x => x.Name == parentVertex))
        {
            var vertex = AdjacencyList.First(x => x.Name == parentVertex);

            if (!vertex.Edges.Contains(newVertex))
            {
                vertex.Edges.Add(newVertex);
                Console.WriteLine($"Edge {newVertex} added to {parentVertex}");
            }
        }
    }

    public void DFS(string destination, List<string> paths)
    {
        Console.WriteLine("------ DFS ------");
        foreach (var a in AdjacencyList)
        {
            bool found = false;
            var visited = new List<string>();
            visited.Add(a.Name);

            if (a.Name == destination)
            {
                found = true;
                continue;
            }

            foreach (var v in a.Edges)
            {
                visited.Add(v);
                if (v == destination)
                {
                    found = true;
                    break;
                }
            }

            if (found == true)
                paths.Add(String.Join(" > ", visited));
        }
    }

    public void BFS(string destination)
    {
        Console.WriteLine("------ BFS ------");
        var visited = new List<string>();
        var parent = new Dictionary<string,string>();
        Queue<string> q = new Queue<string>();
        q.Enqueue(AdjacencyList.First().Name);
        int count = 0;
        while (q.Count > 0)
        {
            count++;
            var current = q.Dequeue();
            
            visited.Add(current); 

            if (current == destination)
            {
                var last = destination;
                while(last != null)
                {
                    Console.Write(last + " <-- ");
                    last = parent.ContainsKey(last) ? parent[last] : null;
                }

                break;
            }

            var neighbors = this.AdjacencyList.First(x => x.Name == current);

            foreach (var n in neighbors.Edges)
            {
                if (!visited.Contains(n))
                {
                    parent[n] = current;
                    q.Enqueue(n);
                    visited.Add(n);
                }
            }
        }
    }
}

public class Vertex
{
    public Vertex(string name)
    {
        Name = name;
        Edges = new List<string>();
    }

    public string Name { get; set; }
    public List<string> Edges { get; set; }

    public override string ToString()
    {
        return Name;
    }
}