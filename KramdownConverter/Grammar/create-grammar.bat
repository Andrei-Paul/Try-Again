REM GENERATE CODE
java -jar grammatica-1.6/lib/grammatica-1.6.jar kramdown.grammar --csoutput grammar.cs --cspublic
copy grammar.cs\* ..\NppManagedPluginDemo\KramdownParser

REM ANALYZE GRAMMAR
java -jar grammatica-1.6/lib/grammatica-1.6.jar kramdown.grammar --debug

REM PHARSE SOURCE
java -jar grammatica-1.6/lib/grammatica-1.6.jar kramdown.grammar --parse kramdown.txt

REM PHARSE ARITHMETIC
REM java -jar grammatica-1.6/lib/grammatica-1.6.jar arithmetic.grammar --parse arithmetic.txt

REM pause