# rename-project

Renombra automáticamente imágenes en una carpeta usando un prefijo personalizado y numeración secuencial.

## ¿Para qué sirve?

Este proyecto está diseñado para facilitar el renombrado masivo de archivos de imagen en una carpeta, asignando un nombre uniforme con un prefijo y un número incremental. Es útil para organizar fotos de propiedades, productos, galerías, etc., evitando nombres duplicados y mejorando la gestión de archivos.

## Motivo de uso

- Estandarizar nombres de imágenes para catálogos, sitios web o archivos personales.
- Evitar conflictos por nombres repetidos.
- Ahorrar tiempo en el proceso de renombrado manual.

## ¿Cómo correr el proyecto?

1. **Clona o descarga el repositorio.**
2. Abre el proyecto en Visual Studio o tu editor preferido.
3. Edita el archivo [`Program.cs`](Program.cs) y cambia la variable `carpetaImagenes` por la ruta de la carpeta que contiene tus imágenes.
4. Opcionalmente, cambia el valor de `prefijo` por el que desees usar.
5. Compila y ejecuta el proyecto:

   ```sh
   dotnet run
## Ejemplo de uso
Si tienes imagenes como_

IMG_001.jpg
foto2.png
casa.jpeg

si usas el prefijo " 

brisas-1.jpg
brisas-2.png
brisas-3.jpegbrisas "