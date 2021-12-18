using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ImageFilesData : IImageFilesData
    {
        private readonly ISqlDataAccess _db;

        public ImageFilesData(ISqlDataAccess db)
        {
            _db = db;
        }

        /***************************************************
         * calls view sproc
         * *************************************************/
        public Task<IEnumerable<ImageFileModel>> View(long? id, long? bugID)
        {
            return _db.LoadData<ImageFileModel, dynamic>("dbo.sp_ImageFiles_Read"
                                                        , new { 
                                                                BugID = ((object)bugID ?? DBNull.Value)
                                                              , ID    = ((object)id    ?? DBNull.Value)
                                                        });
        }

        /***************************************************
         * calls insert sproc
         * *************************************************/
        public async Task<int> Insert(ImageFileModel imgFile)
        {
            return await _db.SaveData("dbo.sp_ImageFiles_Insert", new {
                                                                    BugID         = imgFile.BugID
                                                                  , ImgName       = imgFile.ImgName
                                                                  , ImgDataBytes  = imgFile.ImgDataBytes
                                                                  , ImgDataBase64 = imgFile.ImgDataBase64
                                                                });
        }

        /***************************************************
         * calls update sproc
         * *************************************************/
        public Task Update(ImageFileModel imgFile)
        {
            return _db.SaveData("dbo.sp_ImageFiles_Update", new { imgFile });
        }

        /***************************************************
         * calls delete sproc
         * *************************************************/
        public Task Delete(long? id, long? bugID)
        {
        return _db.SaveData("dbo.sp_ImageFiles_Delete", new { 
                                                              BugID = ((object)bugID ?? DBNull.Value)
                                                            , ID    = ((object)id    ?? DBNull.Value)
                                                            });
        }
    }
}
