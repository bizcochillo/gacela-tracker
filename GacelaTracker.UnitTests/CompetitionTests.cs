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
            var comp = new Competition("TestTitle");

            // Then
            Assert.Equal("TestTitle", comp.Title);
        }

        [Fact]
        public void GivenCompetition_WhenUserIsAdded_ThenUserIsInCompetition()
        {
            // Given
            var player = new Player("PlayerName");
            var comp = new Competition("CompName");

            // When 
            comp.AddPlayer(player);

            // Then
            Assert.True(comp.HasPlayer(player.Guid));
        }
    }
}
