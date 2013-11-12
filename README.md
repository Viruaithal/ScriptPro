================================================
       Plugin of the Month, November 2010
Brought to you by the Autodesk Developer Network
================================================
-------------
ScriptPro 2.0
-------------

Description
-----------
ScriptPro 2.0 is a batch processing utility that allows you to apply
a set of commands to multiple drawings. Simply specify a script file
that contains the commands you want to run on a single drawing, and
then use ScriptPro 2.0 to apply that script to as many drawings as
you like. ScriptPro 2.0 will handle opening and closing each drawing
for you. ScriptPro 2.0 takes AutoCAD scripting to a new level with
an easy-to-use interface, logging, reusable project files and robust
error recovery so your processing continues even when AutoCAD can't.

This version of ScriptPro is a ground-up rewrite of this highly
popular utility for AutoCAD. It has been redeveloped with the key
feature of being usable on 64-bit systems, and is now being provided
with full source code for others to use and extend.

System Requirements
-------------------
This application has been tested with AutoCAD 2008 onwards. It will
use the version of AutoCAD most recently used on the system. To
select a particular version of AutoCAD for use with the tool, simply
start and close that version prior to using it.

A pre-built version of the application has been provided which should
work on 32- and 64-bit Windows systems. The application requires the
.NET Framework 3.5 or above.

The application has not been tested with all AutoCAD-based products,
but should work (see "Feedback", below, otherwise).

The source code has been provided as a Visual Studio 2008 project
containing C# code (not required to run the tool).

This application makes use of "Microsoft Ribbon for WPF October 2010".
This only needs to be installed if you wish to work with the source
project:
http://www.microsoft.com/downloads/en/details.aspx?FamilyID=2bfc3187-74aa-4154-a670-76ef8bc2a0b4

Installation
------------
Copy the contents of the "bin" folder (the main application file,
"ScriptPro.exe" and its supporting DLLs, "DrawingListUC.dll",
"Microsoft.Windows.Shell.dll" and "RibbonControlsLibrary.dll")
to the same location on your local system. Optionally copy this
ReadMe to the same folder or the folder above.

Usage
-----
ScriptPro 2.0 is a batch-processing tool that will run an AutoCAD
script on each drawing in a list of drawing files. Before you begin
using ScriptPro 2.0, you should have a specific task in mind. 

It can be as simple or as complex as you like. Once you have decided
on your task and have written a script to handle it, you decide which
drawings you would like to run the script with.

In the ScriptPro 2.0 Project Editor, you can specify the script file
to use and select the drawings to apply the script to. This
information can be saved as a ScriptPro 2.0 project file. 

While running a project, ScriptPro 2.0 opens each drawing in sequence
and runs the associated script file. 

The following topics outline each of the steps for creating and
running a ScriptPro 2.0 project.

Starting ScriptPro

ScriptPro 2.0 is a stand-alone application that runs independently of
AutoCAD. To simplify running the tool, you can create a shortcut to
ScriptPro.exe on your desktop. Otherwise simply run the executable
directly from Windows Explorer or a command-prompt window.

ScriptPro 2.0 has a ribbon UI. The ribbon has a number of different
groups. They are "List", "Drawing Files", "Run", "Stop", "Options"
and "Help".

List:

"New"      - Creates a new ScriptPro 2.0 project.
"Load"     - Loads an existing ScriptPro 2.0 project.
"Save"     - Saves the current ScriptPro 2.0 project.
"Save As"  - Saves the current project to another location.
"Load SCP Project"
           - Reads the specified ScriptPro (SCP) project file.

Drawing Files:

"Add"      - Adds drawing files (DWG & DXF) to the current project.
"Add From Folder"
           - Adds drawing files (DWG & DXF) from a selected folder.
            to the current project
"Remove"   - Removes the selected files from the current project.
"Check/Uncheck"
           - Allows drawing files to be skipped during processing.

Run:

"Checked"  - Runs the selected script on all the checked drawing
             files in the current project.
"Selected" - Runs the selected script on all the selected drawing
             files in the current project.
"Failed"   - Re-runs the selected script on all the drawing files
             which previously failed to execute.

Stop:

"Stop"     - Stops the processing of drawings.

Options:

"Settings" - Shows the "Options" dialog box which allows you to
             specify various options such as the time-out period,
             log file path and initial script.

Help:

"Help"     - Shows this ReadMe.txt file, if either placed in the
             same folder as ScriptPro.exe or the parent folder.

The "Options" dialog box contains a number of project-related
settings:

"Process timeout per drawing in seconds"

A timeout period indicating how long AutoCAD is inactive before
ScriptPro 2.0 aborts processing on the current drawing and moves
on to the next drawing in the list. The time-out period is specified
in seconds. If you are processing very large drawings, you may need
to increase the time-out period to allow AutoCAD enough time to open
these drawings. 

"Restart AutoCAD after _ drawings"

This indicates the number of drawings to process prior to restarting
AutoCAD. Processing multiple drawings in the same AutoCAD session
reduces the time needed to process them - as the application does not
need to be restarted - but typically leads to a gradual increase in
memory consumption. This option tells ScriptPro 2.0 to restart
AutoCAD after processing a certain number of drawings, resetting the
memory needed by the AutoCAD process.

"AutoCAD startup script file"

A script to be executed once when starting a new AutoCAD session.
This can be used to load required LISP, ObjectARX, .NET or VBA
applications, for instance.

"Process log folder"

The location in which logs will be created. Each log will be named
using the format "SPlog_date_hour_min_seconds.log" (e.g.
SPlog_20_14_23_49.log) while running unsaved drawing list. In case of running 
drawing list, the name of log file will include the drawing list name 
with date time. A detailed log containing the text from
AutoCAD's command-line will also be created using the format
"SPlog_Detail_log_date_hour_min_seconds.log" (for unsaved drawing list)
and "Drawinglistname_Detail_log_date_hour_min_seconds.log" .

"Create image before closing the drawing file"

Causes a screenshot to be captured of the AutoCAD application window,
whether for all processed drawings or only the ones that have failed.

"Select DWG/DXF files in sub directories"

Causes the "Add From Folder" command to search sub-folders when
populating the list of drawings to process.

"Run the tool in diagnostic mode"

Causes processing to stop just before closing each drawing for the
user to verify the state of the drawing file. There is no timeout
during this mode of running.   

"Delay during process (Seconds)"

Delay setting which enables the user to slow down the tool, which in turns
gives enough time to AutoCAD to respond to the tools commands

"AutoCAD exe path to use"

This option allows the selection of particular AutoCAD version to be 
used with the tool. If no path is given, tool will use most recently 
used AutoCAD version on the system. 

"Run script without opening drawing file"
Causes the script to run on empty/dummy document. Use this option when script file 
has commands to open and close the drawing. This option is helpful for commands like
"Recover" which requires the script open the file. The Drawing list selected in the UI
is used to resolve the keywords in run time. This below example shows the script for
performing batch recover.

Example 1: 
QAFLAGS 31
_RECOVER
"<acet:cfullfileName>" 
_SAVEAS
2007(LT2007)
"<acet:cFolderName>\<acet:cBaseName>_RECOVED.dwg"
close

 
Command Line Access

To run a series of ScriptPro 2.0 projects from a DOS batch file,
you can use the ScriptPro command line interface:

<install dir>\ScriptPro <project name> "run"

For example:

C:\\ScriptPro 2.0\\ScriptPro.exe "c:\\TestProject.bpl" "run"

You can also use "exit" at the end to make silent exit of ScriptPro after 
processing the drawing list.

For example:

C:\\ScriptPro 2.0\\ScriptPro.exe "c:\\TestProject.bpl" "run" "exit"

ScriptPro Keywords

Keywords can be used to specify the current file name and its directory. 
When ScriptPro runs, it will replace each keyword with the correct value 
before processing the script. This is done for each drawing file after 
it has been opened so that the keywords are always replaced with the correct 
values from the current drawing.

<acet:cFolderName>	Specifies the drawing file folder name (directory name).
<acet:cBaseName>	Specifies the base file name without a directory or extension.
<acet:cExtension>	Specifies the extension for the drawing file (.dwg, .dwt, or .dxf)
<acet:cFileName>	Specifies the base name with the extension. 
					This will have the same value as the DWGNAME system variable.
<acet:cFullFileName>	Specifies the full file name with path and extension.

Call Script Files

AutoCAD terminates the current script when a SCRIPT command is invoked. 
If you wish to call another script from the current one and continue processing from the 
current script once the called script process has completed, you can use the ScriptPro CALL command.
The CALL command prompts for the script file to be called.

For example:
zoom e
call save.scr

ScriptPro preprocesses scripts before running them. During this process, 
it finds all instances of CALL and replaces them with the actual script 
code from the called script. The resulting script file contains all the 
code from the original script and all the code from the called scripts. 
This file is placed in the temporary directory and is used when running the project.

Creating Scripts for ScriptPro

A script is a series of AutoCAD commands in a text file that can be
used to carry out a task. With scripts, you can run several commands
in succession. You create script files outside AutoCAD, using a text
editor (such as Microsoft Windows Notepad) or a word processor (such
as Microsoft Word) that saves the file in ASCII format. The file
extension must be .scr. All references to long file names that
contain embedded spaces must be enclosed in double quotes. For
example, to insert the drawing c:\My Project Files\sink.dwg from a
script, you must use the following syntax:

-insert "c:\My Project Files\sink.dwg"

Script files can contain comments. Any line that begins with a
semicolon (;) is considered a comment, and AutoCAD ignores the line
while processing the script file. For information about creating
scripts, see the Customization Guide.

When putting together a script for use with ScriptPro 2.0, you need
to consider the actions you want performed on the drawing. ScriptPro
2.0 will handle opening the drawing file and exiting the file once
processing is complete. ScriptPro 2.0 will not save the drawing
automatically. If you want the drawing saved, you must put that
into your script.

ScriptPro 2.0 preprocesses scripts before running them. During this
process, it finds all instances of CALL and replaces them with the
actual script code from the called script. The resulting script file
contains all the code from the original script and all the code from
the called scripts. This file is placed in the temporary directory
and is used when running the project.

ScriptPro 2.0 comes with some sample files to help you get started.
The files are contained in the "Samples" sub-folder.

Uninstallation
--------------
Delete the "ScriptPro.exe" and its supporting dlls,
"DrawingListUC.dll", "Microsoft.Windows.Shell.dll" and 
"RibbonControlsLibrary.dll" from the location to which the files
were originally copied.

Known Issues
------------


Author
------
This plugin was written by Virupaksha Aithal with input from Kean
Walmsley.

Acknowledgements
----------------
The icons used for this application were downloaded from FatCow:
http://www.fatcow.com/free-icons

Further Reading
---------------
For more information on developing with AutoCAD, please visit the
AutoCAD Developer Center at http://www.autodesk.com/developautocad

Feedback
--------
Email us at labs.plugins@autodesk.com with feedback or requests for
enhancements.

Release History
---------------

2.0    Original release
2.0.1  A delay setting is added in options dialog so that users can 
       have control over speed of the ScriptPro tool. 
       An options is provided (in options dialog) in which 
       user can specify the AutoCAD application path to be used 
       by ScriptPro tool.
2.0.2  Keywords capability is added.
       Silent exit capability is added for running ScriptPro through DOS batch file. 
       An options is provided (in options dialog) in which
       ability to run the script before opening drawing file is added – 
       required for recovery kind of commands. This can be used  along 
       with Keywords effectively.
2.0.3  Added support to accoreconsole.exe 

(C) Copyright 2010 by Autodesk, Inc. 

Permission to use, copy, modify, and distribute this software in
object code form for any purpose and without fee is hereby granted, 
provided that the above copyright notice appears in all copies and 
that both that copyright notice and the limited warranty and
restricted rights notice below appear in all supporting 
documentation.

AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS. 
AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC. 
DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
UNINTERRUPTED OR ERROR FREE.
