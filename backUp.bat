@echo on

set /p dbpassword="Enter database password: "
set /p dbname="Enter database name: "
set /p backupfolder="Enter backup folder path: "

set filename=%dbname%_backup.sql

echo Backing up database %dbname% to %backupfolder%\%filename%...

"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe" -u root -p%dbpassword% %dbname% > "%backupfolder%\%filename%"

if %errorlevel% neq 0 (
    echo Error: Backup failed!
) else (
    echo Backup successful!
)