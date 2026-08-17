function parking(array){

let parkingCars = [];

for (const carInfo of array) {
    let direction = carInfo.split(', ')[0];
    let carNumber = carInfo.split(', ')[1];

    if(direction === 'IN'){

        if(!parkingCars.includes(carNumber)){
            parkingCars.push(carNumber);
        }
    }

    else if(direction === 'OUT'){

        let carIndex = parkingCars.indexOf(carNumber);
        if(carIndex != -1){
            parkingCars.splice(carIndex, 1);
        }
    }
}

if(parkingCars.length === 0){
        console.log("Parking Lot is Empty");
        
    }
else{

    for (const carNumber of parkingCars.sort()) {
        console.log(carNumber)
    }
    
}
}
parking(['IN, CA2844AA',
'IN, CA1234TA',
'OUT, CA2844AA',
'IN, CA9999TT',
'IN, CA2866HI',
'OUT, CA1234TA',
'IN, CA2844AA',
'OUT, CA2866HI',
'IN, CA9876HH',
'IN, CA2822UU']

)