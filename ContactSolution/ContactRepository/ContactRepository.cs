using ContactDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactRepository
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonetype { get; set; }
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
                ContactPhoneType = contactModel.Phonetype,
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
                Phonetype = dbContactModel.ContactPhoneType
            };
            return contactModel;
        }

    }
}
