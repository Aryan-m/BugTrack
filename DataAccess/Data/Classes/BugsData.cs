using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class BugsData : IBugsData
    {
        private readonly ISqlDataAccess _db;
        private readonly IImageFilesData _imgFilesDB;

        public BugsData(ISqlDataAccess db, IImageFilesData imgFilesDB)
        {
            _db = db;
            _imgFilesDB = imgFilesDB;
        }

        /***************************************************
         * calls view sproc
         * *************************************************/
        public Task<IEnumerable<BugModel>> View(long? id)
        {
            return _db.LoadData<BugModel, dynamic>("dbo.sp_Bugs_View", new { ID = ((object)id ?? DBNull.Value) });
        }

        /***************************************************
         * calls insert sproc
         * *************************************************/
        public async Task<int> Insert(BugModel bug, List<ImageFileModel> imgFiles)
        {
            int bugID = await _db.SaveData("dbo.sp_Bugs_Insert", new { bug.Title, bug.Description });

            if (bugID == 0) return bugID;

            // save files
            foreach (var file in imgFiles)
            {
                file.BugID = bugID;
                await _imgFilesDB.Insert(file);
            }

            return bugID;
        }

        /***************************************************
         * calls update sproc
         * *************************************************/
        public Task Update(BugModel bug, List<ImageFileModel> imgFiles)
        {
            Task saveBug = _db.SaveData("dbo.sp_Bugs_Update", new { bug });

            // delete old files and save new ones
            _imgFilesDB.Delete(null, bug.ID);

            foreach (var file in imgFiles)
            {
                file.BugID = bug.ID;
                _imgFilesDB.Insert(file);
            }

            return saveBug;
        }

        /***************************************************
         * calls delete sproc
         * *************************************************/
        public Task Delete(long id)
        {
            return _db.SaveData("dbo.sp_Bugs_Delete", new { ID = id });
        }
    }
}
