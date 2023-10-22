# Showcase of Programs

## How to use:
You can either run the application in Visual Studio, or open the executable file: Project 1\bin\Debug\Project 1.exe
***
### Purpose:
As students take a programming course, they learn to create programs from scratch, and as they progress through the chapters of the books, they learn more intricate code and ways of going about creating the programs. As they learn, they will have to look at past programs, or look in the book for examples of code in order to achieve something they are trying to create. The student may like to have a program that they can use as a
reference for different kinds of scenarios. This is why I created my application called “Showcase of Programs”. I wanted to create a program that I could personally get a lot of use out of, as well as anyone who is learning C#. 
***
### Information:
The program has 21 separate programs: one from each chapter of the books (14 chapters from the first book, and 7 from the second book). Everything in this project was created from scratch (with the exception of database files, and a few other resource files), and there were some modifications throughout the programs.

The main Form is the heart of the project, as that is where the user can access all of the other programs, as well as the table of contents (another way of opening the chapter programs). It has two ComboBoxes: one to choose the book, and the other to choose the chapter. When a book is selected from the ComboBox, it updates the chapters ComboBox to show the chapters for the selected book. When a chapter is selected, it shows the name of the chapter program as well as a description of the program in a Label, and activates the view button. When the user clicks the view button after selecting a book and chapter, it loads the according program.

The table of contents Form is a simplified way of showing the books and chapters. It has one ComboBox from which you choose the book, and once a book is chosen, it displays a list of the chapter programs inside of Labels, showing only the chapter title and the program name. The user simply hovers over a chapter Label and is able to click it to load the program (the Labels also change in appearance when hovered over and clicked).

All other Forms are unique in the fact that they all do something different / have a different end result, so I won’t go into specific detail for each chapter program. However, there are a few features that all Forms share in common. Every Form has a MenuStrip, from which you can close the Form, and view the code for that specific Form (the code is viewed as a picture inside a new Form). There is also a Method that is used in every Form, which changes the mouse Cursor to display as a hand when hovering over specific Controls.
***
### Overall content:
33 Forms, 4 databases, 4 text files, images (PNG), and 6 Class files (seperate from the 33 Form Classes)
***
### References, Credits, & Acknowledgements:
* Book 1 - Starting Out With Visual C# (Fifth Edition) by Tony Gaddis
* Book 2 - Advanced Visual C# (Fifth Edition) by Tony Gaddis
* https://stackoverflow.com/questions/35146335/how-can-i-align-text-for-combobox-in-winforms-in-winforms
* https://stackoverflow.com/questions/34264071/change-cursor-on-mouse-overfor-all-controls-and-their-childs
* https://stackoverflow.com/questions/14899422/how-to-navigate-a-few-folders-up

**My Professor helped greatly throughout the project!**
