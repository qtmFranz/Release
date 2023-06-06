// Decompiled with JetBrains decompiler
// Type: FitoCensusDesktop.Export.ExcelExportAttribute
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using System;

namespace FitoCensusDesktop.Export
{
  public class ExcelExportAttribute : Attribute
  {
    public ExcelExportAttribute(string cell_name, uint cell_index, ExcelFormatMode format)
    {
      this.CellName = cell_name;
      this.CellIndex = cell_index;
      this.FormatMode = format;
    }

    public ExcelFormatMode FormatMode { get; set; }

    public string CellName { get; set; }

    public uint CellIndex { get; set; }
  }
}
