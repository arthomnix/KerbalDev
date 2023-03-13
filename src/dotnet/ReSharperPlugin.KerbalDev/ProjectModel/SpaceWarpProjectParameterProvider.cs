using System.Collections.Generic;
using JetBrains.Application;
using JetBrains.Rider.Backend.Features.ProjectModel.ProjectTemplates.DotNetExtensions;

namespace ReSharperPlugin.KerbalDev.ProjectModel;

[ShellComponent]
public class SpaceWarpProjectParameterProvider : IDotNetTemplateParameterProvider
{
    public int Priority => 50;

    public IReadOnlyCollection<DotNetTemplateParameter> Get()
    {
        return new[]
        {
            new KerbalDevCustomParameter("GUID", "GUID", "Your mod's ID, used for the folder and DLL name"),
            new KerbalDevCustomParameter("Author", "Author", "Name(s) of the project author(s)"),
            new KerbalDevCustomParameter("BepinexName", "BepInEx name", "Mod ID in domain syntax (e.g. com.github.author.ModName), used by BepInEx"),
            new KerbalDevCustomParameter("ModName", "Mod name", "The name of your mod"),
            new KerbalDevCustomParameter("Description", "Description", "Description of your mod"),
            new KerbalDevCustomParameter("Source", "Source URL", "Link to the repository or download location of the mod's source code"),
            new KerbalDevCustomParameter("Version", "Initial version", "The mod's initial version", "1.0.0")
        };
    }
}