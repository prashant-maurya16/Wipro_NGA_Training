/*
          const even1 =  document.getElementById("even")
          
          let i = prompt("Enter a number");

          if (i%2==0)
          {
                    console.log(`${i} is a even number`);

          }
          else{
                    console.log(`${i} is  and odd number`);
          }
*/


function OddEven()
{
          let num = document.getElementById("userInput").value;
          let Result = document.getElementById("result");


          if(num%2==0)
          {
                    Result.innerHTML=`${num} Is a Even Number`;
          }
          else{
                    Result.innerHTML=`${num} Is an Odd Number`;  
          }
}

