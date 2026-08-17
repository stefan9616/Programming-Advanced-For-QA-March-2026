function solve (words){

    let finalWords = [];
    let wordToLower = words.toLowerCase();
    let splittedWords = wordToLower.split(" ");
    let occurences = 0;

    for (let i = 0; i < splittedWords.length; i++) {
        occurences = 0;
        let currentWord = splittedWords[i];
        occurences++;

        for (let j = 0; j < splittedWords.length; j++) {
            let nextWord = splittedWords[j];

            if(currentWord === nextWord){
                occurences++;
            }
            
        }

        if (occurences % 2 == 0) {
            if(finalWords.includes(currentWord)){
                continue;
            }
            finalWords.push(currentWord) 
        }
    }
    console.log(finalWords.join(" "));
}

solve('Java C# Php PHP Java PhP 3 C# 3 1 5 C#')