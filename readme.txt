=========================================================================
							GUIDGEN
=========================================================================

KOMPILERING
-------------------------------------------------------------------------
  	* Öppna kommandoprompt som administratör
		- Ställ dig i samma mapp som guid.cs
		- Kör följande kommando: 
    		%WINDIR%\Microsoft.NET\Framework\v2.0.50727\csc.exe guid.cs 
	* Kopiera sedan filen som kompilerats, guid.exe, till: 
		%WINDIR%\System32\
-------------------------------------------------------------------------
				
ANVÄNDNING				
-------------------------------------------------------------------------
	* Sedan kan man ifrån kommandoprompten generera nya guidar genom att 
		använda följande kommandon:
		guid
			> Ger följande resultat: 
				New GUID
				====================================
				429bbba9-ad73-4374-abd2-4dc6e8f6da87
				
		guid /[count] --> Där count är en integer
			> Ger följande resultat: 
				New GUID's
				====================================
				1a07ca6a-99ee-4e88-a816-c641ed735e71
				90358a6b-0c2d-44b0-9746-717bd8dcd14a
				
		guid -[count] --> Där count är en integer
			> Ger följande resultat: 
				New GUID's
				====================================
				1a07ca6a-99ee-4e88-a816-c641ed735e71
				90358a6b-0c2d-44b0-9746-717bd8dcd14a
		guid ?
			> Ger en förteckning på alla kommandon
-------------------------------------------------------------------------
