// Decompiled with JetBrains decompiler
// Type: FitoCensus.Data.Record.GeneralRecord
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using FitoCensusDesktop.Export;
using SQLite;
using System;
using System.ComponentModel;

namespace FitoCensus.Data.Record
{
  [Table("GeneralRecord")]
  public class GeneralRecord : INotifyPropertyChanged
  {
    private int _id;
    private int _idRaccolta;
    private double _gps_lat;
    private double _gps_long;
    private double _gps_alt;
    private int _nome;
    private int _ex_nome;
    private string _specie;
    private DateTime _data;
    private string _rilevatore;
    private string _ubicazione;
    private string _citta;
    private string _civico;
    private float _diametro_tronco;
    private float _altezza_alb;
    private float _altezza_tronco;
    private float _circonferenza_tronco;
    private int _coeff_snel;
    private float _diametro_chioma;
    private string _forma_chioma;
    private string p_note;
    private string _fotopath;

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

    public int RaccoltaId
    {
      get => this._idRaccolta;
      set
      {
        this._idRaccolta = value;
        this.OnPropertyChanged(nameof (RaccoltaId));
      }
    }

    public double GpsLat
    {
      get => this._gps_lat;
      set
      {
        this._gps_lat = value;
        this.OnPropertyChanged(nameof (GpsLat));
      }
    }

    public double GpsLong
    {
      get => this._gps_long;
      set
      {
        this._gps_long = value;
        this.OnPropertyChanged(nameof (GpsLong));
      }
    }

    public double GpsAlt
    {
      get => this._gps_alt;
      set
      {
        this._gps_alt = value;
        this.OnPropertyChanged(nameof (GpsAlt));
      }
    }

    [ExcelExport("I", 6, ExcelFormatMode.CensimentoRoma)]
    public string GpsResume => string.Format("{0}, {1}, {2}", (object) this.GpsLat, (object) this.GpsLong, (object) this.GpsAlt);

    [ExcelExport("E", 6, ExcelFormatMode.CensimentoRoma)]
    public int Nome
    {
      get => this._nome;
      set
      {
        this._nome = value;
        this.OnPropertyChanged(nameof (Nome));
      }
    }

    [ExcelExport("L", 29, ExcelFormatMode.CensimentoRoma)]
    public int ExNome
    {
      get => this._ex_nome;
      set
      {
        this._ex_nome = value;
        this.OnPropertyChanged(nameof (ExNome));
      }
    }

    [ExcelExport("G", 8, ExcelFormatMode.CensimentoRoma)]
    public string Specie
    {
      get => this._specie;
      set
      {
        this._specie = value;
        this.OnPropertyChanged(nameof (Specie));
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
    [NoExport]
    [ExcelExport("D", 94, ExcelFormatMode.CensimentoRoma)]
    public string BindedData => this.Data.ToShortDateString();

    [ExcelExport("K", 94, ExcelFormatMode.CensimentoRoma)]
    public string Rilevatore
    {
      get => this._rilevatore;
      set
      {
        this._rilevatore = value;
        this.OnPropertyChanged(nameof (Rilevatore));
      }
    }

    public string Ubicazione
    {
      get => this._ubicazione;
      set
      {
        this._ubicazione = value;
        this.OnPropertyChanged(nameof (Ubicazione));
      }
    }

    public string Citta
    {
      get => this._citta;
      set
      {
        this._citta = value;
        this.OnPropertyChanged(nameof (Citta));
      }
    }

    [ExcelExport("E", 10, ExcelFormatMode.CensimentoRoma)]
    public string Locazione => this.Ubicazione + ", " + this.Citta;

    [ExcelExport("N", 10, ExcelFormatMode.CensimentoRoma)]
    public string Civico
    {
      get => this._civico;
      set
      {
        this._civico = value;
        this.OnPropertyChanged(nameof (Civico));
      }
    }

    [ExcelExport("N", 12, ExcelFormatMode.CensimentoRoma)]
    public float DiametroTronco
    {
      get => this._diametro_tronco;
      set
      {
        this._diametro_tronco = value;
        this.OnPropertyChanged(nameof (DiametroTronco));
      }
    }

    [ExcelExport("E", 12, ExcelFormatMode.CensimentoRoma)]
    public float AltezzaAlb
    {
      get => this._altezza_alb;
      set
      {
        this._altezza_alb = value;
        this.OnPropertyChanged(nameof (AltezzaAlb));
      }
    }

    [ExcelExport("H", 12, ExcelFormatMode.CensimentoRoma)]
    public float AltezzaTronco
    {
      get => this._altezza_tronco;
      set
      {
        this._altezza_tronco = value;
        this.OnPropertyChanged(nameof (AltezzaTronco));
      }
    }

    [ExcelExport("K", 12, ExcelFormatMode.CensimentoRoma)]
    public float CirconferenzaTronco
    {
      get => this._circonferenza_tronco;
      set
      {
        this._circonferenza_tronco = value;
        this.OnPropertyChanged(nameof (CirconferenzaTronco));
      }
    }

    public int CoeffSnel
    {
      get => this._coeff_snel;
      set
      {
        this._coeff_snel = value;
        this.OnPropertyChanged(nameof (CoeffSnel));
      }
    }

    [ExcelExport("E", 14, ExcelFormatMode.CensimentoRoma)]
    public float DiametroChioma
    {
      get => this._diametro_chioma;
      set
      {
        this._diametro_chioma = value;
        this.OnPropertyChanged(nameof (DiametroChioma));
      }
    }

    [ExcelExport("I", 14, ExcelFormatMode.CensimentoRoma)]
    public string FormaChioma
    {
      get => this._forma_chioma;
      set
      {
        this._forma_chioma = value;
        this.OnPropertyChanged(nameof (FormaChioma));
      }
    }

    public string NoteGenerali
    {
      get => this.p_note;
      set
      {
        this.p_note = value;
        this.OnPropertyChanged(nameof (NoteGenerali));
      }
    }

    [NoExport]
    public string FotoPath
    {
      get => this._fotopath;
      set
      {
        this._fotopath = value;
        this.OnPropertyChanged(nameof (FotoPath));
      }
    }

    [NoExport]
    public bool HasFotoPath => !string.IsNullOrEmpty(this._fotopath);

    [NoExport]
    public string HasPlaceholder => !this.HasFotoPath ? "tree.svg" : "";

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
