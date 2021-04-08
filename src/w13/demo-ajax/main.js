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

    // Using DOM API to create document fragements for the student name
    let h2Tag = document.createElement('h2');
    let text = document.createTextNode(data.Student);
    let header = document.querySelector('header');
    h2Tag.appendChild(text);
    header.appendChild(h2Tag);

    // Displaying all the marks in the <tbody> of my table
    let tbody = document.getElementById('evaluation-items');
    let totalWeight = 0, totalEarned = 0; // some totals
    for(let mark of data.Marks){
        // running calculations
        totalWeight += mark.Weight;
        if(mark.Earned) totalEarned += mark.Earned;
        // Use my <template>'s content as a ready-built document fragment
        let template = document.getElementById('item-row'); // get the template
        let clone = template.content.cloneNode(true); // create a clone of the template content
        // Place my JSON data into the cloned document fragment
        clone.querySelector('[data-id=Name').innerText = mark.Name;
        clone.querySelector('[data-id=Weight').innerText = mark.Weight;
        clone.querySelector('[data-id=Earned').innerText = mark.Earned || '--';
        tbody.appendChild(clone);
    }
    document.getElementById('total-weight').innerText = totalWeight;
    document.getElementById('total-earned').innerText = totalEarned;

    // Loop through the rows
    // Add the row to the table

}


// Invoke the function
loadMarks()
    .then(dumpData);
