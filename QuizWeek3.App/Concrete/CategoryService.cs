using QuizWeek3.App.Common;
using QuizWeek3.Domain.Entity;

namespace QuizWeek3.App.Concrete
{
    public class CategoryService : BaseService<Category>
    {
        public void DeleteCat(int idCat)
        {
            DeleteItem(idCat);
        }
    }
}
