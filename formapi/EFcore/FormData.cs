using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace formapi.EFcore
{
    [Table("form_data")]
    public class FormData
    {
        [Key, Required]
        public int id { get; set; }
        [ForeignKey("MasterDatabase")]
        public int DatabaseID { get; set; }
        public string Email { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Phone_number { get; set; }
        public string Address { get; set; }
        
        public FormData(){
            this.Email = "";
            this.First_name = "";
            this.Last_name = "";
            this.Phone_number = "";
            this.Address = "";
        }  

    }
}
