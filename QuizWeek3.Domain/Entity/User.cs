using QuizWeek3.Domain.Common;

namespace QuizWeek3.Domain.Entity
{
    public class User : BaseEntity
    {
        public int Result { get; set; }
        public User()
        {

        }
        public User(string name, int result)
        {
            Name = name;
            Result = result;
        }
        public User(int id, string name, int result)
        {            
            Id = id;
            Name = name;
            Result = result;
        }
    }
}
