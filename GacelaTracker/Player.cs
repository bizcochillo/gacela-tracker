using System;

namespace GacelaTracker
{
    public class Player
    {
        public string Name { get; private set; }
        public Guid Guid { get; private set; }

        public Player(string name)
        {
            Name = name;
            Guid = Guid.NewGuid();
        }
    }


    /// <summary>
    /// Tracks 
    /// </summary>
    public class PlayerTracker
    {
       
    }
}
