using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class BaseField<T>
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Today;
        public DateTime ModifiedDate { get; set; }
        [StringLength(30)]
        public string ModifiedUserName { get; set; }
    }
}
