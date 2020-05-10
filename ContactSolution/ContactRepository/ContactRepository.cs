using ContactDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ContactRepository
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class ContactRepository
    {
        //Map a contact in UI model to database Model type 
        private Contact ToDbModel( ContactModel contactModel)
        {
            var dbContactModel = new Contact
            {
                ContactId = contactModel.Id,
                ContactName = contactModel.Name,
                ContactEmail = contactModel.Email,
                ContactPhoneType = contactModel.PhoneType,
                ContactPhoneNumber = contactModel.PhoneNumber,
                ContactAge= contactModel.Age,
                ContactNotes= contactModel.Notes,
                ContactCreatedDate= contactModel.CreatedDate
            };
            return dbContactModel;
        }

        public ContactModel Add(ContactModel contactModel)
        {
            var dbContactModel = ToDbModel(contactModel);
            DatabaseManager.Instance.Contact.Add(dbContactModel);
            DatabaseManager.Instance.SaveChanges();

            contactModel = new ContactModel
            {
                Age = dbContactModel.ContactAge,
                CreatedDate = dbContactModel.ContactCreatedDate,
                Email = dbContactModel.ContactEmail,
                Id = dbContactModel.ContactId,
                Name = dbContactModel.ContactName,
                Notes = dbContactModel.ContactNotes,
                PhoneNumber = dbContactModel.ContactPhoneNumber,
                PhoneType = dbContactModel.ContactPhoneType
            };
            return contactModel;
        
        
        }
        //Get the list of all contacts in Database and map it to ContactModel
        public List<ContactModel> GetAll()
        {
            var items = DatabaseManager.Instance.Contact
                .Select(x => new ContactModel
                {
                    Age = x.ContactAge,
                    CreatedDate = x.ContactCreatedDate,
                    Email = x.ContactEmail,
                    Id = x.ContactId,
                    Name = x.ContactName,
                    Notes = x.ContactNotes,
                    PhoneNumber = x.ContactPhoneNumber,
                    PhoneType = x.ContactPhoneType,

                }).ToList();
            return items;
        }
        // Delete a contact based on a provided ID
        public bool Delete(int id)
        {
            var contactToDelete = DatabaseManager.Instance.Contact.Where(x => x.ContactId == id);
            if(contactToDelete!=null)
            {
                DatabaseManager.Instance.Contact.RemoveRange(contactToDelete);
                DatabaseManager.Instance.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(ContactModel contactModel)
        {
            var dbContactModel = ToDbModel(contactModel);
            var contactToUpdate = DatabaseManager.Instance.Contact.Find(contactModel.Id);
            if (contactToUpdate != null)
            {
                DatabaseManager.Instance.Entry(contactToUpdate).CurrentValues.SetValues(dbContactModel);
                DatabaseManager.Instance.SaveChanges();
                return true;
            }
            return false;

            //if(contactToUpdate != null)
            //{
            //    var contactToUpdate1 = DatabaseManager.Instance.Contact.Attach(contactToUpdate);
            //    contactToUpdate1.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //    DatabaseManager.Instance.SaveChanges();
            //    return true;

            //}
            //return false;

        }
    }
}
