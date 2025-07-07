using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string carpetaImagenes = @"C:\Users\angel\Documents\jpRealState-2025\properties\rental\6-Casa-Brisas-Frente-al-mar"; // 🔁 Cámbiala
        string prefijo = "brisas";

        if (!Directory.Exists(carpetaImagenes))
        {
            Console.WriteLine("La ruta no existe.");
            return;
        }

        string[] extensiones = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
        var archivos = Directory.GetFiles(carpetaImagenes)
            .Where(f => extensiones.Contains(Path.GetExtension(f).ToLower()))
            .ToList();

        int contador = 1;

        foreach (var archivo in archivos)
        {
            string extension = Path.GetExtension(archivo).ToLower();
            string nuevoNombre;

            // 🧠 Encuentra un nombre disponible
            do
            {
                nuevoNombre = $"{prefijo}-{contador}{extension}";
                contador++;
            }
            while (File.Exists(Path.Combine(carpetaImagenes, nuevoNombre)));

            string nuevoPath = Path.Combine(carpetaImagenes, nuevoNombre);

            try
            {
                File.Move(archivo, nuevoPath);
                Console.WriteLine($"✅ Renombrado: {nuevoNombre}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al renombrar {archivo}: {ex.Message}");
            }
        }

        Console.WriteLine("🚀 Proceso terminado.");
    }
}
