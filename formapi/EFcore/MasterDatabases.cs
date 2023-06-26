using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace formapi.EFcore
{
    [Table("master_databases")]
    public class MasterDatabases
    {
        [Key, Required]
        public int id { get; set; }
        [Required]
        public int ownerID { get; set; }
        [Required]
        public string name { get; set; } = "";

        //created at and updated at
        [Required]
        public long createdAt { get; set; }
        [Required]
        public long updatedAt { get; set; }
        [Required]
        public bool isDeleted { get; set; }

    }
}
