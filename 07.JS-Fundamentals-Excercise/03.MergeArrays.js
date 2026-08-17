function solve (arr1, arr2){

    let newArray =[];

    for (let i = 0; i < arr1.length; i++) {
       
        if(i % 2 == 0){
            let arr1Sum = Number(arr1[i]) + Number(arr2[i]);
            newArray.push(arr1Sum); 
        }
        else{
            let arr2Sum = arr1[i] + arr2[i];
            newArray.push(arr2Sum)
        }
    }

    console.log(newArray.join(" - ", newArray));
    
}

solve(['5', '15', '23', '56', '35'],
      ['17', '22', '87', '36', '11']
    )