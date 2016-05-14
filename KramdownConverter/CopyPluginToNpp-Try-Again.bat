echo %USERNAME% > D:\cacat.txt
IF "%USERNAME%" == "ghite" (GOTO ghite) ELSE (GOTO rest)
GOTO end

:ghite
	copy /B "D:\Projects\Kaars\Software Development\C#\Try-Again\KramdownConverter\NppManagedPluginDemo\bin\Debug-Andrei\Demo.dll" "C:\Program Files (x86)\Notepad++\plugins"
	GOTO end
:rest
	copy /B "C:\Users\Iulia\Desktop\itec2016\KramdownNppPlugin\KramdownConverter\NppManagedPluginDemo\bin\Debug-Iulia\Demo.dll" "C:\Program Files (x86)\Notepad++\plugins"
	GOTO end

:end
