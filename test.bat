@ECHO OFF
REM BFCPEOPTIONSTART
REM Advanced BAT to EXE Converter www.BatToExeConverter.com
REM BFCPEEXE=C:\Program Files\MySQL\MySQL Server 5.6\bin\BackupTool.exe
REM BFCPEICON=C:\Program Files\Advanced BAT to EXE Converter v2.94\ab2econv294\icons\icon10.ico
REM BFCPEICONINDEX=-1
REM BFCPEEMBEDDISPLAY=0
REM BFCPEEMBEDDELETE=1
REM BFCPEADMINEXE=0
REM BFCPEINVISEXE=1
REM BFCPEVERINCLUDE=1
REM BFCPEVERVERSION=1.0.0.0
REM BFCPEVERPRODUCT=ICT Scheduling System DB Backup Tool
REM BFCPEVERDESC=DB Backup Tool
REM BFCPEVERCOMPANY=Centro Escolar University
REM BFCPEVERCOPYRIGHT=2015. All Rights Reserved
REM BFCPEOPTIONEND
@ECHO ON
cls
echo off
del %userprofile%\desktop\SchedulingSystemDatabaseBackup.7z /q
mysqldump -u root -proot scheduling > scheduling.sql
attrib scheduling.sql +s +h +r
7z.exe a %userprofile%/desktop\SchedulingSystemDatabaseBackup.7z scheduling.sql -poiewjmfc9843myv92438jmy5mt25m4212mt54m94t403cre97rcny3ryc43897tnv3409pwoioplqoisjihdnvibldkjajj99izxixiofgusdo9wertoieytweioru4598n43o85548384945f09k5f94kk23i02304k32094m320ednoi23nfr90m230ed2n39rn8334983728497239478309509235809384420m40239k4d0m238094j8m23 -mhe
attrib scheduling.sql -s -h -r
del scheduling.sql /q