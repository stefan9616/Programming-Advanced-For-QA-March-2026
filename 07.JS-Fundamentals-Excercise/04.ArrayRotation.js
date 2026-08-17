function solve (arr, number){

    for (let i = 0; i < number; i++) {
        let firstnumber = arr.shift(arr[0]);
        arr.push(firstnumber);

    }
    console.log(arr.join(" "));
    

}

solve([51, 47, 32, 61, 21], 2)