using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string sprocName, U parameters, string connectionID = "Default");
        Task<int> SaveData<T>(string sprocName, T parameters, string connectionID = "Default");
    }
}