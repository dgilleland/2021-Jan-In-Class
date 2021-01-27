// Practice Solution

var featureLink = document.querySelector('a.feature.link'); // Step 1

// Another common term for our event-handling functions is "callback"
// The following lines do two things: 1) creates a constant, 2) declares/defines a function with instructions
// Using a const variable to refer to our function protects it from being changed by other
const featureLinkHandler = function (evt) { // Step 2
    let featureImage = document.querySelector('img.feature');
    featureImage.src = evt.target.href;
    featureImage.classList.remove('hidden');
    evt.preventDefault(); // Last Step - stopping the default behaviour of anchor tag 
}


featureLink.addEventListener('click', featureLinkHandler); // Step 3
//                                   \callback function/
