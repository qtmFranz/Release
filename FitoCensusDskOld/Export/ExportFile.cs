// Decompiled with JetBrains decompiler
// Type: FitoCensusDesktop.Export.ExportFile
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using FitoCensus.Data.Record;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace FitoCensusDesktop.Export
{
  public class ExportFile
  {
    public List<ExportRaccoltaRecord> Records { get; set; }

    public static ExportFile LoadFromPath(string path, FileType fileType)
    {
      if (fileType == FileType.Json)
        return ExportFile.ExportJson(path);
      return fileType == FileType.Tsv ? ExportFile.ExportTsv(path) : (ExportFile) null;
    }

    private static ExportFile ExportJson(string path)
    {
      StreamReader streamReader = new StreamReader(path);
      string end = streamReader.ReadToEnd();
      streamReader.Close();
      JObject jobject = JObject.Parse(end);
      List<ExportRaccoltaRecord> exportRaccoltaRecordList = new List<ExportRaccoltaRecord>();
      foreach (JToken jtoken1 in (IEnumerable<JToken>) jobject["export"])
      {
        ExportRaccoltaRecord exportRaccoltaRecord = new ExportRaccoltaRecord();
        exportRaccoltaRecord.Id = jtoken1[(object) "Id"].ToObject<int>();
        exportRaccoltaRecord.Nome = jtoken1[(object) "Nome"].ToString();
        exportRaccoltaRecord.Data = jtoken1[(object) "Data"].ToObject<DateTime>();
        exportRaccoltaRecord.Contents = new List<ExportRaccoltaContent>();
        foreach (JToken jtoken2 in (IEnumerable<JToken>) jtoken1[(object) "Contenuto"])
          exportRaccoltaRecord.Contents.Add(new ExportRaccoltaContent()
          {
            GenRecord = jtoken2[(object) "general"].ToObject<GeneralRecord>(),
            CenRecord = jtoken2[(object) "cens"].ToObject<CensimentoRecord>(),
            FitRecord = jtoken2[(object) "fito"].ToObject<FitoRecord>(),
            SpdRecord = jtoken2[(object) "sped"].ToObject<SpeditivaRecord>()
          });
        exportRaccoltaRecordList.Add(exportRaccoltaRecord);
      }
      return new ExportFile()
      {
        Records = exportRaccoltaRecordList
      };
    }

    private static ExportFile ExportTsv(string path)
    {
      string end;
      using (StreamReader streamReader = new StreamReader(path))
        end = streamReader.ReadToEnd();
      string[] strArray1 = end.Split('\n');
      string[] strArray2 = strArray1[0].Split('\t');
      string[] strArray3 = strArray1[1].Split('\t');
      ExportRaccoltaRecord exportRaccoltaRecord = new ExportRaccoltaRecord();
      ExportRaccoltaContent exportRaccoltaContent = new ExportRaccoltaContent();
      GeneralRecord generalRecord = new GeneralRecord();
      SpeditivaRecord speditivaRecord = new SpeditivaRecord();
      int index = 0;
      foreach (string name in strArray2)
      {
        PropertyInfo property1 = typeof (GeneralRecord).GetProperty(name);
        PropertyInfo property2 = typeof (SpeditivaRecord).GetProperty(name);
        if (property1 != (PropertyInfo) null)
        {
          Type propertyType = property1.PropertyType;
          object obj = ExportFile.MatchValue(strArray3[index], propertyType);
          property1.SetValue((object) generalRecord, Convert.ChangeType(obj, propertyType));
        }
        if (property2 != (PropertyInfo) null)
        {
          Type propertyType = property2.PropertyType;
          object obj = ExportFile.MatchValue(strArray3[index], propertyType);
          property2.SetValue((object) speditivaRecord, Convert.ChangeType(obj, propertyType));
        }
        ++index;
      }
      exportRaccoltaContent.GenRecord = generalRecord;
      exportRaccoltaContent.SpdRecord = speditivaRecord;
      exportRaccoltaRecord.Id = exportRaccoltaContent.GenRecord.RaccoltaId;
      exportRaccoltaRecord.Data = exportRaccoltaContent.GenRecord.Data;
      exportRaccoltaRecord.Contents = new List<ExportRaccoltaContent>();
      exportRaccoltaRecord.Contents.Add(exportRaccoltaContent);
      return new ExportFile()
      {
        Records = new List<ExportRaccoltaRecord>()
        {
          exportRaccoltaRecord
        }
      };
    }

    private static DateTime NormalizeDate(string val)
    {
      DateTime result = new DateTime();
      if (!DateTime.TryParse(val, out result))
        result = DateTime.ParseExact(val.Split(' ')[0], "dd/MM/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
      return result;
    }

    private static object MatchValue(string val, Type T)
    {
      if (T == typeof (string))
        return (object) val;
      if (T == typeof (int))
        return (object) int.Parse(val);
      if (T == typeof (double))
        return (object) double.Parse(val);
      if (T == typeof (bool))
        return (object) bool.Parse(val);
      if (T == typeof (DateTime))
        return (object) ExportFile.NormalizeDate(val);
      return T == typeof (float) ? (object) float.Parse(val) : new object();
    }

    private static T CastToMyType<T>(object givenObject) where T : class => givenObject as T;
  }
}
