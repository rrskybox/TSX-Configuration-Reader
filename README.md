# TSX-Configuration-Reader
Viewer for TheSkyX Profile Configuration Files

TSX Configuration Reader Description

Overview:

TSX Configuration Reader is a simple utility for viewing and searching the contents of any of the *.ini configuration files in TheSkyX, but primarily the Profile configurations.  TSX Profile configuration files can be upwards of 600 lines of configuration parameters that is organized into device definition blocks.  This program parses these files, organizes by device and supports searching based on parameter name subtext.

 

Operation:  

Upon launch, the user selects and opens a Profile *.ini file.  The program parses the file and displays all device names found.  Clicking on the device name expands to the device parameters and their values.

Once a Profile *.ini file is opened, the user can also enter text in the search field and the program will expand and highlight in red any parameter with that text in its label.

Note:  TSX Configuration Reader will parse and display almost any *.ini file, but will fail if duplicate definition block names are encountered.

Commands:

Open – Select a Profile (or other *.ini) file to open.

Search – Search through the Profile parameters for any configuration fields that contain the search text.  Expand and highlight those fields in red.  Using the Enter key after entering text causes the same action.

Collapse – Collapse all expanded device, reset the search text and remove search highlighting.

Requirements:  

TSX Configuration Reader is a Windows Forms executable, written in C#.  The application runs as an uncertified, standalone application under Windows 7, 8 and 10.  The application requires TSX Pro and .NET 4.8+ installed.

Installation:  

Download the TSXConfigurationReader_Exe.zip and open.  Run the "Setup" application.  Upon completion, an application icon will have been added to the start menu under the category "TSXToolkit" with the name “TSX Configuration Reader".  This application can be pinned to the Start if desired. 

Support:  

This application was written as freeware for the public domain and as such is unsupported. The developer wishes you his best and hopes everything works out, but recommends learning C# (it's really not hard and the tools are free from Microsoft) if you find a problem or want to add features.  The source is supplied as a Visual Studio project.
