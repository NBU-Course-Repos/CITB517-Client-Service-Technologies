using App.Persistence.Models;

namespace App.Persistence.Services
{
    public class UserService : PersistenceService<User, String>
    {
        public ICollection<Comment> GetComments(String emailAddress)
        {
            User? user = GetById(emailAddress);
            if (user != null) return user.Comments;
            return new List<Comment>();
        }

        private void ValidateEmail(String email)
        {
            if (!email.Contains("@")) throw new ArgumentException ("Invalid email format ... to add message"); // TODO add proper message for formatting errors
            // TODO add email syntax validators with RegEx
        }
    }
}
