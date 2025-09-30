# MyMermaidEditor - QWEN.md

## Project Overview

MyMermaidEditor is a .NET 9 Windows Presentation Foundation (WPF) desktop application that provides a visual editor for creating and rendering Mermaid diagrams. The application features a split-view interface with a text editor on the left for writing Mermaid code and a real-time preview on the right that renders the diagram using WebView2 and the Mermaid.js library.

### Key Features

- **Real-time Diagram Rendering**: Edit Mermaid code and see the diagram update automatically (with optional auto-render)
- **Multi-format Export**: Export diagrams to PNG and PDF formats
- **Example Templates**: Pre-built templates for common diagram types (Flowchart, Sequence, Gantt, Class)
- **Interactive Toolbar**: Intuitive controls for rendering, exporting, and clearing diagrams
- **Responsive UI**: Split-view interface with adjustable panes using GridSplitter

### Project Architecture

- **Technology Stack**: .NET 9, WPF, C#
- **Diagram Rendering**: WebView2 control with Mermaid.js JavaScript library
- **Export Capabilities**: System.Drawing.Common for image processing, PdfSharpCore for PDF generation
- **UI Framework**: WPF with XAML-based interface

### Solution Structure

```
MyMermaidEditor/
├── MermaidEditor.sln
├── .gitignore
├── LICENSE
└── MermaidEditor/
    ├── App.xaml / App.xaml.cs
    ├── MainWindow.xaml / MainWindow.xaml.cs
    ├── MermaidEditor.csproj
    ├── AssemblyInfo.cs
    └── Icons/ (PNG assets for UI icons)
```

### Dependencies

The project uses these NuGet packages:

- **Microsoft.Web.WebView2**: For browser-based diagram rendering
- **PdfSharpCore**: For PDF export functionality
- **System.Drawing.Common**: For image processing

### Building and Running

To build and run this application:

1. **Prerequisites**:
   - .NET 9 SDK installed
   - Windows operating system (WPF application)

2. **Build Process**:
   ```bash
   dotnet build
   ```

3. **Run Application**:
   ```bash
   dotnet run --project MermaidEditor
   ```

4. **Alternative (Visual Studio)**:
   - Open `MermaidEditor.sln` in Visual Studio 2022
   - Press F5 to build and run

### Development Conventions

- **Code Style**: The project follows standard C# coding conventions with nullable reference types enabled
- **UI Language**: The application UI is in Spanish (buttons and labels use Spanish text)
- **File Structure**: Separation of concerns with XAML for UI and C# for logic

### Key Functionality

The application provides the following core functionality:

1. **Diagram Editor**: A text editor with syntax-friendly settings (Consolas font, tab support)
2. **Real-time Preview**: WebView2 control renders Mermaid diagrams using the Mermaid.js CDN
3. **Export Features**: 
   - PNG export captures the diagram as a bitmap image
   - PDF export embeds the diagram image in a properly sized PDF document
4. **Template System**: Dropdown menu with examples for common diagram types
5. **Auto-render Toggle**: Option to automatically update preview as code changes

### File Details

- **MainWindow.xaml**: Defines the main UI with split-view layout, toolbar, and status bar
- **MainWindow.xaml.cs**: Contains the logic for diagram rendering, export functionality, and UI event handling
- **App.xaml**: Application-wide resources and startup configuration
- **MermaidEditor.csproj**: Project configuration with target framework and package references

### Export Mechanism

The export functionality works by:
1. Using WebView2's JavaScript execution to capture the rendered SVG diagram
2. Converting the SVG to a bitmap image
3. For PDF export, embedding the image in a properly sized PDF document using PdfSharpCore
4. Using fallback mechanisms (WebView2's CapturePreviewAsync) when JavaScript export fails

### Current Features

- Flowchart diagrams
- Sequence diagrams
- Gantt charts
- Class diagrams
- Clear canvas functionality
- Responsive design with adjustable panels

### License

This project is licensed under the MIT License (see LICENSE file for details).