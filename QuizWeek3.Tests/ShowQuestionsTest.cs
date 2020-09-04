using QuizWeek3.App.Concrete;
using Xunit;

namespace QuizWeek3.Tests
{
    public class ShowQuestionsTest
    {
        [Fact]
        public void Checking_If_ShowQuestionAndAnswer_Method_Correctly_Returning_First_Question_By_Checking_Components_Of_This_Question()
        {
            //Arrange
            CreateAllCategoriesAndQuestion createAllCategoriesAndQuestion = new CreateAllCategoriesAndQuestion();
            var listOfQuestions = createAllCategoriesAndQuestion.CreateListsToQuestionOfEachCategory();
            ShowAndDeleteQuestionAndAnswersService showAndDeleteQuestionAndAnswersService = new ShowAndDeleteQuestionAndAnswersService();
            //Act
            var objectWithQuestion = showAndDeleteQuestionAndAnswersService.ShowQuestionAndAnswerOfCategory(listOfQuestions[0]);
            var idOfRandomingQuestion = objectWithQuestion.IdQuestion;
            //Assert
            Assert.InRange(idOfRandomingQuestion, 0, listOfQuestions[0].Count);
            Assert.Equal(objectWithQuestion.Question, listOfQuestions[0][idOfRandomingQuestion].Question);
            Assert.Equal(objectWithQuestion.GoodAnswer, listOfQuestions[0][idOfRandomingQuestion].GoodAnswer);
        }
    }
}
