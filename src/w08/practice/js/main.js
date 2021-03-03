// 0) Some "global" variables
const imagePaths = ['images/mountain1.jpg', 'images/mountain2.jpg', 'images/mountain3.jpg'];
let currentImgIndex = 0;

const setImageSrc = function(srcPath) {
    // Use a fairly specific "query path" to reference the image
    let img = document.querySelector('.carousel img');
    img.src = srcPath;
}

const imageCarousel = function(evt) {
    let myButton = evt.target;
    if(myButton.classList.contains('control')) {
        if(myButton.classList.contains('prev')) {
            currentImgIndex--; // subtract one
        } else { // presume that it contains 'next'
            currentImgIndex++; // add one
        }
        setImageSrc(imagePaths[currentImgIndex]);
    }
    // diagnostics
    console.log(currentImgIndex);
}

// Final page setup
// Hook up the event listener
document.querySelector('.carousel')
        .addEventListener('click', imageCarousel);
// Setting the first image
setImageSrc(imagePaths[currentImgIndex]);
