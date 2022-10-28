using System;

namespace SampleLibrary
{
    public class MyWonderfullClass
    {

#if NETCOREAPP3_1
        private readonly string version = "3.1";
#elif NET5_0
        private readonly string version = "5.0";
#else
        private readonly string version = "6.0";
#endif
        public string getVersion()
        {
            return version;
        }

    }
}