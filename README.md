# exception-file-reader

Create a simple file reader that will display the contents of a file. You'll be able to select the file using the OpenFileDialog control. Add code to handle all of the possible exceptions for the file activity your code will be performing. Your reader should be able to throw an error to test your code. 



Your simple file reader should have the following functionality.



Include a menu item that allows the user to exit the program. 

Include a menu item that allows the user to select a file for display using the OpenFileDialog control. 

Display the contents of a file in a RichTextBox control. 

Display the name of the file and the file size on a StatusBar. 

Include a menu item that allows the user to clear the RichTextBox control content and StatusBar content. 

Use the ReadAllText method of the File class (requires System.IO assembly) to read from a file. 

Include a try/catch exception-handling block that includes catch blocks for all exceptions that might be raised by the ReadAllText method. 

Include an additional catch block that handles Exception exception. 

Each catch block will call a private method to handle the exception by passing the exception to the private method, displaying the Message in a MessageBox with an appropriate MessageBox caption, and write the StackTrace to the Console. 

Add a main menu item called Exceptions that allows you to list all of the handled exceptions. Make each of these menu items a checkbox. Make the first entry "None" to indicate that you do not want to force an exception. 

When any item on the Exceptions menu is selected other than "None," throw that error when attempting to open the file. 

The Exceptions menu item "None" should be checked by default. When other menu items are selected, only the selected menu item should be checked; all others should then be unchecked. 

Below are a few hints.



You'll need to include the System.IO assembly in your project for File, Path, and most of the IO exceptions. 

You'll need to include the System.Security assembly in your project for at least one of the exceptions. 

You'll have to arrange the catch exceptions in an order from specific to general to prevent masking any of the catch blocks. 

Use the ShowDialog method of the OpenFileDialog control. 

Use the ShowDialog DialogResult return value to determine if a file was selected. 

Use the Text property of the RichTextBox control to display the text. 

Use the TextLength property of the RichTextBox control to get the size of the text. 

Use the Clear method of the RichTextBox control to clear the displayed text. 

Use the GetFileName method of the Path class to extract only the file name from a full path string to display in the StatusStrip. 

Do an Internet search for "C# MSDN File ReadAllText" to determine the exceptions you'll need to include. You should make sure that on the MSDN (Microsoft Developer Network) web page you select an appropriate version from the Other Versions dropdown at the top of the MSDN page. 

For the Exceptions menu, you may want to investigate the DropDownItems collection of the Exceptions ToolStripMenuItem that allows you to add menu items using an Items Collection Editor. By using DropDownItems, you will be able to use a for loop to iterate through all of the DropDownItems of the Exceptions menu item. 

Save your project and test it to make sure it works. Your source code should have no errors or warnings.



