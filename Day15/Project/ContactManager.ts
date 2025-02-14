// ContactManager.ts
interface Contact {
          id: number;
          name: string;
          email: string;
          phone: string;
      }
      
      class ContactManager {
          private contacts: Contact[] = [];
      
          addContact(contact: Contact): void {
              this.contacts.push(contact);
              console.log(`Contact with ID ${contact.id} added successfully.`);
          }
      
          viewContacts(): Contact[] {
              return this.contacts;
          }
      
          modifyContact(id: number, updatedContact: Partial<Contact>): void {
              const contactIndex = this.contacts.findIndex(contact => contact.id === id);
              if (contactIndex === -1) {
                  console.error(`Contact with ID ${id} does not exist.`);
                  return;
              }
              this.contacts[contactIndex] = { ...this.contacts[contactIndex], ...updatedContact };
              console.log(`Contact with ID ${id} modified successfully.`);
          }
      
          deleteContact(id: number): void {
              const contactIndex = this.contacts.findIndex(contact => contact.id === id);
              if (contactIndex === -1) {
                  console.error(`Contact with ID ${id} does not exist.`);
                  return;
              }
              this.contacts.splice(contactIndex, 1);
              console.log(`Contact with ID ${id} deleted successfully.`);
          }
      }
      
      // Create an instance of ContactManager
      const contactManager = new ContactManager();
      
      // Add new contacts
      contactManager.addContact({ id: 1, name: 'John Doe', email: 'john@example.com', phone: '123-456-7890' });
      contactManager.addContact({ id: 2, name: 'Jane Smith', email: 'jane@example.com', phone: '098-765-4321' });
      
      // View all contacts
      console.log('All Contacts:', contactManager.viewContacts());
      
      // Modify a contact
      contactManager.modifyContact(1, { name: 'Johnathan Doe', phone: '111-222-3333' });
      
      // View all contacts after modification
      console.log('All Contacts after modification:', contactManager.viewContacts());
      
      // Delete a contact
      contactManager.deleteContact(2);
      
      // View all contacts after deletion
      console.log('All Contacts after deletion:', contactManager.viewContacts());
      
      // Attempt to modify a non-existent contact
      contactManager.modifyContact(3, { name: 'Non-existent Contact' });
      
      // Attempt to delete a non-existent contact
      contactManager.deleteContact(3);*/