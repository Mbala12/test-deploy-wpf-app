using System;
using WixSharp;
using WixSharp.UI;

class Program
{
    static void Main()
    {
        var project = new Project("MyWpfApp",
            new Dir(@"%ProgramFiles%\MyWpfApp",
                new Files(@"..\publish\*.*")));

        project.UI = WUI.WixUI_InstallDir;

        project.OutDir = @"..\InstallerBuilderOutput";

        Compiler.BuildMsi(project);
    }
}