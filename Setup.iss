; ��� ����������
#define   Name       "Employee Manager"
; ������ ����������
#define   Version    "0.0.1"
; �����-�����������
#define   Publisher  "KLaboratory"
; ���� ����� ������������
#define   URL        "https://vk.com/id180016260"
; ��� ������������ ������
#define   ExeName    "EmployeeManager.exe"


[Setup]
; ���������� ������������� ����������, 
;��������������� ����� Tools -> Generate GUID
AppId={{7243F64E-A2DD-4AB4-938C-EECA69C032B6}

; ������ ����������, ������������ ��� ���������
AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}
AppPublisherURL={#URL}
AppSupportURL={#URL}
AppUpdatesURL={#URL}

; ���� ��������� ��-���������
DefaultDirName={pf}\{#Name}
; ��� ������ � ���� "����"
DefaultGroupName={#Name}

; �������, ���� ����� ������� ��������� setup � ��� ������������ �����
OutputDir="C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\����������"
OutputBaseFileName=release-setup

; ���� ������
SetupIconFile=C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\configusers.ico

; ��������� ������
Compression=lzma
SolidCompression=yes


[Files]

; ����������� ����
Source: "C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\Billing-View\bin\Release\Billing-View.exe"; DestDir: "{app}"; Flags: ignoreversion

; ������������� �������
Source: "C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\Billing-View\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs