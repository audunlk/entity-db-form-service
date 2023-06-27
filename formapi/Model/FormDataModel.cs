namespace formapi.Model
{
    public class FormDataModel
    {
        public int id { get; set; }
        public int DatabaseID { get; set; }
        public string Email { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Phone_number { get; set; }
        public string Address { get; set; }
        
        public FormDataModel()
        {
            this.Email = "";
            this.First_name = "";
            this.Last_name = "";
            this.Phone_number = "";
            this.Address = "";
        }
    }
}
