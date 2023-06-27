using formapi.EFcore;
using formapi.Model;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace formapi.Model
{
    public class DbHelper
    {
        public EFDataContext _context;
        public DbHelper(EFDataContext context)
        {
            _context = context;
        }
        public List<MasterDatabaseModel> GetMasterDatabases() 
        { 
            List<MasterDatabaseModel> masterDatabases = new List<MasterDatabaseModel>();
            var masterDatabasesFromDb = _context.MasterDatabases.ToList();
            foreach (var masterDatabase in masterDatabasesFromDb)
            {
                masterDatabases.Add(new MasterDatabaseModel()
                {
                    id = masterDatabase.id,
                    ownerID = masterDatabase.ownerID,
                    name = masterDatabase.name,
                    createdAt = masterDatabase.createdAt,
                    updatedAt = masterDatabase.updatedAt,
                    isDeleted = masterDatabase.isDeleted
                });
            }
            return masterDatabases;
        }

        public MasterDatabaseModel GetMasterDatabase(int id)
        {
            var masterDatabaseFromDb = _context.MasterDatabases.Find(id);
            if (masterDatabaseFromDb == null)
            {
                return null!;
            }
            return new MasterDatabaseModel()
            {
                id = masterDatabaseFromDb.id,
                ownerID = masterDatabaseFromDb.ownerID,
                name = masterDatabaseFromDb.name,
                createdAt = masterDatabaseFromDb.createdAt,
                updatedAt = masterDatabaseFromDb.updatedAt,
                isDeleted = masterDatabaseFromDb.isDeleted
            };
        }

        public MasterDatabaseModel CreateMasterDatabase(MasterDatabaseModel masterDatabase)
        {
            var masterDatabaseToDb = new MasterDatabases()
            {
                id = masterDatabase.id,
                ownerID = masterDatabase.ownerID,
                name = masterDatabase.name,
                createdAt = masterDatabase.createdAt,
                updatedAt = masterDatabase.updatedAt,
                isDeleted = masterDatabase.isDeleted
            };
            _context.MasterDatabases.Add(masterDatabaseToDb);
            _context.SaveChanges();
            return new MasterDatabaseModel()
            {
                id = masterDatabaseToDb.id,
                ownerID = masterDatabaseToDb.ownerID,
                name = masterDatabaseToDb.name,
                createdAt = masterDatabaseToDb.createdAt,
                updatedAt = masterDatabaseToDb.updatedAt,
                isDeleted = masterDatabaseToDb.isDeleted
            };
        }

        public MasterDatabaseModel UpdateMasterDatabase(int id, MasterDatabaseModel masterDatabase)
        {
            var masterDatabaseFromDb = _context.MasterDatabases.Find(id);
            if (masterDatabaseFromDb == null)
            {
                return null!;
            }
            masterDatabaseFromDb.ownerID = masterDatabase.ownerID;
            masterDatabaseFromDb.name = masterDatabase.name;
            masterDatabaseFromDb.createdAt = masterDatabase.createdAt;
            masterDatabaseFromDb.updatedAt = masterDatabase.updatedAt;
            masterDatabaseFromDb.isDeleted = masterDatabase.isDeleted;
            _context.SaveChanges();
            return new MasterDatabaseModel()
            {
                id = masterDatabaseFromDb.id,
                ownerID = masterDatabaseFromDb.ownerID,
                name = masterDatabaseFromDb.name,
                createdAt = masterDatabaseFromDb.createdAt,
                updatedAt = masterDatabaseFromDb.updatedAt,
                isDeleted = masterDatabaseFromDb.isDeleted
            };
        }

        public bool DeleteMasterDatabase(int id)
        {
            var masterDatabaseFromDb = _context.MasterDatabases.Find(id);
            if (masterDatabaseFromDb == null)
            {
                return false;
            }
            _context.MasterDatabases.Remove(masterDatabaseFromDb);
            _context.SaveChanges();
            return true;
        }
        //public class FormData
        //{
        //    [Key, Required]
        //    public int id { get; set; }
        //    [ForeignKey("MasterDatabase")]
        //    public int DatabaseID { get; set; }
        //    public string Email { get; set; }
        //    public string First_name { get; set; }
        //    public string Last_name { get; set; }
        //    public string Phone_number { get; set; }
        //    public string Address { get; set; }

        //    public FormData()
        //    {
        //        this.Email = "";
        //        this.First_name = "";
        //        this.Last_name = "";
        //        this.Phone_number = "";
        //        this.Address = "";
        //    }

        //}

        
        public List<FormDataModel> GetFormDatas()
        {
            List<FormDataModel> formDatas = new List<FormDataModel>();
            var formDatasFromDb = _context.FormData.ToList();
            foreach (var formData in formDatasFromDb)
            {
                formDatas.Add(new FormDataModel()
                {
                    id = formData.id,
                    DatabaseID = formData.DatabaseID,
                    Email = formData.Email,
                    First_name = formData.First_name,
                    Last_name = formData.Last_name,
                    Phone_number = formData.Phone_number,
                    Address = formData.Address
                });
            }
            return formDatas;
        }

        public FormDataModel GetFormData(int id)
        {
            var formDataFromDb = _context.FormData.Find(id);
            if (formDataFromDb == null)
            {
                return null!;
            }
            return new FormDataModel()
            {
                id = formDataFromDb.id,
                DatabaseID = formDataFromDb.DatabaseID,
                Email = formDataFromDb.Email,
                First_name = formDataFromDb.First_name,
                Last_name = formDataFromDb.Last_name,
                Phone_number = formDataFromDb.Phone_number,
                Address = formDataFromDb.Address
            };
        }

        public FormDataModel CreateFormData(FormDataModel formData)
        {
            var formDataToDb = new FormData()
            {
                id = formData.id,
                DatabaseID = formData.DatabaseID,
                Email = formData.Email,
                First_name = formData.First_name,
                Last_name = formData.Last_name,
                Phone_number = formData.Phone_number,
                Address = formData.Address
            };
            _context.FormData.Add(formDataToDb);
            _context.SaveChanges();
            return new FormDataModel()
            {
                id = formDataToDb.id,
                DatabaseID = formDataToDb.DatabaseID,
                Email = formDataToDb.Email,
                First_name = formDataToDb.First_name,
                Last_name = formDataToDb.Last_name,
                Phone_number = formDataToDb.Phone_number,
                Address = formDataToDb.Address
            };
        }

        public FormDataModel UpdateFormData(int id, FormDataModel formData)
        {
            var formDataFromDb = _context.FormData.Find(id);
            if (formDataFromDb == null)
            {
                return null!;
            }
            formDataFromDb.DatabaseID = formData.DatabaseID;
            formDataFromDb.Email = formData.Email;
            formDataFromDb.First_name = formData.First_name;
            formDataFromDb.Last_name = formData.Last_name;
            formDataFromDb.Phone_number = formData.Phone_number;
            formDataFromDb.Address = formData.Address;
            _context.SaveChanges();
            return new FormDataModel()
            {
                id = formDataFromDb.id,
                DatabaseID = formDataFromDb.DatabaseID,
                Email = formDataFromDb.Email,
                First_name = formDataFromDb.First_name,
                Last_name = formDataFromDb.Last_name,
                Phone_number = formDataFromDb.Phone_number,
                Address = formDataFromDb.Address
            };
        }

        public bool DeleteFormData(int id)
        {
            var formDataFromDb = _context.FormData.Find(id);
            if (formDataFromDb == null)
            {
                return false;
            }
            _context.FormData.Remove(formDataFromDb);
            _context.SaveChanges();
            return true;
        }



    }
}
