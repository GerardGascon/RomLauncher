# RomLauncher

A basic program made using C# to automatically run the rom on the emulator when compiling in vs community.

### Compiling the program

Right-click on the folder and select "Open with Code", then run a new terminal and write the following line:

```powershell
dotnet publish -c Release -r win-x64
dotnet publish -c Release -r win-x86
```

The first one is for the 64bit systems and the second one for the 32bit systems.
This should compile the program and export into: 

```
bin/Release/net5.0/win-x64/publish
or
bin/Release/net5.0/win-x86/publish
```

Depending on the command you selected.

If you have the release version you'll see that there is a .csv file, write in the first line the path of the emulator you want to use, if you have the compiled version, create a new .csv file and write there the path of the emulator.

**WARNING**: Be sure you have the .NET 5.0 installed in your device