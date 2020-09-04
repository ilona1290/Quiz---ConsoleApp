using QuizWeek3.App.Concrete;
using Xunit;

namespace QuizWeek3.Tests
{
    public class CheckAnswerTest
    {
        [Fact]
        public void TestOfCheckingUserAnswer()
        {
            //Arrange
            string goodAnswer = "A";
            char goodChoice = 'A';
            char badChoice = 'C';
            CheckUserAnswer checkUserAnswer = new CheckUserAnswer();
            //Act
            var falseIfAnswerIsGood = checkUserAnswer.CheckUserAnswerMethod(goodAnswer, goodChoice);
            var trueIfAnswerIsBad = checkUserAnswer.CheckUserAnswerMethod(goodAnswer, badChoice);
            //Assert
            Assert.False(falseIfAnswerIsGood);
            Assert.True(trueIfAnswerIsBad);
        }
    }
}
