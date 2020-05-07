using System;
using System.Collections.Generic;
using System.Text;
using ContactDB;

namespace ContactRepository
{
    public class DatabaseManager
    {
        private static readonly ContactsContext _entities;
         static DatabaseManager()
        {
            _entities = new ContactsContext();
        }
        // return an accessor to the database
        public static ContactsContext Instance
        {
            get { return _entities; }
        }
    }
}
