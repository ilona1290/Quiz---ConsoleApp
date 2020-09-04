using Newtonsoft.Json;
using QuizWeek3.Domain.Entity;
using System.Collections.Generic;
using System.IO;

namespace QuizWeek3.App.Concrete
{
    public class CreateTableOfTheBestResults
    {
        public void AddNewUserAndHisScore(User user)
        {
            string path = @"bestScores.txt";
            string data = File.ReadAllText(path);
            if (data == "")
            {
                List<User> users = new List<User>();
                users.Add(user);
                using StreamWriter streamWriter = new StreamWriter(path);
                using JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(jsonWriter, users);
            }
            else
            {
                var users = JsonConvert.DeserializeObject<List<User>>(data);
                user.Id = users.Count;
                users.Add(user);
                using StreamWriter streamWriter = new StreamWriter(path);
                using JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(jsonWriter, users);
            }

        }
    }
}
