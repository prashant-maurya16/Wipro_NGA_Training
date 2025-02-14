//Inheritance


class Person {
          constructor(name, age) {
            this.name = name;
            this.age = age;
          }
        
          greet() {
            console.log(`Hello, my name is ${this.name} and I am ${this.age} years old.`);
          }
        }
        
       
        const person1 = new Person("Prashant", 20);
        person1.greet();
        
class Student extends Person {
          constructor(name, age, grade) {
            super(name, age);
            this.grade = grade;
          }
        
          study() {
            console.log(`${this.name} is studying in grade ${this.grade}.`);
          }
        }
        
        // Example usage:
        const student1 = new Student("Rahul", 16, "10th");
        student1.greet();
        student1.study();

        