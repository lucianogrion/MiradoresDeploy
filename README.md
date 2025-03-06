# MiradoresDeploy
MiradoresDeploy

Here’s a Markdown documentation file (`Form1.md`) describing the functionality of your `Form1.cs` file:

---

# Form1.cs - Windows Forms Application

## Overview

`Form1.cs` is a Windows Forms application written in C# that provides functionality to browse directories, select configuration files, and process them. It appears to be part of a larger system related to `MiradorCS`, interacting with configuration utilities.

## Features

- **Folder Selection**: Allows users to select a folder and displays its path.
- **Configuration File Selection**: Opens a file dialog to select a `.config` file and loads its content.
- **Configuration Comparison**: Compares two lists of configuration keys.
- **Folder Processing**: Processes files in a selected directory to extract configuration keys.

## Dependencies

- `.NET Framework`
- `System.Windows.Forms`
- `MiradorCS.Manager`
- `Manager`

## Code Breakdown

### 1. **Folder Selection (`cmdCarpeta_Click`)**
   - Opens a `FolderBrowserDialog`.
   - Updates `txtCarpeta` with the selected path.
   - Handles exceptions by displaying an error message in `lblEstado`.

### 2. **Configuration File Selection (`cmdConfig_Click`)**
   - Uses `OpenFileDialog` to let the user select a `.config` file.
   - Reads the file and extracts configuration keys using `UtilidadesConfig.ObtenerConfigs()`.
   - Populates `griConfig` with extracted configuration keys.
   - Displays errors if file reading fails.

### 3. **Configuration Comparison (`cmdCotejar_Click`)**
   - Retrieves configuration lists from `griCs` and `griConfig`.
   - Uses `UtilidadesConfig.Cotejar()` to compare them.
   - Displays the results in `griCotejar`.

### 4. **Folder Processing (`cmdProcesarCarpeta_Click`)**
   - Retrieves all configuration keys from files in the selected directory.
   - Uses `UtilidadesConfig.WalkDirectoryTreeCs()`.
   - Populates `griCs` with extracted keys.
   - Displays errors if the folder is not selected.

## Usage

1. Run the application.
2. Click **"Select Folder"** and choose a directory.
3. Click **"Load Config File"** and select a `.config` file.
4. Click **"Compare Configs"** to compare extracted keys.
5. Click **"Process Folder"** to analyze files in the selected directory.

## Error Handling

- All operations are wrapped in `try-catch` blocks.
- Errors are displayed in `lblEstado` when an exception occurs.

---

Let me know if you want any modifications or additional details! 🚀
