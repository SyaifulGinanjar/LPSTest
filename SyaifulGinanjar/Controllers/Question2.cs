using System;
namespace SyaifulGinanjar.Controllers
{
    public class ApplicationInfo
    {
        public string Path { get; set; }
        public string Name { get; set; }
    }

    public class Question2
    {
        public (string Path, string Name) GetApplicationInfo()
        {
            return ("C:/apps/", "Shield.exe");
        }
    }
}