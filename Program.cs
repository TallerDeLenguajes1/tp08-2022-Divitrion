string ruta;
var archivos = new List<FileInfo>();
var carpetas = new List<DirectoryInfo>();

Console.WriteLine("Ingrese la ruta de un directorio: ");
ruta=Console.ReadLine();

carpetas= new DirectoryInfo(ruta).GetDirectories().ToList();
StreamWriter index = new StreamWriter(@"C:\Users\Alumno\Desktop\Taller\Nuevacarpeta\tp08-2022-Divitrion\index.csv");
index.WriteLine("Registro,Nombre,Extension;");
int registro = 1;

foreach (var carpeta in carpetas)
{
    Console.WriteLine($"Carpeta: {carpeta.Name}");
    archivos = carpeta.GetFiles().ToList();
    foreach (var archivo in archivos)
    {
        Console.WriteLine(archivo.Name);
        index.WriteLine($"{registro},{archivo.Name},{archivo.Extension}");
        registro++;
    }
}
archivos = new DirectoryInfo(ruta).GetFiles().ToList();
    foreach (var archivo in archivos)
    {
        index.WriteLine($"{registro},{archivo.Name},{archivo.Extension}");
        Console.WriteLine(archivo.Name);
        registro++;
    }
StreamReader sr = new StreamReader(@"C:\Users\Alumno\Desktop\Taller\Nuevacarpeta\tp08-2022-Divitrion\index.csv");
index.Close();
