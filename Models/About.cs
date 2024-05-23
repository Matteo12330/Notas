using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://learn.microsoft.com/es-es/dotnet/maui/tutorials/notes-app/?view=net-maui-8.0&viewFallbackFrom=net-maui-7.0";
    public string Message => "-Mateo Ramirez";

    public string MessageDescription => "Hola a todos, me gusta hacer amigos";

}