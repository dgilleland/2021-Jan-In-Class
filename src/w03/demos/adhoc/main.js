// Explore functions
const add = function(first, second) {
    console.log('The first parameter is ', first);
    console.log('The second parameter is ', second);
    return first + second;
}

// In JavaScript, we can add "event listeners" to respond to actions a user might take in our page (like clicking on something).
// This is a simple function that takes in one item and outputs it to the console
const listenToClick = function(evt) {
    console.log(evt);
    evt.preventDefault(); // Will stop the default behaviour of the event
    alert('NO! You cannot go to ' + evt.target.href);
}

// Hook up my hyperlinks so that my 'listenToClick' function will be called when the user clicks the hyperlink.
// 1) Find the element I want to respond to
var link = document.getElementById('first');
// 2) Add an event listener for the 'click' event
link.addEventListener('click', listenToClick);

// Listen for another item
link = document.querySelector('a#second');
link.addEventListener('click', listenToClick);
