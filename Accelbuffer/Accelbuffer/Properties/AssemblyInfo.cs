﻿using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的一般信息由以下
// 控制。更改这些特性值可修改
// 与程序集关联的信息。

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#elif UNITY
[assembly: AssemblyConfiguration("Unity-Release")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyTitle("Accelbuffer")]
[assembly: AssemblyDescription("A fast and powerful serialization system.")]
[assembly: AssemblyCompany("JinYuhan")]
[assembly: AssemblyProduct("Accelbuffer")]
[assembly: AssemblyCopyright("See https://github.com/Jin-Yuhan/Accelbuffer")]
[assembly: CompilationRelaxations(8)]

[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

[assembly: Guid("8c53dd8b-aca0-466c-852c-4b2197540c3c")]

[assembly: AssemblyVersion("2.1.7.12")]
[assembly: AssemblyFileVersion("2.15.7.14")]
[assembly: NeutralResourcesLanguage("")]

