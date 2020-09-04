using QuizWeek3.App.Concrete;
using Xunit;

namespace QuizWeek3.Tests
{
    public class TestOfCountingPoints
    {
        [Fact]
        public void Check_IF_ChangeTimeToPoints_Method_Correctly_Transfering_Time_To_Points_AND_Adding_Them_To_Properties()
        {
            //Arrange
            AmoutOfUserPointsFromGame amoutOfUserPointsFromGame = new AmoutOfUserPointsFromGame();
            double time = 4.50;
            //Act
            var points = amoutOfUserPointsFromGame.ChangeTimeToPoints(time);
            //Assert
            Assert.Equal(5500, points);
            Assert.Equal(amoutOfUserPointsFromGame.AllPointsFromGame, amoutOfUserPointsFromGame.ReturnAllPoints());
        }
    }
}
