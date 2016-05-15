# Try-Again

This project is a plugin for Notepad++ which converts Kramdown syntax into HTML.

# How to

1. Build the project.
2. Modify KramdownConverter/CopyPluginToNpp-Try-Again.bat with your path to Notepad++ plugin folder. 
3. Run KramdownConverter/CopyPluginToNpp-Try-Again.bat as an Administrator. It will add the necessary dll to Notepad++'s Plugins folder.
4. Open Notepad++ and create a new file. Go to the menu and select Plugins -> NppManagedPluginDemo -> Convert Kramdown to HTML. All the content written in the file will be converted to HTML and displayed in a separate screen.

# Limitations

Only the basics of Kramdown syntax were added (such as paragraph, headers, lists etc) so the plugin is restricted to these ones.
For adding other syntax rules, modify KramdownConverter/NppManagedPluginDemo/KramdownSyntaxRules. (The already implemented rules can be found here as well)