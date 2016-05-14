echo %cd% > d:\cacat.txt
IF %USERNAME% EQU ghite GOTO ghite ELSE GOTO rest

:ghite
	copy /B "Demo.dll" "D:\Applications\Notepad++\App\Notepad++\plugins"
	echo first >> d:\cacat.txt
	GOTO end

:rest
	copy /B "Demo.dll" "C:\Program Files (x86)\Notepad++\plugins"
	GOTO end

:end
