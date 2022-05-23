using t.data.EF;
using t.domain.Entities;

namespace t.app.Services
{
    public class PostsService
    {
        private readonly EFDbContext _eFDbContext;

        public PostsService()
        {
            _eFDbContext = new EFDbContext();
        }


        public void Get()
        {
            

        }
    }
}
