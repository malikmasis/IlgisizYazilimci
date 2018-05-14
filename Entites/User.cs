using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class User: BaseField<long>
    {
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [Required,StringLength(50)]
        public string UserName { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(50)]
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public Guid ActiveCode { get; set; }
        public bool IsActive { get; set; }

        public virtual List<LikedBlog> LikedBlogs { get; set; }
        public virtual List<LikedComment> LikedComments { get; set; }
        public virtual List<Blog> Blogs { get; set; }
        public virtual List<Comment> Comments { get; set; }

    }
}
