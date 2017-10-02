SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.

!t::
ExitApp

!e::
BlockInput, on
LastFile:=""
LastLastFile:=""
Repetitions:=0

	OknoTworzenia := ""
	OknoPacjentow:=""
	Title :=""
	File := ""
	PESEL:=""
	Timout:=0
	
	Click,,,Right
	Send {DOWN 28}{ENTER 2}
	
	While(InStr(OknoTworzenia,"grupa")<1) ;czekamy na okno tworzenia
	{
		WinGetActiveTitle, OknoTworzenia
		Sleep, 100
		if(InStr(OknoTworzenia, "...")>1)
		{
			Send, {ENTER}
			;goto break_outer
		}
		
	}
	
		
	
	
	;MsgBox, Oknotworzenia %OknoTworzenia%
	Send, {ENTER}
	Sleep, 200

	While(InStr(Title, "Writer")<1) ;czekamy na okno writera
	{
		WinGetActiveTitle, Title
		;MsgBox, Title %Title%
		Sleep, 100
		Timout+=1
		if(Timout>20)
		{
			Send, {ENTER} ;dodatkowy enter czasem trzeba
			Sleep, 1000
			Timeout:=0
		}
		
		
	}
	

	NajblizszaSpacja := InStr(Title, " ") ;wyszukanie najbliższej spacji
	Title:= SubStr(Title, 1 , NajblizszaSpacja)  ;wyciagniecie samego wyniku - do spacji
	Title:=RTrim(Title)

	
	
	Sciezka = C:\Temp\%Title%
	WinClose, %Title%
	While(InStr(OknoPacjentow, "acjenci")<1) ;czekamy na okno pacjentow
	{
		WinGetActiveTitle, OknoPacjentow
		;MsgBox, Title %Title%
		Sleep, 100
		if(InStr(OknoPacjentow, "?")>1)
		{
			Send, {RIGHT}{ENTER}
			Sleep, 200
		}
	}
	
BlockInput, off	
	
	;MsgBox, Sciezka %Sciezka%
	Run "C:\Users\Szpital.KARDIO_DL5\Source\Repos\wypisy\rtfapp\bin\Debug\rtfapp.exe" %Sciezka%
	;FileRead, File, %Sciezka%
	;MsgBox, %File%
	;if (File==LastFile) ;drugi raz ten sam plik
	;{
	;	Repetitions:=Repetitions+1
		
	;	if(Repetitions>3)
	;	{
	;		break
	;	}
		
	;}
	;else
	;{
	;	Repetitions:=0
	;}
	
	;LastLastFile:=LastFile
	;LastFile:=File ;pierwsze 1000 znakow do porownania, dla malej optymalizacji
	
	;Run "C:\rtfappexe\rtfapp.exe" %Sciezka%
	
	

	;Send {DOWN}
	;continue
	
	;break_outer:
		;Send, {DOWN}
		;continue


;MsgBox, Zakonczono
