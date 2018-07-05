using System.Collections.Generic;
using System.Threading.Tasks;

namespace srp.DI
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetPosts();
    }
}