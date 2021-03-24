/*
    Example of how each todo item needs to structured (DOM fragment)
    <div>
        <input type="checkbox" />
        <label for="todo-1" contenteditable>Todo 1</label>
    </div>
*/

let todoList = document.querySelector('.todo-list');
let todoCount = 0;

const appendToDo = function(evt) {
    evt.preventDefault(); // sometimes this is good to do right at the start
    // variables for creating the DOM fragment
    let div, todoText, label, checkbox, labelText;
    todoText = evt.target.elements['todo-item'].value;
    
    // 1) check for empty input value; use "dummy text" if empty
    // 2) create the required nodes to build the DOM fragment
    // 3) set the required attributes
    // 4) build the DOM fragment (assemble the parts)
    // 5) add the DOM fragment to the document (append to the div)
    // 6) increase the count (tracking how many todo-items I have)
    // 7) clear the input textbox
    evt.target.reset();
}

document.querySelector('form')
        .addEventListener('submit', appendToDo);
