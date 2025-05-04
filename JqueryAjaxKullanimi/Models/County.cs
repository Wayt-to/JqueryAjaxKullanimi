using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JqueryAjaxKullanimi.Models
{
    // [Serializable]
    public class County
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? City_ID { get; set; }
        [ForeignKey("City_ID")]
        public virtual City City { get; set; }
    }
}