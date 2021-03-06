using System.Reflection;
using System.Runtime.InteropServices;

#if NET46
[assembly: AssemblyTitle(".NET Framework 4.6")]
#endif

#if NET461
[assembly: AssemblyTitle(".NET Framework 4.6.1")]
#endif

#if NET462
[assembly: AssemblyTitle(".NET Framework 4.6.2")]
#endif

#if NET47
[assembly: AssemblyTitle(".NET Framework 4.7")]
#endif

#if NET471
[assembly: AssemblyTitle(".NET Framework 4.7.1")]
#endif

#if NETCOREAPP2_0
[assembly: AssemblyTitle(".NET Core 2.0")]
#endif

#if NETSTANDARD2_0
[assembly: AssemblyTitle(".NET Standard 2.0")]
#endif

[assembly: AssemblyVersion("10.0.1.0")]
[assembly: AssemblyCopyright("Copyright © Eben Roux 2017")]
[assembly: AssemblyProduct("Shuttle.Core.Logging")]
[assembly: AssemblyCompany("Shuttle")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyInformationalVersion("10.0.1")]
[assembly: ComVisible(false)]
