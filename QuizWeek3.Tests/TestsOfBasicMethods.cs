using QuizWeek3.App.Concrete;
using QuizWeek3.Domain.Entity;
using Xunit;

namespace QuizWeek3.Tests
{
    public class TestsOfBasicMethods
    {
        [Fact]
        public void Test3MethodsOfCategoryService()
        {
            //Arrange
            Category category1 = new Category(1, "Matematyka");
            Category category2 = new Category(2, "Jêzyk polski");
            var categoryService = new CategoryService();
            //Act
            categoryService.AddExistItems(category1);
            categoryService.AddExistItems(category2);
            var returneditems = categoryService.GetAllItems();
            var lastIDOnList = categoryService.LastIdOnList();
            //Assert 
            Assert.Contains(category1, returneditems);
            Assert.Contains(category2, returneditems);
            Assert.Equal(category2.Id, lastIDOnList);
        }

        [Fact]
        public void TestDeletingMethodFromService()
        {
            //Arrange
            Category category1 = new Category(1, "Matematyka");
            var categoryService = new CategoryService();
            //Act
            categoryService.AddExistItems(category1);
            categoryService.DeleteItem(1);
            var returnedItemsAfterDeleteOneItem = categoryService.GetAllItems();
            //Assert
            Assert.DoesNotContain(category1, returnedItemsAfterDeleteOneItem);
        }
    }
}
