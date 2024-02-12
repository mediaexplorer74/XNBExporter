// Decompiled with JetBrains decompiler
// Type: XNBExport.Properties.Resources
// Assembly: XNBExport, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F8623A86-D234-4E52-8F18-222BFB81F914
// Assembly location: C:\Users\Admin\Desktop\RE\XNBExporter\XNBExport-xna31.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace XNBExport.Properties
{
  [CompilerGenerated]
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  internal class Resources
  {
    private static CultureInfo resourceCulture;
    private static ResourceManager resourceMan;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => XNBExport.Properties.Resources.resourceCulture;
      set => XNBExport.Properties.Resources.resourceCulture = value;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (XNBExport.Properties.Resources.resourceMan == null)
          XNBExport.Properties.Resources.resourceMan = new ResourceManager("XNBExport.Properties.Resources", typeof (XNBExport.Properties.Resources).Assembly);
        return XNBExport.Properties.Resources.resourceMan;
      }
    }
  }
}
