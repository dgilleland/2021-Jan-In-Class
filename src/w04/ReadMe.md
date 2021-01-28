# Week 4 - Lesson Plan ![Docs](https://img.shields.io/badge/Documentation%20Status-10--40%25%20Rough%20Outline-red?logo=Read%20the%20Docs)

> Review the [**LOGs**](./LOGs.md) for this class.


# If-Else Statements

The If-Else statement follows this grammar:

```js
if(conditionalExpression)
    statementOrStatementBlock
else
    statementOrStatementBlock
```

where the `conditionalExpression` is some expression that will result in a true or false value, and the `statementOrStatementBlock` is either a single instruction/statement or a set of statements inside curly braces (statement block).

## Relational Operators

Relational operators do a comparison between two items (the LH or "Left-Hand side" and the RH or "Right-Hand side"). All relational operations return a result of `true` or `false`.

-   **`==`** — "is equal to" - equality operator
-   **`===`** — "is equal to" - identity operator
-   **`!=`** — "is not equal to" - equality operator
-   **`!===`** — "is not equal to" - identity operator
-   **`>`** — greater than
-   **`<`** — less than
-   **`>=`** — greater than or equal to
-   **`<=`** — less than or equal to

## Logical Operators

Logical Operators do a comparison between boolean values for `&&` and `||` operators. The *unary* operator for "NOT" (`!`) will flip a true into a false and a false into a true.

-   **`&&`** — "AND" operator - both sides must be true to get a true result
-   **`||`** — "OR" operator - only one side needs to be true to get a true result
-   **`!`** &mdash: "NOT" operator - inverts the true to a false and the false to a true

---

## Day 1

- **If-else statement**
  - [ ] Discuss the process of identifying conditions and then forming expressions that yield Boolean results
  - [ ] Review relational and equality operators
  - [ ] Go through decisions_intro example
    - Clicking the image toggles the description display

## Day 2

- **Operators**
  - [ ] Discuss the difference between equality and identity operators
  - [ ] == vs. === and != vs. !==
  - [ ] Revisit decisions_intro example
  - [ ] Have students work through posted decisions exercise for homework

## Day 3

Work through the resize_thumbnails examples, which cover the following:

1. One event handler for multiple elements
2. Reducing unnecessary variables and event propagation and reducing unnecessary adding of event listeners
3. Removing the decision making from the solution and using what is known in the HTML
4. Converting to an anonymous function (and the why and when to do so)
<!-- -->