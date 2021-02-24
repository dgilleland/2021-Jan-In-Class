let selectedWord = 0; // Start with the first word

const nextWord = function() {
    let wordList = document.querySelectorAll('li');
    // TODO: Return the item at the selectedWord index, and also increment the index number.
    let selected = wordList[selectedWord];
    selectedWord++; // Increment my index variable
    if(selectedWord >= wordList.length) {
        // Reset to the start
        selectedWord = 0;
    }
    return selected.innerText;
}

const fillGameboard = function() {
    // Grab the next word in the list
    let theWord = nextWord();
    // Replace the .innerHTML of the div.gameboard with a bunch of divs, one for each letter in the word we grabbed.
    let newGameboard = "";
    console.log(theWord.length);
    for(var index = 0; index < theWord.length; index++) {
        newGameboard += '<div>' + theWord[index] + '</div>';
    }
    document.querySelector('.gameboard').innerHTML = newGameboard;
}

// Add an event handler for the textbox input.
const guessWord = function(evt) {
    // grab the text in the textbox
    let letter = evt.target.value;
    // loop through the divs in the gameboard to find matches and apply a css class to the div
    let letterDivs = document.querySelectorAll('.gameboard div');
    for(var index = 0; index < letterDivs.length; index++)
    {
        // check for a match
        if(letter.toUpperCase() === letterDivs[index].innerText.toUpperCase()) {
            letterDivs[index].classList.add('reveal');
        }
    }
}

// Hook up the event handler to the change event.
document.querySelector('input')
        .addEventListener('change', guessWord);

document.querySelector('form')
        .addEventListener('submit', function(evt) {
            evt.preventDefault();
        })

// Start the game with the first word to guess.
fillGameboard();