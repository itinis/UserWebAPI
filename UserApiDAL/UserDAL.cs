namespace UserApiDAL
{
    public class UserDAL : IUserDAL
    {
        private List<string> user = new List<string> { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

        public async Task<List<string>> getAll()
        {
            return user;
        }

        public async Task<bool> insertAll(string value)
        {
            try
            {
                this.user.Add(value);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}