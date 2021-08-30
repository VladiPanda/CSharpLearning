using System.Collections;

namespace Yield_05
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            while (true)
                yield return "Hello world!";
        }
    }
}