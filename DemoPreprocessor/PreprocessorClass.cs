using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPreprocessor
{
    class PreprocessorClass
    {

#if DEVELOP_BUILD
    private readonly static int myEnvVar = 0;
#elif TEST_BUILD
    private readonly static int myEnvVar = 1;
#elif RELEASE_BUILD
    private readonly static int myEnvVar = 2;
#else
     public readonly static int myEnvVar = -1;
#endif

        public static string SayHello()
        {
            switch (myEnvVar)
            {
                case 0:
                    return "You're developing very hard, won't you take a break?";
                case 1:
                    return "It's hard to test all this code..";
                case 2:
                    return "Enjoy this application :)";
                default:
                    return "wtf is happened?!";
            }
        }

    }
}
