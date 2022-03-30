namespace DataAccess.Models
{
    public class ImageFileModel
    {
        public ImageFileModel() { }
        public ImageFileModel(long bugID, string imgName, byte[] imgDataBytes, string imgDataBase64)
        {                                                        
            BugID         = bugID;
            ImgName       = imgName;
            ImgDataBytes  = imgDataBytes;
            ImgDataBase64 = imgDataBase64;
        }

        public long   ID            { get; set; }
        public long   BugID         { get; set; }
        public string ImgName       { get; set; }
        public byte[] ImgDataBytes  { get; set; }
        public string ImgDataBase64 { get; set; }
    }
}
