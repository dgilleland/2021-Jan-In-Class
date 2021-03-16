const addDots = function() {
    let myOutput = document.getElementById('dots');
    myOutput.innerText += '.';
}

// Start an interval
let cancellationRef = setInterval(addDots, 1250);

// Add an event listener to the button that will stop the interval.
document.querySelector('button')
        .addEventListener('click', function(evt) {
            if(cancellationRef) {
                clearInterval(cancellationRef);
                cancellationRef = 0;
            }
        })