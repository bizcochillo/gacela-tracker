using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GacelaTracker.UnitTests
{
    public class CompetitionTests
    {
        [Fact]
        public void GivenNoCompetition_WhenCreated_NameIsSet()
        {
            // Given

            // When
            var comp = new OneShotCompetition("TestTitle");

            // Then
            Assert.Equal("TestTitle", comp.Title);
        }

        [Fact]
        public void GivenCompetition_WhenUserIsAdded_ThenUserIsInCompetition()
        {
            // Given
            var player = new Player("PlayerName");
            var comp = new OneShotCompetition("CompName");

            // When 
            comp.AddPlayer(player);

            // Then
            Assert.True(comp.HasPlayer(player.Guid));
        }

        [Fact]
        public void GivenCompetition_WhenCreated_ThenPropertyIsRunningIsFalse()
        {
            //Given
            //When
            var comp = new OneShotCompetition("TestName");
            
            //Then
            Assert.False(comp.IsRunning);
        }

        [Fact]
        public void GivenCompetition_WhenStarted_ThenPropertyIsRunningIsTrue()
        {
            //Given
            var comp = new OneShotCompetition("TestName");

            //When
            comp.Start();

            //Then
            Assert.True(comp.IsRunning);
        }
    }
}
