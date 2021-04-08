// Setup an asynchronous function to request the marks
// An asynchronous function is also known as a "promise"
const loadMarks = async function() {
    const url = 'marks.json';
    // Call the fetch() method to request data
    const response = await fetch(url);
    return response.json(); // parse the response body as JSON
}

// Separate function that will output the results to
// the console window
const dumpData = function(data) {
    console.log('results: ', data);
}


// Invoke the function
loadMarks()
    .then(dumpData);
