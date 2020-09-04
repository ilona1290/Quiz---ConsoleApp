using System.Collections.Generic;

namespace QuizWeek3.App.Abstract
{
    public interface IService<T>
    {
        List<T> Items { get; set; }
        public void AddExistItems(T items);
        public List<T> GetAllItems();
        public List<T> ShowItems();
        public void DeleteItem(int idOfItemToRemove);

    }
}
