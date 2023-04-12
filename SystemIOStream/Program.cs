using System.Text;

Console.Clear();
Console.WriteLine("Streams");

// PART 1: Read and write files
string path = "filename.txt";

FileStream writeFileStream = File.OpenWrite(path);
string data = "falcon\nhawk\nforest\ncloud\nsky";
byte[] bytes = Encoding.UTF8.GetBytes(data);
writeFileStream.Write(bytes, 0, bytes.Length);
writeFileStream.Dispose();

FileStream readFileStream = File.OpenRead(path);
byte[] buffer = new byte[1024];
int bytesWrittenIntoBuffer;

while ((bytesWrittenIntoBuffer = readFileStream.Read(buffer, 0, buffer.Length)) > 0)
{
    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, bytesWrittenIntoBuffer));
}

readFileStream.Dispose();

Console.WriteLine();

// Part 2: Read file content using a memory stream
byte[] fileContents = File.ReadAllBytes("filename.txt");
MemoryStream memoryStream = new(fileContents);
TextReader textReader = new StreamReader(memoryStream);
string? line = "";
while ((line = textReader.ReadLine()) != null)
{
    Console.WriteLine(line);
}

Console.WriteLine();

// Part 3: Download and view an image
HttpClient httpClient = new();
string url = "https://avatars.githubusercontent.com/u/129280586?s=96&v=4";
byte[] imageBytes = await httpClient.GetByteArrayAsync(url);

string imgFilename = "sample_image.jpg";
FileStream fileStream = new FileStream(imgFilename, FileMode.Create);
fileStream.Write(imageBytes, 0, imageBytes.Length);
Console.WriteLine("Image downloaded");
fileStream.Dispose();

fileStream = new FileStream(imgFilename, FileMode.Open);
int i = 0;
while ((bytesWrittenIntoBuffer = fileStream.ReadByte()) != -1)
{
    Console.Write($"{bytesWrittenIntoBuffer.ToString("X2")} ");
    i++;

    if (i % 64 == 0)
        Console.WriteLine();
}

Console.WriteLine();
