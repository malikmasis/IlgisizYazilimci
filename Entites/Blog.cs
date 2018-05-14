using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Blog : BaseField<int>
    {
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [StringLength(200)]
        public string KeyWords { get; set; }
        public int ViewCount { get; set; }
        public bool IsDraft { get; set; }
        public bool IsApproved { get; set; }
        public virtual User CreteUser { get; set; }
        public virtual Category Category{ get; set; }
        public virtual List<LikedBlog> LikedBlogs { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
