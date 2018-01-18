# GUIDGEN

## COMPILATION
* Open command prompt as administrator
	* Locate yourself to the same folder as guid.cs
	* Run the following command:
		* %WINDIR%\Microsoft.NET\Framework\v2.0.50727\csc.exe guid.cs 
* Then copy the file compiled, guid.exe, to:
	* %WINDIR%\System32\
	
## USAGE				
* Then you can generate new guides from the command prompt by:
use the following commands:

	* **guid**
		* Provides the following results:
			- New GUID
			- ====================================
			- 429bbba9-ad73-4374-abd2-4dc6e8f6da87

	* **guid /[count]** -> Where count is an integer
		* Provides the following results:
			- New GUID's
			- ====================================
			- 1a07ca6a-99ee-4e88-a816-c641ed735e71
			- 90358a6b-0c2d-44b0-9746-717bd8dcd14a

	* **guid -[count]** -> Where count is an integer
		* Provides the following results:
			- New GUID's
			- ====================================
			- 1a07ca6a-99ee-4e88-a816-c641ed735e71
			- 90358a6b-0c2d-44b0-9746-717bd8dcd14a

	* **guid ?**
		* Provides a list of all commands

