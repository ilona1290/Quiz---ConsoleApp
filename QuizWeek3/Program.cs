using QuizWeek3.App.Concrete;
using QuizWeek3.App.Managers;
using QuizWeek3.Domain.Entity;
using System;

namespace QuizWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię:");
            string nameofUser = Console.ReadLine();
            Console.WriteLine($"Witaj {nameofUser} w Quizie.");
            while (true)
            {
                Console.WriteLine("Wybierz jedną z 5 opcji:");
                MenuActionService menuAction = new MenuActionService();
                menuAction.ShowMenu();
                int choice;
                Int32.TryParse(Console.ReadLine(), out choice);

                if (choice == 1)
                {
                    PlayGame playGame = new PlayGame();
                    int points = playGame.StartGame();
                    User user = new User(nameofUser, points);
                    CreateTableOfTheBestResults createTableOfTheBestResults = new CreateTableOfTheBestResults();
                    createTableOfTheBestResults.AddNewUserAndHisScore(user);
                }
                else if (choice == 2)
                {
                    CategoryManager categoryManager = new CategoryManager();
                    categoryManager.OpenCategory();
                    categoryManager.AddNewCategory();
                    Console.WriteLine("Kliknij Enter, aby przejść z powrotem do menu głównego.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 3)
                {
                    QuestionManager questionManager = new QuestionManager();
                    questionManager.CheckCategoryToAddQuestion();
                    Console.WriteLine("\r\nPytanie i odpowiedzi zostały pomyślnie dodane.");
                    Console.WriteLine("\r\nNaciśnij Enter, aby przejść do menu głównego.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 4)
                {
                    ReturnBestScores returnBestsScores = new ReturnBestScores();
                    var users = returnBestsScores.ReturningMethod();
                    ShowInRightOrder showInRightOrder = new ShowInRightOrder();
                    var usersInRightOrder = showInRightOrder.OrganizeTheList(users);
                    showInRightOrder.ShowOrganizedList(usersInRightOrder);
                    Console.WriteLine("\r\nNaciśnij Enter, aby przejść do menu głównego.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Do zobaczenia!");
                    break;
                }
            }
        }
    }
}
