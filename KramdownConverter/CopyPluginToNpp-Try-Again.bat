echo %cd% > d:\cacat.txt
REM IF %USERNAME% EQU ghite GOTO ghite ELSE GOTO rest
REM 
REM :ghite
REM 	copy /B "Demo.dll" "D:\Applications\Notepad++\App\Notepad++\plugins"
REM 	echo first >> d:\cacat.txt
REM 	GOTO end
REM 
REM :rest
	copy /B "D:\Projects\Kaars\Software Development\C#\Try-Again\KramdownConverter\NppManagedPluginDemo\bin\Debug-Andrei\Demo.dll" "C:\Program Files (x86)\Notepad++\plugins"
	GOTO end

:end
