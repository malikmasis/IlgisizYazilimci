using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entites
{
    public class Category: BaseField<short>
    {
        [StringLength(50), DisplayName("İsim"), Required(ErrorMessage = "Zorunlu Alan")]
        public string Name { get; set; }

        public virtual List<Blog> Blogs { get; set; }

    }
}