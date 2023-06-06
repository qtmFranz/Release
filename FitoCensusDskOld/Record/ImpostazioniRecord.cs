// Decompiled with JetBrains decompiler
// Type: FitoCensus.Data.Record.ImpostazioniRecord
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using SQLite;
using System;
using System.ComponentModel;

namespace FitoCensus.Data.Record
{
  [Table("ImpostazioniRecord")]
  public class ImpostazioniRecord : INotifyPropertyChanged
  {
    private int _id;
    private string _rilevatore;
    private DateTime _data;
    private bool _is_auth = true;
    private string _code;
    private bool _is_speditiva_on = true;
    private bool _is_ordinaria_on = false;
    private bool _is_fito_on = false;

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

    [Unique]
    public string Rilevatore
    {
      get => this._rilevatore;
      set
      {
        this._rilevatore = value;
        this.OnPropertyChanged("Id");
      }
    }

    public DateTime Data
    {
      get => this._data;
      set
      {
        this._data = value;
        this.OnPropertyChanged("Id");
      }
    }

    public bool IsAuth
    {
      get => this._is_auth;
      set
      {
        this._is_auth = value;
        this.OnPropertyChanged(nameof (IsAuth));
      }
    }

    public string AccessCode
    {
      get => this._code;
      set
      {
        this._code = value;
        this.OnPropertyChanged(nameof (AccessCode));
      }
    }

    public bool IsSpeditivaOn
    {
      get => this._is_speditiva_on;
      set
      {
        this._is_speditiva_on = value;
        this.OnPropertyChanged(nameof (IsSpeditivaOn));
      }
    }

    public bool IsOrdinariaOn
    {
      get => this._is_ordinaria_on;
      set
      {
        this._is_ordinaria_on = value;
        this.OnPropertyChanged(nameof (IsOrdinariaOn));
      }
    }

    public bool IsFitoOn
    {
      get => this._is_fito_on;
      set
      {
        this._is_fito_on = value;
        this.OnPropertyChanged(nameof (IsFitoOn));
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
