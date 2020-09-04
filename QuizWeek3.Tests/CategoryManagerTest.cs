using QuizWeek3.App.Managers;
using Xunit;

namespace QuizWeek3.Tests
{
    public class CategoryManagerTest
    {
        [Fact]
        public void CategoryTest_Check_LastID_Equals_CategoryCount()
        {
            //Arrange
            CategoryManager categoryManager = new CategoryManager();
            //Act
            categoryManager.OpenCategory();
            var categories = categoryManager.GetAllItems();
            var idOflastCategory = categoryManager.LastIdOnList();
            //Assert
            Assert.Equal(categories.Count, idOflastCategory);
        }
    }
}
