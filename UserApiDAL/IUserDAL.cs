using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApiDAL
{
    public interface IUserDAL
    {
        Task<List<string>> getAll();
        Task<bool> insertAll(string value);
    }
}
