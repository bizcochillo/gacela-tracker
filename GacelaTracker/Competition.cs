using System;
using System.Collections.Generic;
using System.Text;

namespace GacelaTracker
{
    public abstract class Competition
    {
        public string Title { get; private set; }
        private Dictionary<Guid, Player> _playersRecord;        
        public IEnumerable<Player> _players;

        public Competition(string title)
        {           
            Title = title;
            _playersRecord = new Dictionary<Guid, Player>();
        }

        public void AddPlayer(Player player)
        {
            if (_playersRecord.ContainsKey(player.Guid))
                throw new ArgumentException($"Player {player.Name} with GUID {player.Guid} has already been added");
            _playersRecord.Add(player.Guid, player);
        }

        public bool HasPlayer(Guid guid)
        {
            return _playersRecord.ContainsKey(guid);
        }

        public IEnumerable<Player> GetPlayersByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _playersRecord.Values;
        }
    }

    public class OneShotCompetition : Competition
    {
        public bool IsRunning { get; private set; }

        public OneShotCompetition(string title) : base(title) { }

        public void Start()
        {
            IsRunning = true;
        }

        public void End()
        {
            IsRunning = false;
        }
    }

    public class IndividuallyTrackedCompetition : Competition {
        public IndividuallyTrackedCompetition(string title) : base(title) { }
    }

    public interface ITrackable
    {
    }
}
