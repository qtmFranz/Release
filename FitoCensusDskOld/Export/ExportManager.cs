// Decompiled with JetBrains decompiler
// Type: FitoCensusDesktop.Export.ExportManager
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using FitoCensus.Data.Record;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FitoCensusDesktop.Export
{
  public static class ExportManager
  {
    private static FileType in_type;
    private static string in_fp;
    private static string out_fp;

    public static FileType InputType
    {
      get => ExportManager.in_type;
      set => ExportManager.in_type = value;
    }

    public static string InputFilePath
    {
      get => ExportManager.in_fp;
      set
      {
        ExportManager.in_fp = File.Exists(value) ? value : throw new FileNotFoundException();
        ExportManager.ExportFile = ExportFile.LoadFromPath(ExportManager.in_fp, ExportManager.InputType);
      }
    }

    public static string OutputFilePath
    {
      get => ExportManager.out_fp;
      set
      {
        if (!Directory.Exists(ExportManager.OutputFilePath))
          Directory.CreateDirectory(value);
        ExportManager.out_fp = value;
      }
    }

    public static string ModelFilePath { get; set; }

    public static string PlainModelPath { get; set; }

    public static ExportFile ExportFile { get; private set; }

    private static string StringifyBoolean(Type type, object val)
    {
      if (!(type == typeof (bool)))
        return val?.ToString();
      string str1 = val.ToString();
      string str2 = str1;
      bool flag = false;
      string str3 = flag.ToString();
      if (str2 == str3)
        str1 = "";
      string str4 = str1;
      flag = true;
      string str5 = flag.ToString();
      if (str4 == str5)
        str1 = "X";
      return str1;
    }

    public static void UpdateCell(
      SpreadsheetDocument spreadSheet,
      string text,
      uint rowIndex,
      string columnName,
      string sheetName)
    {
      WorksheetPart worksheetPartByName = ExportManager.GetWorksheetPartByName(spreadSheet, sheetName);
      if (worksheetPartByName == null)
        return;
      Cell cell = ExportManager.GetCell(worksheetPartByName.Worksheet, columnName, rowIndex);
      cell.CellValue = new CellValue(text);
      cell.DataType = new EnumValue<CellValues>(CellValues.String);
    }

    private static WorksheetPart GetWorksheetPartByName(
      SpreadsheetDocument document,
      string sheetName)
    {
      IEnumerable<Sheet> source = document.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>().Where<Sheet>((Func<Sheet, bool>) (s => (string) s.Name == sheetName));
      if (source.Count<Sheet>() == 0)
      {
        WorksheetPart part = document.WorkbookPart.AddNewPart<WorksheetPart>();
        part.Worksheet = new Worksheet(new OpenXmlElement[1]
        {
          (OpenXmlElement) new SheetData()
        });
        Sheets firstChild = document.WorkbookPart.Workbook.GetFirstChild<Sheets>();
        string idOfPart = document.WorkbookPart.GetIdOfPart((OpenXmlPart) part);
        uint num = 1;
        if (firstChild.Elements<Sheet>().Count<Sheet>() > 0)
          num = firstChild.Elements<Sheet>().Select<Sheet, uint>((Func<Sheet, uint>) (s => s.SheetId.Value)).Max<uint>() + 1U;
        Sheet sheet = new Sheet()
        {
          Id = (StringValue) idOfPart,
          SheetId = (UInt32Value) num,
          Name = (StringValue) sheetName
        };
        firstChild.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) sheet
        });
        return part;
      }
      string id = source.First<Sheet>().Id.Value;
      return (WorksheetPart) document.WorkbookPart.GetPartById(id);
    }

    private static Cell GetCell(Worksheet worksheet, string columnName, uint rowIndex)
    {
      Row row = ExportManager.GetRow(worksheet, rowIndex);
      if (row == null)
        return (Cell) null;
      IEnumerable<Cell> source = row.Elements<Cell>().Where<Cell>((Func<Cell, bool>) (c => string.Compare(c.CellReference.Value, columnName + rowIndex.ToString(), true) == 0));
      string str = columnName + rowIndex.ToString();
      if (source.Count<Cell>() != 0)
        return row.Elements<Cell>().Where<Cell>((Func<Cell, bool>) (c => string.Compare(c.CellReference.Value, columnName + rowIndex.ToString(), true) == 0)).First<Cell>();
      Cell cell = new Cell();
      cell.CellReference = (StringValue) str;
      Cell newChild = cell;
      row.AppendChild<Cell>(newChild);
      return newChild;
    }

    private static Row GetRow(Worksheet worksheet, uint rowIndex)
    {
      IEnumerable<Row> source = worksheet.GetFirstChild<SheetData>().Elements<Row>().Where<Row>((Func<Row, bool>) (r => (int) (uint) r.RowIndex == (int) rowIndex));
      if (source.Count<Row>() != 0)
        return source.First<Row>();
      Row row = new Row()
      {
        RowIndex = (UInt32Value) rowIndex
      };
      worksheet.GetFirstChild<SheetData>().Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) row
      });
      return row;
    }

    private static void BuildCells<T>(SpreadsheetDocument spreadSheet, T obj)
    {
      foreach (PropertyInfo property in typeof (T).GetProperties())
      {
        foreach (object customAttribute in property.GetCustomAttributes(true))
        {
          if (customAttribute is ExcelExportAttribute excelExportAttribute)
          {
            string cellName = excelExportAttribute.CellName;
            uint cellIndex = excelExportAttribute.CellIndex;
            string text = ExportManager.StringifyBoolean(property.PropertyType, property.GetValue((object) obj, (object[]) null));
            ExportManager.UpdateCell(spreadSheet, text, cellIndex, cellName, "Foglio1");
          }
        }
      }
    }

    private static string GetExcelColumnName(int columnNumber)
    {
      string excelColumnName = "";
      int num;
      for (; columnNumber > 0; columnNumber = (columnNumber - num) / 26)
      {
        num = (columnNumber - 1) % 26;
        excelColumnName = Convert.ToChar(65 + num).ToString() + excelColumnName;
      }
      return excelColumnName;
    }

    private static int BuildCellsForResume<T>(
      SpreadsheetDocument spreadSheet,
      T obj,
      string sheetName,
      uint srow,
      int starting_point)
    {
      PropertyInfo[] properties = typeof (T).GetProperties();
      int columnNumber = 0 + starting_point;
      foreach (PropertyInfo propertyInfo in properties)
      {
        string name = propertyInfo.Name;
        string text = ExportManager.StringifyBoolean(propertyInfo.PropertyType, propertyInfo.GetValue((object) obj, (object[]) null));
        if (srow == 1U)
          ExportManager.UpdateCell(spreadSheet, name, srow, ExportManager.GetExcelColumnName(columnNumber), sheetName);
        ExportManager.UpdateCell(spreadSheet, text, srow + 1U, ExportManager.GetExcelColumnName(columnNumber), sheetName);
        ++columnNumber;
      }
      return columnNumber;
    }

    public static event ExportManager.ExportInfo ExportInfoCallback;

    public static void ExportResume()
    {
      if (ExportManager.ExportFile == null)
        return;
      SpreadsheetDocument spreadSheet = SpreadsheetDocument.Open(ExportManager.PlainModelPath, true);
      foreach (ExportRaccoltaRecord record in ExportManager.ExportFile.Records)
      {
        uint srow = 1;
        foreach (ExportRaccoltaContent content in record.Contents)
        {
          int starting_point = ExportManager.BuildCellsForResume<GeneralRecord>(spreadSheet, content.GenRecord, string.Format("RI{0}_RN{1}", (object) record.Id, (object) record.Nome), srow, 0);
          ExportManager.BuildCellsForResume<SpeditivaRecord>(spreadSheet, content.SpdRecord, string.Format("RI{0}_RN{1}", (object) record.Id, (object) record.Nome), srow++, starting_point);
        }
      }
      spreadSheet.SaveAs(Path.Combine(ExportManager.OutputFilePath, "resume.xlsx"));
      spreadSheet.Close();
    }

    public static void Export()
    {
      if (ExportManager.ExportFile == null)
        return;
      SpreadsheetDocument spreadSheet = SpreadsheetDocument.Open(ExportManager.ModelFilePath, true);
      foreach (ExportRaccoltaRecord record in ExportManager.ExportFile.Records)
      {
        foreach (ExportRaccoltaContent content in record.Contents)
        {
          ExportManager.BuildCells<GeneralRecord>(spreadSheet, content.GenRecord);
          ExportManager.BuildCells<SpeditivaRecord>(spreadSheet, content.SpdRecord);
          spreadSheet.SaveAs(Path.Combine(ExportManager.OutputFilePath, string.Format("RI{0}_RN{1}_GI{2}_GN{3}.xlsx", (object) record.Id, (object) record.Nome, (object) content.GenRecord.Id, (object) content.GenRecord.Nome)));
          ExportManager.ExportInfo exportInfoCallback = ExportManager.ExportInfoCallback;
          if (exportInfoCallback != null)
            exportInfoCallback(new ExportInfoEventArgs(string.Format("RI{0}_RN{1}_GI{2}_GN{3}.xlsx Creato", (object) record.Id, (object) record.Nome, (object) content.GenRecord.Id, (object) content.GenRecord.Nome), content));
        }
      }
      spreadSheet.Close();
    }

    public delegate void ExportInfo(ExportInfoEventArgs eventArgs);
  }
}
