// Decompiled with JetBrains decompiler
// Type: FitoCensusDesktop.Export.ExportRaccoltaRecord
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FitoCensusDesktop.Export
{
  public class ExportRaccoltaRecord : INotifyPropertyChanged
  {
    private int _id;
    private string _nome;
    private DateTime _data;

    [NotNull]
    [PrimaryKey]
    [AutoIncrement]
    public int Id
    {
      get => this._id;
      set
      {
        this._id = value;
        this.OnPropertyChanged(nameof (Id));
      }
    }

    [NotNull]
    public string Nome
    {
      get => this._nome;
      set
      {
        this._nome = value;
        this.OnPropertyChanged(nameof (Nome));
      }
    }

    public DateTime Data
    {
      get => this._data;
      set
      {
        this._data = value;
        this.OnPropertyChanged(nameof (Data));
      }
    }

    public List<ExportRaccoltaContent> Contents { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if (propertyChanged == null)
        return;
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
