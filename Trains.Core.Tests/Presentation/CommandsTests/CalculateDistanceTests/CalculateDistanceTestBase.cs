﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Trains.Core.DataStructures;
using Trains.Core.Presentation;
using Trains.Core.Presentation.Commands;

namespace Trains.Core.Tests.Presentation.CommandsTests.CalculateDistanceTests
{
    [TestClass]
    public class CalculateDistanceTestBase
    {
        protected Mock<IConsoleService> ConsoleService = new Mock<IConsoleService>();

        CalculateDistance command;
        protected CommandResult CommandResult;
        protected Graph<char> Graph = new Graph<char>();

        protected virtual void SetUpGraph()
        {
            var a = new GraphNode<char>('A');
            var b = new GraphNode<char>('B');
            var c = new GraphNode<char>('C');
            var d = new GraphNode<char>('D');
            var e = new GraphNode<char>('E');
            Graph.AddNode(a);
            Graph.AddNode(b);
            Graph.AddNode(c);
            Graph.AddNode(d);
            Graph.AddNode(e);
            Graph.AddDirectedEdge(a, b, 5);
            Graph.AddDirectedEdge(b, c, 4);
            Graph.AddDirectedEdge(c, d, 8);
            Graph.AddDirectedEdge(d, c, 8);
            Graph.AddDirectedEdge(d, e, 6);
            Graph.AddDirectedEdge(a, d, 5);
            Graph.AddDirectedEdge(c, e, 2);
            Graph.AddDirectedEdge(e, b, 3);
            Graph.AddDirectedEdge(a, e, 7);
        }

        protected virtual void SetUpConsoleService(){}

        [TestInitialize]
        public virtual void BaseInitialize()
        {
            SetUpGraph();
            SetUpConsoleService();
            command = new CalculateDistance(ConsoleService.Object, Graph);
            CommandResult = command.Execute();
        }
    }
}
