using System;
using System.Collections.Generic;
using System.Text;

namespace GacelaTracker
{
    public class Competition
    {
        public string Title { get; private set; }
        private Dictionary<Guid, Player> _players;

        public Competition(string title)
        {
            Title = title;
            _players = new Dictionary<Guid, Player>();
        }


        public void AddPlayer(Player player)
        {
            if (_players.ContainsKey(player.Guid))
                throw new ArgumentException($"Player {player.Name} with GUID {player.Guid} has already been added");
            _players.Add(player.Guid, player);
        }

        public bool HasPlayer(Guid guid)
        {
            return _players.ContainsKey(guid);
        }
    }
}
