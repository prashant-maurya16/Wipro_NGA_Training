// Example of rest and spread operator
const summ = (...nums) => nums.reduce((acc, curr) => acc + curr, 0);
console.log(`Sum using rest operator : ${summ(2, 4, 5, 6, 8)}`);
//spread operator
const arr1 = [2, 3, 4];
const arr2 = [5, 6, 8];
const summing = [...arr1, ...arr2]; //  is used to expand the contents of an iterable (arrays , string  ) into individual elements.
console.log("array submittion :", summing);







/*

TRY This.......

combining array , copying an array  , combining objects , passing multiple arguments to a function , converting string to an array

*/