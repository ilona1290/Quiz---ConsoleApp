using QuizWeek3.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizWeek3.App.Concrete
{
    public class ShowInRightOrder
    {
        public List<User> OrganizeTheList(List<User> items)
        {
            var Users = items.OrderByDescending(i => i.Result).ToList();
            return Users;
        }

        public void ShowOrganizedList(List<User> users)
        {
            Console.WriteLine("\r\nNajlepsze wyniki to: ");
            int i = 0;
            foreach (var item in users)
            {
                Console.WriteLine($"{++i}. {item.Name} - {item.Result}");
            }
        }
    }
}
