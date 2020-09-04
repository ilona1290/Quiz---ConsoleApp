using QuizWeek3.App.Concrete;
using QuizWeek3.Domain.Entity;
using System.Linq;
using Xunit;

namespace QuizWeek3.Tests
{
    public class ReturnBestScoresTest
    {
        [Fact]
        public void UserTest_Check_LastID_Equals_UsersCount()
        {
            //Arrange
            ReturnBestScores returnBestsScores = new ReturnBestScores();
            //Act
            var allUsers = returnBestsScores.ReturningMethod();
            int idOfLastUser = returnBestsScores.LastIdOnList();
            //Assert
            Assert.Equal(allUsers.Count - 1, idOfLastUser);
        }
    }
}
