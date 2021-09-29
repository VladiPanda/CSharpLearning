using System.Buffers.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GenericsCodeBlog
{
    public class Apple<T> : Product<T>
    {
        public Apple(string name, T volume, T energy) : base(name, volume, energy)
        {
            
        }
    }
}