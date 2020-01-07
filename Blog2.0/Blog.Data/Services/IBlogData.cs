using Blog.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Services
{
    public interface IPostData
    {
        IEnumerable<Post> GetAll();
    }
}
