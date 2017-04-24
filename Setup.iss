; Имя приложения
#define   Name       "Employee Manager"
; Версия приложения
#define   Version    "0.0.1"
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
OutputDir="C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\Установщик"
OutputBaseFileName=release-setup

; Файл иконки
SetupIconFile=C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\configusers.ico

; Параметры сжатия
Compression=lzma
SolidCompression=yes


[Files]

; Исполняемый файл
Source: "C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\Billing-View\bin\Release\Billing-View.exe"; DestDir: "{app}"; Flags: ignoreversion

; Прилагающиеся ресурсы
Source: "C:\Users\akun9\Documents\Visual Studio 2017\Projects\Billing\Billing-View\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs