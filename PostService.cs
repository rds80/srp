using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace srp.DI
{
    public class PostService : IPostService
    {
        public PostService()
        {
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            using (var http = new HttpClient())
            {
                var postsJson = await http.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
                return JsonConvert.DeserializeObject<IEnumerable<Post>>(postsJson);
            } 

        }
    }
}