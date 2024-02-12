// Decompiled with JetBrains decompiler
// Type: XNBExport.Program
// Assembly: XNBExport, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F8623A86-D234-4E52-8F18-222BFB81F914
// Assembly location: C:\Users\Admin\Desktop\RE\XNBExporter\XNBExport-xna31.exe

using System;
using System.Windows.Forms;

#nullable disable
namespace XNBExport
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
