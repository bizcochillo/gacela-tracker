using System;
using Xunit;

namespace GacelaTracker.UnitTests
{
    public class PlayerTests
    {
        [Fact]
        public void GivenNoPlayer_WhenCreated_NameIsSet()
        {
            // Given

            // When
            var player = new Player("TestName");

            // Then
            Assert.Equal("TestName", player.Name);
        }
    }
}
