using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApiBL
{
    public interface IUserBL
    {
        Task<List<string>> GetAll();
        Task<bool> insertAll(string value);

    }
}
