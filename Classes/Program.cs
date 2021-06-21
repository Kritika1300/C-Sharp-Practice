using System;

namespace Classes
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }

    //public class PhotoProcessor    WITHOUT USE OF DELEGATES
    //{
    //    public void Process(string path)
    //    {
    //        var photo = Photo.Load(path);
    //        var filters = new PhotoFilters();
    //        filters.ApplyBrightness(photo);
    //        filters.ApplyContrast(photo);
    //        filters.Resize(photo);
    //        photo.Save();
    //    }
    //}
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo); // points to function with this kind of signature i.e return type void and parameter type Photo

        public void Process(string path,PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
    }


    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resizing");
        }
    }
 
    class Program
    {
        public static void Main()
        {
            PhotoProcessor p = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;
            p.Process("hewe",filterHandler);
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove red eye");
        }
    }
}
