using UserApiDAL;

namespace UserApiBL
{
    public class UserBL :IUserBL
    {
        IUserDAL userDAL;
        public UserBL(IUserDAL userDAL)
        {
            this.userDAL = userDAL; 
        }

        public async Task<List<string>> GetAll()
        {
            return await userDAL.getAll();
        }

        public async Task<bool> insertAll(string value)
        {
            return await userDAL.insertAll(value);
        }
    }
}