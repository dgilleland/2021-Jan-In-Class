# My First Markdown File

Markdown files are just simple text files with the extension of `.md`. Note that I wrapped the ".md" text inside of a pair of back-tick characters. The single-back-tick is used to indicate a small "code snippet" that you would have inside your regular text.

Markdown is designed to help you focus on the content rather than the styling. You can do some minimal styling with different characters. For example, **this phrase is in bold text** because it's wrapped in a pair of double-asterix characters. You can do *italics* with a pair of sing-asterix characters.

You can even add a hyperlink to some site, such as [Google Search](https://google.ca). You do that by using square brackets followed by parenthesis where the text is in the square brackets and the link is in the parenthesis. Like this:

```markdown
[Google Search](https://google.ca)
```

The above sample is a **fence block** for showing multiple lines of code with syntax highlighting.

## Software Design

"Loose coupling" between the areas of Content, Presentation, and Functionality makes for a flexible design that is easy to maintain.

![Good](./images/GoodDesign.png)

"Tight coupling" makes for bad design, because changes in either area can potentially "break" the other areas.

![Bad](./images/BadDesign.png)

## Git and VS Code

If you press the following key combination:

```
[ctrl] + `
```

That will toggle access to the **terminal** in Visual Studio Code. You can use the terminal as a place to enter in git commands.

```
git add .
git commit -m "Demos in class"
git push
```
