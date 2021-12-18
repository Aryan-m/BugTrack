using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface IImageFilesData
    {
        public Task Delete(long? id, long? bugID);
        public Task<int> Insert(ImageFileModel imgFile);
        public Task Update(ImageFileModel imgFile);
        public Task<IEnumerable<ImageFileModel>> View(long? id, long? bugID);
    }
}