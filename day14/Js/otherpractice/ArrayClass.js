class Library {
          constructor() {
            this.books = [];
          }
        
          addBook(book) {
            this.books.push(book);
            console.log(`${book} added to the library.`);
          }
        
          removeBook(book) {
            this.books = this.books.filter(b => b !== book);
            console.log(`${book} removed from the library.`);
          }
        
          listBooks() {
            console.log("Books in library:", this.books.join(", "));
          }
        }
        
        // Example usage:
        const myLibrary = new Library();
        myLibrary.addBook("JavaScript: The Good Parts");
        myLibrary.addBook("Eloquent JavaScript");
        myLibrary.listBooks();
        myLibrary.removeBook("JavaScript: The Good Parts");
        myLibrary.listBooks();
        