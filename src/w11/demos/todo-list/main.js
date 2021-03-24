/*
    Example of how each todo item needs to structured (DOM fragment)
    <div>
        <input type="checkbox" />
        <label for="todo-1" contenteditable>Todo 1</label>
    </div>
*/

let todoCount = 0;

const appendToDo = function(evt) {
    evt.preventDefault(); // sometimes this is good to do right at the start

    // 0) Create local variables
    // a reference to the element in the DOM that we want to add to
    let todoList = document.querySelector('.todo-list');
    // variables for creating the DOM fragment
    let div, todoText, label, checkbox, labelText;
    todoText = evt.target.elements['todo-item'].value;
    
    // 1) check for empty input value; use "dummy text" if empty
    if (todoText == '') {
        todoText = 'Todo ' + (todoCount + 1);
    }

    // 2) create the required nodes to build the DOM fragment
    div = document.createElement('div');
    checkbox = document.createElement('input');
    label = document.createElement('label');
    labelText = document.createTextNode(todoText); // Create a text node with our todo text.
    
    // 3) set the required attributes
    checkbox.setAttribute('type', 'checkbox'); // <input type='checkbox' />
    label.setAttribute('for', 'todo-' + (todoCount + 1)); // <label for='todo-1'
    label.setAttribute('contenteditable', ''); // <label ...   contenteditable

    // 4) build the DOM fragment (assemble the parts)
    label.appendChild(labelText); // put the text inside: <label ..>text</label>
    console.log('My label element:', label);
    div.appendChild(checkbox); // put the checkbox inside the div at the end
    div.appendChild(label); // put the label inside the div at the end
    console.log('My constructed div:', div);

    // 5) add the DOM fragment to the document (append to the div)
    // My todoList variable references an element that is already part of the
    // webpage. I am adding my in-memory <div> that I constructed to this DOM element.
    todoList.appendChild(div); // add to the end

    // 6) increase the count (tracking how many todo-items I have)
    // 7) clear the input textbox
    evt.target.reset();
}

document.querySelector('form')
        .addEventListener('submit', appendToDo);
