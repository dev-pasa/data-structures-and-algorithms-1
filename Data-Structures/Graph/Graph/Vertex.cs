﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Vertex
    {
        public object Value { get; set; }
        public bool IsVisited { get; set; }
        public Dictionary<Vertex, int> AdjacentVertices { get; set; }
    }
}
