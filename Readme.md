This repository is used to demo a failure caused by nuget package reference version range.



# Repro steps:

* build the app and dependent lib:
```
dotnet build MyNetFxApp/MyNetFxApp.csproj
```
* retrieve all the dependencies of the library by publish it
```
dotnet publish MyLibrary/MyLibrary.csproj
```
* Copy everything under `MyLibrary\bin\Debug\netstandard2.0\publish\` to `MyNetFxApp\bin\Debug\`, so that the app should be ready to run

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


# Working steps using the new Project file format 

1. Create new folder at root `MyNetFxApp2`

2. Create new project file as follows:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
   <OutputType>Exe</OutputType>
    <TargetFramework>net472</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\MyLibrary\MyLibrary.csproj" />
  </ItemGroup>

</Project>

```
2. Copy all contents from the original  and remove the Assembly info from Properties
3. Run

```
dotnet restore
dotnet build
dotnet publish

```

4. execute at Debug\net472\publish\MyNetFxApp.exe

You will see now all the dll files are restored and copied correctly when publishing.