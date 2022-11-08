using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
   public class BusinessLogicLayer
    {

        //Capa encargada de las validaciones

        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer() 
        {
            //Constructor
            _dataAccessLayer = new DataAccessLayer();
        }

        public Contact SaveContact(Contact contact) 
        {
            if (contact.id == 0)
            {
                _dataAccessLayer.InsertContact(contact);
            }
            //else 
            //{ 
            //    //_dataAccessLayer.UpdateContact
            //}
            return contact;
        }
    }
}
