// Программа просматривает папку и все папки в папках с помощью рекурсии
string path = "./example"; //D:/MY WORK/IT/GeekBrain/С#/PRAGRAMS/Programs recurs derictories/example
//DirectoryInfo di = new DirectoryInfo(path);
//Console.Write($"{di.FullName}");

void LookThroughDirectory(string link, string indent = "")
{
    DirectoryInfo cataloge = new DirectoryInfo(link);
    DirectoryInfo[] catalogues = cataloge.GetDirectories();

    for (int i = 0; i < catalogues.Length; i++)
    {
        Console.WriteLine($"{indent}Folder: {catalogues[i].Name}");
        FileInfo[] files = catalogues[i].GetFiles();
        for (int j = 0; j < files.Length; j++) Console.WriteLine($"{indent}  File: {files[j].Name}");
        LookThroughDirectory(catalogues[i].FullName, indent += "  ");
        indent = "";
    }
}

LookThroughDirectory(path);