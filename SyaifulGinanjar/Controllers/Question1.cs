using System;
using static System.Net.Mime.MediaTypeNames;

namespace SyaifulGinanjar.Controllers
{
    public class Application
    {
        public Protected? _protected { get; set; }
    }
    public class Protected
    {
        public long shieldLastRun { get; set; }
    }
    public class Question1
    {
        /***
         * Remove unnecessary nested if with simple default logic to check the value 
        ***/
		public long Question1Method()
		{
			var application = new Application();
            if (application?._protected != null)
            {
                return application._protected.shieldLastRun;
            }
            return 0;
		}
	}
}