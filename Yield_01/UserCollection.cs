using System.Collections;

namespace Yield_01
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            yield return "Hello world!";
        }
    }
}