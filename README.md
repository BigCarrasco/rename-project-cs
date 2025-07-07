# rename-project

Automatically rename images in a folder using a custom prefix and sequential numbering.

## What is it for?

This project is designed to make bulk renaming of image files in a folder easier, assigning a uniform name with a prefix and incremental number. It's useful for organizing photos of properties, products, galleries, etc., avoiding duplicate names and improving file management.

## Why use it?

- Standardize image names for catalogs, websites, or personal files.
- Avoid conflicts due to repeated names.
- Save time compared to manual renaming.

## How to run the project?

1. **Clone or download the repository.**
2. Open the project in Visual Studio or your preferred editor.
3. Edit the [`Program.cs`](Program.cs) file and change the `carpetaImagenes` variable to the path of the folder containing your images.
4. Optionally, change the value of `prefijo` to the prefix you want to use.
5. Build and run the project:

   ```sh
   dotnet run
   ```

## Usage example

If you have images like:

```
IMG_001.jpg
foto2.png
casa.jpeg
```

and you use the prefix `brisas`, the result will be:

```
brisas-1.jpg
brisas-2.png
brisas-3.jpeg