/**
 * There are a total of n courses you have to take, labeled from 0 to n - 1.
 * 
 * Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]
 * 
 * Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?
 * 
 * For example:
 * 
 * 2, [[1,0]]
 * There are a total of 2 courses to take. To take course 1 you should have finished course 0. So it is possible.
 * 
 * 2, [[1,0],[0,1]]
 * There are a total of 2 courses to take. To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1. So it is impossible.
 * 
 * Note:
 * The input prerequisites is a graph represented by a list of edges, not adjacency matrices. Read more about how a graph is represented.
 * You may assume that there are no duplicate edges in the input prerequisites.
 * click to show more hints.
 * 
 * Hints:
 * This problem is equivalent to finding if a cycle exists in a directed graph. If a cycle exists, no topological ordering exists and therefore it will be impossible to take all courses.
 * Topological Sort via DFS - A great video tutorial (21 minutes) on Coursera explaining the basic concepts of Topological Sort.
 * Topological sort could also be done via BFS.
 * 
 * Depth-first Search, Breadth-first Search, Graph, Topological Sort
 */
 
public class Solution {
    public bool CanFinish(int numCourses, int[,] prerequisites) {
        if (prerequisites == null)
            return true;
        
        int length = prerequisites.Length / 2;
        if (numCourses == 0 || length == 0)
            return true;
            
        Dictionary<int, IList<int>> graph = new Dictionary<int, IList<int>>();
        for (int i = 0; i < length; i++)
        {
            if (graph.ContainsKey(prerequisites[i, 0]))
            {
                graph[prerequisites[i, 0]].Add(prerequisites[i, 1]);
            }
            else
            {
                IList<int> edges = new List<int>();
                edges.Add(prerequisites[i, 1]);
                graph.Add(prerequisites[i, 0], edges);
            }
        }
        
        int[] visited = new int[numCourses];
        for (int crs = 0; crs < numCourses; crs++)
        {
            if (canFinishDFS(graph, visited, crs) == false)
            {
                return false;
            }
        }
        return true;
    }
    
    private bool canFinishDFS(Dictionary<int, IList<int>> graph, int[] visited, int crs)
    {
        if (visited[crs] == -1)
            return false;
        if (visited[crs] == 1)
            return true;
            
        visited[crs] = -1;
        if (graph.ContainsKey(crs))
        {
            foreach (int preCrs in graph[crs])
            {
                if (canFinishDFS(graph, visited, preCrs) == false)
                {
                    return false;
                }
            }
        }
        visited[crs] = 1;
        return true;
    }
}