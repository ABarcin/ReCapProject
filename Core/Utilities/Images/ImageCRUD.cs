using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Images
{
    public class ImageCRUD
    {
        public static string Add(IFormFile imageFile)
        {
            PathName pathName = new PathName();
            var sourcePath = Path.GetTempFileName();
            if (imageFile.Length > 0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }
            }
            var result = newPath(imageFile,pathName);
            File.Move(sourcePath, result);
            return pathName.Name;
        }
        public static void Delete(string path)
        {
            File.Delete(path);
        }
        public static string Update(IFormFile imageFile,string sourcePath)
        {
            PathName pathName = new PathName();
            var result = newPath(imageFile,pathName);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return pathName.Name;
        }
        public static string newPath(IFormFile imageFile,PathName pathName)
        {
            FileInfo imageFileInfo = new FileInfo(imageFile.FileName);
            string imageFileExtension = imageFileInfo.Extension;
            var newPath = Guid.NewGuid().ToString()
               + "-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + imageFileExtension;
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()) + @"\WebAPI\Resources\Images");
            string result = $@"{path}\{newPath}";
            pathName.Name = @"\Resources\Images\" + newPath;
            return result;
        }
        public class PathName
        {
            public string Name { get; set; }
        }
    }
    
}
