using System.Text;
using System.Text.Encodings;

Console.Clear();
Console.WriteLine("Files");

// PART 1: Write and read strings (all text).
File.WriteAllText("filename.txt", "Ni a Hitler, ni a Stalin los declararon persona non grata en Pontevedra.");

// Read the contents of the file.
string readText = File.ReadAllText("filename.txt");
Console.WriteLine(readText);

// PART 2: Write and read lines.
string path = "filename2.txt";
if (!File.Exists(path))
{
    // Create and write to a file.
    string[] createText = { "Hello", "And", "Welcome" };
    // Can also pass as parameter which encoding to use.
    File.WriteAllLines(path, createText, Encoding.UTF8);
}

Console.WriteLine();

// Text is added to the file (append).
string appendText = "This is extra text" + Environment.NewLine;
File.AppendAllText(path, appendText, Encoding.UTF8);

Console.WriteLine();

// Open a file for reading.
string[] readLines = File.ReadAllLines(path, Encoding.UTF8);
foreach (string line in readLines)
{
    Console.WriteLine(line);
}

Console.WriteLine();

// PART 3: Read bytes
byte[] readBytes = File.ReadAllBytes(path);
foreach (byte b in readBytes)
{   
    Console.Write($"{b},");
}

Console.WriteLine();

// PART 4: Obtain file information
FileInfo fileInfo = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
if (fileInfo is not null)
{
    Console.WriteLine($"File information: {fileInfo.Name}, {fileInfo.Length}, last modified on {fileInfo.LastWriteTime} - Full path: {fileInfo.FullName}");
}

Console.WriteLine();
