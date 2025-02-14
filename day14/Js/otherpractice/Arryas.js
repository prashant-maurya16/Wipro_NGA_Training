let numbers = [10, 20, 30, 40, 50];

// Adding elements
numbers.push(60);
console.log("After push:", numbers);

numbers.unshift(5);
console.log("After unshift:", numbers);

// Removing elements
numbers.pop();
console.log("After pop:", numbers);

numbers.shift();
console.log("After shift:", numbers);

// Finding an element
let found = numbers.find(num => num > 25);
console.log("Found number:", found);

// Filtering elements
let filtered = numbers.filter(num => num % 2 === 0);
console.log("Filtered even numbers:", filtered);

// Sorting
numbers.sort((a, b) => a - b);
console.log("Sorted array:", numbers);
