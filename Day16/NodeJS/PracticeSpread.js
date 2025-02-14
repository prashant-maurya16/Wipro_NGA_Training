  
  
  //Combining Two Arrays...


 
  const arr1 = [10,12,14,16];
  console.log("Array 1:",arr1);
  const arr2= [11,13,15];
  console.log("Array 2:",arr2);

  const combiningArray = [...arr1,...arr2];
  console.log("Combined Array is :",combiningArray);


  //Copying AN Array.....


  console.log("Copying One array to anotehr array....")


  const original=[50,60,70,80,100];

  console.log("Original array is :",original);
  const Copied= [...original];

  console.log("Copied array from original array:",Copied);


  //Combining objects....

  console.log("Now...! Combining two objects..."
  );

  const obj1={name:"prashant",age:21};

  console.log("value of obj1:",obj1);
  const obj2={city:"DELHI",country:"India"};
  console.log("value of obj:",obj2);
  const CopyObj={...obj1, ...obj2};
  console.log("value of Copied Object:",CopyObj);


  //Converting a String to an Array

  console.log("Converting a String to an Array");

  const name= "Prashant";
  console.log("My name is :", name);

  const nameArray= [...name];
  console.log("Ater converting String into Array:",nameArray);


  //Passing Multiple Arguments to a Function


  console.log("Passing Multiple Arguments to a Function......");

  function AddNumber(a,b,c)
  {
    return a+b+c;
  }

  const numbers = [5,25,50 ];

  const sum = AddNumber(...numbers);
  console.log("sum of all three number is :",sum);

