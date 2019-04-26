This repository is used to demo a failure 
# Repro steps:

* build the app and dependent lib:
```
dotnet build MyNetFxApp/MyNetFxApp.csproj
```
* publish the lib
```
dotnet publish MyLibrary/MyLibrary.csproj
```
* Copy everything under `MyLibrary\bin\Debug\netstandard2.0\publish\` to `MyNetFxApp\bin\Debug\`

* Run the app:
```
MyNetFxApp\bin\Debug\MyNetFxApp.exe
```

* See this error:
```
Unhandled Exception: System.IO.FileLoadException: Could not load file or assembly 'Newtonsoft.Json, Version=10.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference. (Exception from HRESULT: 0x80131040)
   at MyLibrary.Class1.LoadNethereum()
   at MyNetFxApp.Program.Main(String[] args) in D:\Demos\NugetVersionRangeDemo\MyLibrary\MyNetFxApp\Program.cs:line 13
```