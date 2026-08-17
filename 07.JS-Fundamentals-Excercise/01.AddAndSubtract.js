
function solve(arr){
    
   let oldSum = 0;
   let newSum = 0;

   for (let i = 0; i < arr.length; i++) {

    let currentNumber = arr[i];
    let newNumber = 0;


    if(currentNumber % 2 == 0){
        newNumber = currentNumber + i;
        arr[i] = newNumber;
    }
    else{
        newNumber = currentNumber - i;
        arr[i] = newNumber;
    }
    oldSum += currentNumber;
    newSum += newNumber;
    
   }

   console.log(arr);
   console.log(oldSum);
   console.log(newSum);

}
