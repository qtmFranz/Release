// Decompiled with JetBrains decompiler
// Type: FitoCensusDesktop.Export.ExportInfoEventArgs
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using System;

namespace FitoCensusDesktop.Export
{
  public class ExportInfoEventArgs : EventArgs
  {
    public ExportInfoEventArgs(string message, ExportRaccoltaContent export_content)
    {
      this.Message = message;
      this.ExportRaccoltaContent = export_content;
    }

    public string Message { get; }

    public ExportRaccoltaContent ExportRaccoltaContent { get; }
  }
}
