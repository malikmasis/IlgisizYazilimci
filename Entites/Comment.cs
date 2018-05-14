using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Comment : BaseField<long>
    {
        [StringLength(5000), DisplayName("Yorum")]
        public string Content { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual List<LikedComment> LikedComments { get; set; }
    }
}
