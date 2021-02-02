// Refactoring the code to make it "better"
// 1) Turned my function "variable" into a constant
// 2) Improve the "readability" of my code by choosing better names
// 3) Use let instead of var
// 4) Use local variables in functions where available =>> "outside" variable vs. local variable
//    Benefit of "isolation"
// 5) Limit the use of "temporary" global variables =>> "inline" the variable featureLink

const toggleImage = function(evt) {
    let featureImage = document.querySelector('img.feature');
    featureImage.src = evt.target.href;
    featureImage.classList.remove('hidden');

    evt.preventDefault();
}

document.querySelector('a.feature') // formerly as the variable     featureLink
        .addEventListener('click', toggleImage);
