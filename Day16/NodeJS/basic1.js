console.log("Promishes and Async/Awiat");
  //step1.created a function that will return a promish
const fetchData = ()=>
{
          return new Promise((resolve)=>
          {
                    setTimeout(() => {
                              resolve("Your data is Fetched");
                    }, 2000); //2 second delay
          });
};
 

//step2. created a async function to handle the promish
async function getData() {
          
          console.log("Fetching data..........");

          //step3 wait for the promish to resolve usning await
          const result = await fetchData();

          //setp4.  Display the result after the  promish resovled
          console.log(result);
}

//calling  getData function
getData();