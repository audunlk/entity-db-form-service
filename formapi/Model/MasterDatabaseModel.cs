using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace formapi.Model
{
    public class MasterDatabaseModel
    {
        public int id { get; set; }
        public int ownerID { get; set; }
        public string name { get; set; } = "";
        public long createdAt { get; set; }
        public long updatedAt { get; set; }
        public bool isDeleted { get; set; }
    }
}
