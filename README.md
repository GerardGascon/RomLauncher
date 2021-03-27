# RomLauncher

A basic program made using C# to automatically run the rom on the emulator when compiling in vs community.

### Compiling the program

Right-click on the folder and select "Open with Code", then run a new terminal and write the following line:

```powershell
dotnet publish -c Release -r win10-x64
```

This should compile the program and export into: bin/Release/net5.0/win10-x64/publish

**WARNING**: Be sure you have the .NET 5.0 installed in your device