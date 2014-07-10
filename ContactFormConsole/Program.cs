using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactFormConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           //Always First - Create a connnection to our database
            SimoneEntities db = new SimoneEntities();

                        
            //Add a new Record to our Contact Form Database
           //Create a new contact form object
                   
            ContactForm add = new ContactForm();
           //fill out our new object
            add.Name = "Simone";
            add.Email = "enomiswebit@gmail.com";
            add.CompanyName = "SeedPaths";
            add.Comments = "You guys are the best";
        
            //add our object to the database
            db.ContactForms.Add(add);

            //save it
            db.SaveChanges();

            //retrieve a record from our database
            var contact = db.ContactForms.Find(1);

            //update a name
            contact.Name = " Billy Joel";

            //save changes
            db.SaveChanges();

            //delete a record from our database
            db.ContactForms.Remove(contact);

            //save changes
            db.SaveChanges();
        
        
        }

    }
}
