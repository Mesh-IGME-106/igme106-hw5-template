using System;
using Microsoft.Xna.Framework;

// DO NOT MODIFY ANYTHING IN THIS FILE
namespace HW5_Dijkstras
{
    /// <summary>
    /// Stores Vertex data along with the information needed to label the vertex
    /// as Dijkstra's runs.
    /// </summary>
    class Vertex
    {
        // Private Fields
        private String name;
        private Vector2 position;
        private int distance;
        private Boolean permanent;
        private Vertex previousVertex;

        /// <summary>
        /// Gets or sets the name of this vertex
        /// </summary>
        public String Name { get { return name; } set { name = value; } }

        /// <summary>
        /// Gets or sets the position of this vertex
        /// </summary>
        public Vector2 Position { get { return position; } set { position = value; } }

        /// <summary>
        /// Gets or sets the visited state of this vertex
        /// </summary>
        public Boolean Permanent { get { return permanent; } set { permanent = value; } }

        /// <summary>
        /// Gets or sets the previous vertex in the shortest path
        /// </summary>
        public Vertex PreviousVertex { get { return previousVertex; } set { previousVertex = value; } }

        /// <summary>
        /// Gets or sets the distance to the source vertex
        /// </summary>
        public int Distance { get { return distance; } set { distance = value; } }


        /// <summary>
        /// Creates a new vertex
        /// </summary>
        /// <param name="name">The name of this vertex</param>
        /// <param name="position">The position of this vertex</param>
        public Vertex(String name, Vector2 position)
        {
            // Save the data
            this.name = name;
            this.position = position;

            // Defaults
            Reset();
        }

        /// <summary>
        /// Resets this vertex
        /// </summary>
        public void Reset()
        {
            distance = int.MaxValue;
            permanent = false;
            previousVertex = null;
        }
    }
}
