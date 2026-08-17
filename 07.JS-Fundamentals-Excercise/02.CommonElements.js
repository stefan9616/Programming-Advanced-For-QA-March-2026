function commonElements(array, array2){

    let matches = '';

    for (let i = 0; i < array.length; i++) {
    
        let currentElement = array[i];

        for (let j = 0; j < array2.length; j++) {

            let secondCurrentElement = array2[j];

            if(currentElement === secondCurrentElement){
                
                console.log(secondCurrentElement);

            }
            
        }
    }
}
commonElements(['Hey', 'hello', 2, 4, 'Peter', 'e'],
                ['Petar', 10, 'hey', 4, 'hello', '2'])