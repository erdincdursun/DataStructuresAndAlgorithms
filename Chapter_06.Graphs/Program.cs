﻿namespace Chapter_06.Graphs;
internal class Program
{
   static void Main(string[] args)
   {
      CustomGraph graph = new CustomGraph();
      graph.AddVertex(0);
      graph.AddVertex(1);
      graph.AddVertex(2);
      graph.AddVertex(3);
      graph.AddVertex(4);
      graph.AddVertex(5);
      graph.AddVertex(6);
      graph.AddEdge(3, 1);
      graph.AddEdge(3, 4);
      graph.AddEdge(4, 2);
      graph.AddEdge(4, 5);
      graph.AddEdge(1, 2);
      graph.AddEdge(1, 0);
      graph.AddEdge(0, 2);
      graph.AddEdge(6, 5);
      graph.ShowConnections();
   }
}
