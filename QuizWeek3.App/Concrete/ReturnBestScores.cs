using Newtonsoft.Json;
using QuizWeek3.App.Common;
using QuizWeek3.Domain.Entity;
using System.Collections.Generic;
using System.IO;

namespace QuizWeek3.App.Concrete
{
    public class ReturnBestScores : BaseService<User>
    {
        public List<User> ReturningMethod()
        {
            string path = @"bestScores.txt";
            string data = File.ReadAllText(path);
            //Przypisujemy zwrócone dane liście z bazowego serwisu, żeby można na tej liście z tymi elementami 
            //działać metodami z bazowego serwisu.
            Items = JsonConvert.DeserializeObject<List<User>>(data);
            return Items;
        }
    }
}
