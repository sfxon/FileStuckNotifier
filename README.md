# FileStuckNotifier
A simple C# Application, aimed to inform you, if a directory is not empty. Sends Mails, if there is/are file(s) in the directory.

## Setup
1. Fetch all Dependencies (Nuget)
2. Compile
3. Add a appsettings.json in the same folder as the exe is in. You can use the appsettings.json.example as a template for this.
4. Done

## Usage
Call from command line like this:

```
FileStuckNtoifier.exe notifyIfFolderIsNotEmpty <folder>
```

Replace **&lt;folder&gt;** with the path of the directory you want to check.
