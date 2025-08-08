# ListDirTreeApp

A simple **C# Console Application** that recursively lists the directory and file structure of a given folder path in a clear tree format.  
This tool helps visualize folder contents directly from the command line.

---

## Features

- Accepts a folder path as input (via command line argument or interactive prompt)  
- Recursively scans subdirectories and files  
- Displays output with indentation and ASCII tree branches (`├──`, `└──`, etc.)  
- Clean code structure with separation of concerns (Models, Services, and UI)  
- Handles errors gracefully when accessing restricted folders  

---

## Getting Started

### Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) or later installed on your machine

### Building and Running

1. Clone the repository:

```bash
git clone https://github.com/yourusername/ListDirTreeApp.git
cd ListDirTreeApp
