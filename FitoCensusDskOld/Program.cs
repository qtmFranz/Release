// Decompiled with JetBrains decompiler
// Type: FitoCensusDsk.Program
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FitoCensusDsk
{
  internal static class Program
  {
    [STAThread]
    private static void Main(string[] args)
    {
      if (Environment.OSVersion.Version.Major >= 6)
        Program.SetProcessDPIAware();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }

    [DllImport("user32.dll")]
    private static extern bool SetProcessDPIAware();
  }
}
