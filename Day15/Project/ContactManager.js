var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
var ContactManager = /** @class */ (function () {
    function ContactManager() {
        this.contacts = [];
    }
    ContactManager.prototype.addContact = function (contact) {
        this.contacts.push(contact);
        console.log("Contact with ID ".concat(contact.id, " added successfully."));
    };
    ContactManager.prototype.viewContacts = function () {
        return this.contacts;
    };
    ContactManager.prototype.modifyContact = function (id, updatedContact) {
        var contactIndex = this.contacts.findIndex(function (contact) { return contact.id === id; });
        if (contactIndex === -1) {
            console.error("Contact with ID ".concat(id, " does not exist."));
            return;
        }
        this.contacts[contactIndex] = __assign(__assign({}, this.contacts[contactIndex]), updatedContact);
        console.log("Contact with ID ".concat(id, " modified successfully."));
    };
    ContactManager.prototype.deleteContact = function (id) {
        var contactIndex = this.contacts.findIndex(function (contact) { return contact.id === id; });
        if (contactIndex === -1) {
            console.error("Contact with ID ".concat(id, " does not exist."));
            return;
        }
        this.contacts.splice(contactIndex, 1);
        console.log("Contact with ID ".concat(id, " deleted successfully."));
    };
    return ContactManager;
}());
// Create an instance of ContactManager
var contactManager = new ContactManager();
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
contactManager.deleteContact(3);
