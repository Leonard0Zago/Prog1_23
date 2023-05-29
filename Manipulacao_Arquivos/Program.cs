using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using static Program;

SectionTitle("* Handling cross-platform environments and filesystems");
Console.WriteLine("{0,-33} {1}", arg0: "Path.PathSeparator",
arg1: PathSeparator);
Console.WriteLine("{0,-33} {1}", arg0: "Path.DirectorySeparatorChar",
arg1: DirectorySeparatorChar);
Console.WriteLine("{0,-33} {1}", arg0: "Directory.GetCurrentDirectory()",
arg1: GetCurrentDirectory());
Console.WriteLine("{0,-33} {1}", arg0: "Environment.CurrentDirectory",
arg1: CurrentDirectory);
Console.WriteLine("{0,-33} {1}", arg0: "Environment.SystemDirectory",
arg1: SystemDirectory);
Console.WriteLine("{0,-33} {1}", arg0: "Path.GetTempPath()",
arg1: GetTempPath());
Console.WriteLine("GetFolderPath(SpecialFolder");
Console.WriteLine("{0,-33} {1}", arg0: " .System)",
arg1: GetFolderPath(SpecialFolder.System));
Console.WriteLine("{0,-33} {1}", arg0: " .ApplicationData)",
arg1: GetFolderPath(SpecialFolder.ApplicationData));
Console.WriteLine("{0,-33} {1}", arg0: " .MyDocuments)",
arg1: GetFolderPath(SpecialFolder.MyDocuments));
Console.WriteLine("{0,-33} {1}", arg0: " .Personal)",
arg1: GetFolderPath(SpecialFolder.Personal));

SectionTitle("Managing drives");
Console.WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}",
"NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE");
foreach (DriveInfo drive in DriveInfo.GetDrives())
{
if (drive.IsReady)
{
Console.WriteLine(
"{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}",
drive.Name, drive.DriveType, drive.DriveFormat,
drive.TotalSize, drive.AvailableFreeSpace);
}
else
{
Console.WriteLine("{0,-30} | {1,-10}", drive.Name, drive.DriveType);
}
}

SectionTitle("Managing directories");
// define a directory path for a new folder
// starting in the user's folder
string newFolder = Combine(
GetFolderPath(SpecialFolder.Personal), "NewFolder");
Console.WriteLine($"Working with: {newFolder}");
// check if it exists
Console.WriteLine($"Does it exist? {Path.Exists(newFolder)}");
// create directory
Console.WriteLine("Creating it...");
CreateDirectory(newFolder);
Console.WriteLine($"Does it exist? {Path.Exists(newFolder)}");
Console.Write("Confirm the directory exists, and then press ENTER: ");
Console.ReadLine();
// delete directory
Console.WriteLine("Deleting it...");
Delete(newFolder, recursive: true);
Console.WriteLine($"Does it exist? {Path.Exists(newFolder)}");

SectionTitle("Managing files");
// define a directory path to output files
// starting in the user's folder
string dir = Combine(
GetFolderPath(SpecialFolder.Personal), "OutputFiles");
CreateDirectory(dir);
// define file paths
string textFile = Combine(dir, "Dummy.txt");
string backupFile = Combine(dir, "Dummy.bak");
Console.WriteLine($"Working with: {textFile}");
// check if a file exists
Console.WriteLine($"Does it exist? {File.Exists(textFile)}");
// create a new text file and write a line to it
StreamWriter textWriter = File.CreateText(textFile);
textWriter.WriteLine("Hello, C#!");
textWriter.Close(); // close file and release resources
Console.WriteLine($"Does it exist? {File.Exists(textFile)}");
// copy the file, and overwrite if it already exists
File.Copy(sourceFileName: textFile,
destFileName: backupFile, overwrite: true);
Console.WriteLine(
$"Does {backupFile} exist? {File.Exists(backupFile)}");
Console.Write("Confirm the files exist, and then press ENTER: ");
Console.ReadLine();
// delete file
File.Delete(textFile);
Console.WriteLine($"Does it exist? {File.Exists(textFile)}");
// read from the text file backup
Console.WriteLine($"Reading contents of {backupFile}:");
StreamReader textReader = File.OpenText(backupFile);
Console.WriteLine(textReader.ReadToEnd());
textReader.Close();

SectionTitle("Managing paths");
Console.WriteLine($"Folder Name: {GetDirectoryName(textFile)}");
Console.WriteLine($"File Name: {GetFileName(textFile)}");
Console.WriteLine("File Name without Extension: {0}",
GetFileNameWithoutExtension(textFile));
Console.WriteLine($"File Extension: {GetExtension(textFile)}");
Console.WriteLine($"Random File Name: {GetRandomFileName()}");
Console.WriteLine($"Temporary File Name: {GetTempFileName()}");

SectionTitle("Getting file information");
FileInfo info = new(backupFile);
Console.WriteLine($"{backupFile}:");
Console.WriteLine($"Contains {info.Length} bytes");
Console.WriteLine($"Last accessed {info.LastAccessTime}");
Console.WriteLine($"Has readonly set to {info.IsReadOnly}");

SectionTitle("Writing to text streams");
// define a file to write to
string textFile = Combine(CurrentDirectory, "streams.txt");
// create a text file and return a helper writer
StreamWriter text = File.CreateText(textFile);
// enumerate the strings, writing each one
// to the stream on a separate line
foreach (string item in Viper.Callsigns)
{
text.WriteLine(item);
}
text.Close(); // release resources
// output the contents of the file
Console.WriteLine("{0} contains {1:N0} bytes.",
arg0: textFile,
arg1: new FileInfo(textFile).Length);
Console.WriteLine(File.ReadAllText(textFile));