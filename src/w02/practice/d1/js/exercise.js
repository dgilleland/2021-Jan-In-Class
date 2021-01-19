// These illustrate that the code in our javascript file runs automatically when it is loaded by the browser.

// There are functions built into JavaScript, such as alert(text)
// alert('Welcome'); // TODO: Comment out this line of code when it get anoying

// Here we declare our own custom function to wrap some text inside of a <strong></strong> tag.
const strong = function (text) {
    return '<strong>' + text + '</strong>';
}

// This function will replace the .innerHTML for an element selected from the page.
const replaceHTML = function (selector, replacement) {
    var element = document.querySelector(selector);
    element.innerHTML = replacement;
}

// Create a function that will wrap text in a blockquote. <blockquote></blockquote>
const blockquote = function (text) {
    return '<blockquote>' + text + '</blockquote>';
}
