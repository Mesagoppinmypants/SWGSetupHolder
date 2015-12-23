;@author: Iosnowore

;Include Modern UI

  !include "MUI2.nsh"

;--------------------------------
;General

  ;Name and file
  Name "SWG Trooper Setup Organizer"
  OutFile "TrooperOrganizerInstaller.exe"

  ;Default installation folder
  InstallDir "$PROGRAMFILES\Trooper Setup Organizer"

  ;Request application privileges for Windows Vista
  RequestExecutionLevel user

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING
  !define MUI_ICON "256.ico"

;--------------------------------
;Pages

  ;!insertmacro MUI_PAGE_LICENSE ""
  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
  
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  
;--------------------------------
;Languages
 
  !insertmacro MUI_LANGUAGE "English"

;--------------------------------
;Installer Sections

Section "Trooper Setup Organizer" SecDummy

  SetOutPath "$INSTDIR"
  
  ;ADD YOUR OWN FILES HERE...
  File "TrooperSetupOrganizer.exe"
  
  ;Create uninstaller
  WriteUninstaller "$INSTDIR\Uninstall.exe"

SectionEnd

Section "Desktop Shortcut" DeskShort
	CreateShortCut "$DESKTOP\Trooper Setup Organizer.lnk" "$INSTDIR\TrooperSetupOrganizer.exe"
SectionEnd

;--------------------------------
;Uninstaller Section

Section "Uninstall"

  ;ADD YOUR OWN FILES HERE...

  RMDir "$INSTDIR"
  Delete "$DESKTOP\Trooper Setup Organizer.lnk"


SectionEnd