using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace srp.DI
{
    internal class PostManager
    {
        private IPostService service;

        public PostManager(IPostService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<Post>> FilterPosts()
        {
            var posts = await service.GetPosts();
            List<Post> keptPosts = new List<Post>();

            foreach (var post in posts)
            {
                if (post.Body.Length <= 5)
                {
                    keptPosts.Add(post);
                    WriteLine(post.Title);
                }
            }
            return keptPosts;
        }
    }
}