using System;

namespace H6_Site
{
    public class FileStorageModel
    {
        public string StoredFile { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string OwnerName { get; set; }
        public string FileType { get; set; }
        public int Size { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
