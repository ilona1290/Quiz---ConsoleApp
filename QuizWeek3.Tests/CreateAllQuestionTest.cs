using QuizWeek3.App.Concrete;
using QuizWeek3.App.Managers;
using Xunit;

namespace QuizWeek3.Tests
{
    public class CreateAllQuestionTest
    {
        [Fact]
        public void QuestionTest_Check_Last_Category_ID_Equals_Number_Of_Lists_With_Question()
        {
            //Arrange 
            CreateAllCategoriesAndQuestion createAllCategoriesAndQuestion = new CreateAllCategoriesAndQuestion();
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.OpenCategory();
            var numberOfCategories = categoryManager.LastIdOnList();
            //Act
            var listOfListsWithQuestion = createAllCategoriesAndQuestion.CreateListsToQuestionOfEachCategory();
            //Assert
            Assert.Equal(numberOfCategories, listOfListsWithQuestion.Count);
        }
    }
}
