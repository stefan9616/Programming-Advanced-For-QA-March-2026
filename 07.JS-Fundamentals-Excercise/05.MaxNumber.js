function solve (arr){

    let topIntegers = [];

    for (let i = 0; i < arr.length; i++) {

        let currentNumber = arr[i];
        let isTop = true;

        for (let j = i + 1; j < arr.length; j++) {
            let rightNumber = arr[j];

            if(rightNumber >= currentNumber){
                isTop = false;
                break;
            }
        }
          if(isTop){
                topIntegers.push(currentNumber)
            }
    }
        console.log(topIntegers.join(' '));

}
solve([1, 4, 3, 2] )