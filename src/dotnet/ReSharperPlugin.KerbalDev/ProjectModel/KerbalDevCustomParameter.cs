using System.Collections.Generic;
using JetBrains.Annotations;
using JetBrains.Rider.Backend.Features.ProjectModel.ProjectTemplates.DotNetExtensions;
using JetBrains.Rider.Backend.Features.ProjectModel.ProjectTemplates.DotNetTemplates;
using JetBrains.Rider.Model;

namespace ReSharperPlugin.KerbalDev.ProjectModel;

public class KerbalDevCustomParameter : DotNetTemplateParameter
{
    private readonly string _defaultValue;
    
    public override RdProjectTemplateContent CreateContent(DotNetProjectTemplateExpander expander, IDotNetTemplateContentFactory factory,
        int index, IDictionary<string, string> context)
    {
        var content = factory.CreateNextParameters(new[] { expander }, index + 1, context);
        
        var parameter = expander.TemplateInfo.GetParameter(Name);
        if (parameter == null || expander.TemplateInfo.Identity != "SpaceWarpMod") return content;
        
        return new RdProjectTemplateTextParameter(Name, PresentableName, _defaultValue, Tooltip, RdTextParameterStyle.Text, content);
    }

    public KerbalDevCustomParameter([NotNull] string name, [NotNull] string presentableName, [CanBeNull] string tooltip,
        [CanBeNull] string defaultValue = null) : base(name, presentableName, tooltip) => _defaultValue = defaultValue;
}