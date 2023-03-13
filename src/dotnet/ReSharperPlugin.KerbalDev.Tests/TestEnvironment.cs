using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.KerbalDev.Tests
{
    [ZoneDefinition]
    public class KerbalDevTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IKerbalDevZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<KerbalDevTestEnvironmentZone> { }

    [SetUpFixture]
    public class KerbalDevTestsAssembly : ExtensionTestEnvironmentAssembly<KerbalDevTestEnvironmentZone> { }
}
