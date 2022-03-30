using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface IBugsData
    {
        Task Delete(long id);
        Task<int> Insert(string userID, BugModel bug, List<ImageFileModel> imgFiles);
        Task Update(string userID, BugModel bug, List<ImageFileModel> imgFiles);
        Task<IEnumerable<BugModel>> View(long? id);
    }
}