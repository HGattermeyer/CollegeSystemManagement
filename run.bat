@ECHO OFF
mkdir Publish
ECHO Publishing solution
dotnet publish CollegeSystemSystem\CollegeSystemSystem.csproj --output Publish
start chrome https://localhost:5001/ 
Publish\CollegeSystemSystem.exe
PAUSE