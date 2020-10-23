# SimpleDatabaseViewer
very lightweight and simple MySQL viewer. One of my first projects in C#. Uses Windows Forms and MySQL.

This tool was made out of necessity, as the place I was working did not have any other tools installed
that allowed me to quickly view tables without downloading a dump file every time I wanted to peek at something.
The viewer is setup so that it can only read, not write, even if the user has permission to make edits. 
Simple replacing every written instance of "MySQL" in the code would allow this program to also connect to a normal
SQL database. This program is pretty much complete, but future version of this will likely be made as more functionality is needed.
-LJE 10/23/20
