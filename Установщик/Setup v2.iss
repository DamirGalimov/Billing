; Имя приложения
#define   Name       "Employee Manager"
; Версия приложения
#define   Version    "0.0.2"
; Фирма-разработчик
#define   Publisher  "KLaboratory"
; Сафт фирмы разработчика
#define   URL        "https://vk.com/id180016260"
; Имя исполняемого модуля
#define   ExeName    "EmployeeManager.exe"


[Setup]
; Уникальный идентификатор приложения, 
;сгенерированный через Tools -> Generate GUID
AppId={{7243F64E-A2DD-4AB4-938C-EECA69C032B6}
ChangesAssociations = yes

; Прочая информация, отображаемая при установке
AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}
AppPublisherURL={#URL}
AppSupportURL={#URL}
AppUpdatesURL={#URL}

; Путь установки по-умолчанию
DefaultDirName={pf}\{#Name}
; Имя группы в меню "Пуск"
DefaultGroupName={#Name}

; Каталог, куда будет записан собранный setup и имя исполняемого файла
OutputDir=C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\Установщик
OutputBaseFileName=test-setup

; Файл иконки
SetupIconFile=C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\configusers.ico

; Параметры сжатия
Compression=lzma
SolidCompression=yes

[Registry]

Root: HKCR; Subkey: ".dat";                             ValueData: "{#Name}";          Flags: uninsdeletevalue; ValueType: string;  ValueName: ""
Root: HKCR; Subkey: "{#Name}";                     ValueData: "Program {#Name}";  Flags: uninsdeletekey;   ValueType: string;  ValueName: ""
Root: HKCR; Subkey: "{#Name}\DefaultIcon";             ValueData: "{app}\{#Name},0";               ValueType: string;  ValueName: ""
Root: HKCR; Subkey: "{#Name}\shell\open\command";  ValueData: """{app}\{#Name}"" ""%1""";  ValueType: string;  ValueName: ""

[Files]

; Исполняемый файл
Source: "C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\Billing-View\bin\Release\Billing-View.exe"; DestDir: "{app}"; Flags: ignoreversion

; Прилагающиеся ресурсы
Source: "C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\Billing-View\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs