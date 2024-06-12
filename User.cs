

namespace Code_Academy_Task_Encapsulation
{
   public class User
    {
        private static int NextId=1;
        public int Id { get;  }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string fullname, string email, string password)
        {
            Id = NextId++;
            this.Email = email;
            this.Fullname = fullname;
            this.Password = password;
        }
      public   static bool PassWordChecker(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            bool HasUpperCase = false;
            bool HasLowerCase = false;
            bool HasDigit = false;
           foreach (char c in password) { 
            if(char.IsUpper(c))
                {
                    HasUpperCase = true;
                }
           else if(char.IsLower(c))
                {
                    HasLowerCase = true;
                }
              else  if (char.IsDigit(c))
                {
                    HasDigit = true;
                }
            }
           return HasDigit&&HasLowerCase&&HasUpperCase;
            }

        public string GetInfo()
        {
            return $"{Id},{Fullname},{Email}"; 

        }
        public static  User FindUserById (int id, User[] users)
        {
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return new User("not found","not found","not found");
        }
           

        }
   
    }

