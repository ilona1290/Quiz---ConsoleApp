﻿using QuizWeek3.App.Common;
using QuizWeek3.Domain.Entity;
using System;

namespace QuizWeek3.App.Concrete
{
    public class MenuActionService : BaseService<Menu>
    {

        public MenuActionService()
        {
            CreateMenu();
        }
        public void CreateMenu()
        {
            Menu menuAction1 = new Menu(1, "Zagraj.");
            AddExistItems(menuAction1);
            Menu menuAction2 = new Menu(2, "Dodaj nową kategorię.");
            AddExistItems(menuAction2);
            Menu menuAction3 = new Menu(3, "Dodaj nowe pytanie do istniejącej kategorii.");
            AddExistItems(menuAction3);
            Menu menuAction4 = new Menu(4, "Pokaż najlepsze wyniki.");
            AddExistItems(menuAction4);
            Menu menuAction5 = new Menu(5, "Wyjście.");
            AddExistItems(menuAction5);
        }
        public void ShowMenu()
        {
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Id}. {item.Name}");
            }
        }
    }
}
