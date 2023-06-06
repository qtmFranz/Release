// Decompiled with JetBrains decompiler
// Type: FitoCensus.Data.Record.RaccoltaRecord
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using SQLite;
using System;
using System.ComponentModel;

namespace FitoCensus.Data.Record
{
  [Table("RaccoltaRecord")]
  public class RaccoltaRecord : INotifyPropertyChanged
  {
    private int _id;
    private string _nome;
    private DateTime _data;
    private bool _selectionMode = false;
    private string _page_type = "FitoPatologico";
    private string _global_ubicazione = "";
    private string _global_citta = "";

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

    [Ignore]
    public string BindedData => this.Data.ToShortDateString();

    public bool SelectionMode
    {
      get => this._selectionMode;
      set
      {
        this._selectionMode = value;
        this.OnPropertyChanged(nameof (SelectionMode));
      }
    }

    public string PageType
    {
      get => this._page_type;
      set
      {
        this._page_type = value;
        this.OnPropertyChanged(nameof (PageType));
      }
    }

    public string GlobalUbicazione
    {
      get => this._global_ubicazione;
      set
      {
        this._global_ubicazione = value;
        this.OnPropertyChanged(nameof (GlobalUbicazione));
      }
    }

    public string GlobalCitta
    {
      get => this._global_citta;
      set
      {
        this._global_citta = value;
        this.OnPropertyChanged(nameof (GlobalCitta));
      }
    }

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
