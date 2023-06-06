// Decompiled with JetBrains decompiler
// Type: FitoCensus.Data.Record.FitoRecord
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using SQLite;
using System.ComponentModel;

namespace FitoCensus.Data.Record
{
  public class FitoRecord : INotifyPropertyChanged
  {
    private int _id;
    private int _id_general;
    private bool f_maculature;
    private bool f_spot;
    private bool f_erosioni = false;
    private bool f_minature = false;
    private bool r_cancri = false;
    private bool r_strozzature = false;
    private bool r_carie = false;
    private bool r_gallerie = false;
    private bool t_cancro = false;
    private bool t_tumore;
    private bool t_carie = false;
    private bool t_carpofori = false;
    private bool t_fori_insetti = false;
    private string p_note;

    [PrimaryKey]
    [AutoIncrement]
    [NoExport]
    public int Id
    {
      get => this._id;
      set
      {
        this._id = value;
        this.OnPropertyChanged(nameof (Id));
      }
    }

    [NoExport]
    public int GeneralId
    {
      get => this._id_general;
      set
      {
        this._id_general = value;
        this.OnPropertyChanged(nameof (GeneralId));
      }
    }

    public bool IsMaculatureFoglie
    {
      get => this.f_maculature;
      set
      {
        this.f_maculature = value;
        this.OnPropertyChanged(nameof (IsMaculatureFoglie));
      }
    }

    public bool IsSpotFoglie
    {
      get => this.f_spot;
      set
      {
        this.f_spot = value;
        this.OnPropertyChanged(nameof (IsSpotFoglie));
      }
    }

    public bool IsErosioniFoglie
    {
      get => this.f_erosioni;
      set
      {
        this.f_erosioni = value;
        this.OnPropertyChanged(nameof (IsErosioniFoglie));
      }
    }

    public bool IsMinatureFoglie
    {
      get => this.f_minature;
      set
      {
        this.f_minature = value;
        this.OnPropertyChanged(nameof (IsMinatureFoglie));
      }
    }

    public bool IsCancriRami
    {
      get => this.r_cancri;
      set
      {
        this.r_cancri = value;
        this.OnPropertyChanged(nameof (IsCancriRami));
      }
    }

    public bool IsStrozzatureRami
    {
      get => this.r_strozzature;
      set
      {
        this.r_strozzature = value;
        this.OnPropertyChanged(nameof (IsStrozzatureRami));
      }
    }

    public bool IsCarieRami
    {
      get => this.r_carie;
      set
      {
        this.r_carie = value;
        this.OnPropertyChanged(nameof (IsCarieRami));
      }
    }

    public bool IsGallerieRami
    {
      get => this.r_gallerie;
      set
      {
        this.r_gallerie = value;
        this.OnPropertyChanged(nameof (IsGallerieRami));
      }
    }

    public bool IsCancroTronco
    {
      get => this.t_cancro;
      set
      {
        this.t_cancro = value;
        this.OnPropertyChanged(nameof (IsCancroTronco));
      }
    }

    public bool IsTumoreTronco
    {
      get => this.t_tumore;
      set
      {
        this.t_tumore = value;
        this.OnPropertyChanged(nameof (IsTumoreTronco));
      }
    }

    public bool IsCarieTronco
    {
      get => this.t_carie;
      set
      {
        this.t_carie = value;
        this.OnPropertyChanged(nameof (IsCarieTronco));
      }
    }

    public bool IsCarpoforiTronco
    {
      get => this.t_carpofori;
      set
      {
        this.t_carpofori = value;
        this.OnPropertyChanged(nameof (IsCarpoforiTronco));
      }
    }

    public bool IsForiInsettiTronco
    {
      get => this.t_fori_insetti;
      set
      {
        this.t_fori_insetti = value;
        this.OnPropertyChanged(nameof (IsForiInsettiTronco));
      }
    }

    public string NotePatologia
    {
      get => this.p_note;
      set
      {
        this.p_note = value;
        this.OnPropertyChanged(nameof (NotePatologia));
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
