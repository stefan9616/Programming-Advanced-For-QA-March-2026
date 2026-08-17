function solve (inputArray){

    let inputWords = inputArray.shift().split(' ');

    let finalWords = {};

    for (const key of inputWords) {
        finalWords[key] = 0;
    }

    for (const currentWord of inputArray) {
        
        if(currentWord in finalWords ){
            finalWords[currentWord]++;
        }
        
    }

    let entries = Object.entries(finalWords);
    entries.sort((a, b) => b[1] - a[1]);

    for (let [word, count] of entries) {
            console.log(`${word} - ${count}`);
    }

}

solve([
'this sentence', 
'In', 'this', 'sentence', 'you', 'have', 'to', 'count', 'the', 'occurrences', 'of', 'the', 'words', 'this', 'and', 'sentence', 'because', 'this', 'is', 'your', 'task'
]
)