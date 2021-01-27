// Practice Solution

var featureLink = document.querySelector('a.feature.link'); // Step 1

// Another common term for our event-handling functions is "callback"
const featureLinkHandler = function (evt) { // Step 2
    let featureImage = document.querySelector('img.feature');
    featureImage.src = evt.target.href;
    featureImage.classList.remove('hidden');
    evt.preventDefault(); // Last Step - stopping the default behaviour of anchor tag 
}

featureLink.addEventListener('click', featureLinkHandler); // Step 3
//                                   \callback function/
