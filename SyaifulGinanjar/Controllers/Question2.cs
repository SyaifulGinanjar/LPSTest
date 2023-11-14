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
        public ApplicationInfo GetInfo()
        {
            return new ApplicationInfo
            {
                Path = "C:/apps/",
                Name = "Shield.exe"
            };
        }
    }
}

