// Decompiled with JetBrains decompiler
// Type: FitoCensus.Data.Record.CensimentoRecord
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using SQLite;
using System.ComponentModel;

namespace FitoCensus.Data.Record
{
  [Table("CensimentoRecord")]
  public class CensimentoRecord : INotifyPropertyChanged
  {
    private int _id;
    private int _id_general;
    private bool _is_imp_alberato_stradale;
    private bool _is_imp_viale_alberato;
    private bool _is_imp_aiuola;
    private bool _is_imp_parco;
    private bool _is_imp_gioco_sport;
    private bool _is_imp_verde_pert;
    private bool _is_int_ingressi_accessi;
    private bool _is_int_uffici_pubblici;
    private bool _is_int_luoghi_culto;
    private bool _is_int_scuola_primaria;
    private bool _is_int_scuola_superiore;
    private bool _is_int_centro_sportivo;
    private bool _is_int_area_elev_freq;
    private bool _is_int_attivita_comm;
    private bool _is_int_manufatti;
    private bool _is_int_sede_stradale;
    private bool _is_int_sede_pedonale;
    private bool _is_int_alta_viabilita;
    private bool _is_vul_trascurabile;
    private bool _is_vul_bassa;
    private bool _is_vul_moderata;
    private bool _is_vul_elevata;
    private bool _is_vul_estrema;
    private bool _is_fit_buono;
    private bool _is_fit_discreto;
    private bool _is_fit_modesto;
    private bool _is_fit_scarso;
    private bool _is_fit_grave;
    private bool _is_tri_verde;
    private bool _is_tri_giallo;
    private bool _is_tri_rosso;
    private bool _is_ver_non_necessaria;
    private bool _is_ver_visiva_avanzata;
    private bool _is_ver_scoll_radicale;
    private bool _is_ver_resi_colletto;
    private bool _is_ver_resi_fusto;
    private bool _is_ver_tomografia_son;
    private bool _is_ver_tomografia_elet;
    private bool _is_ver_pulling_test;
    private bool _is_ver_analisi_dinamica;
    private bool _is_ver_va_quota;
    private bool _is_ver_strum_quota;
    private bool _is_ver_contr_inclino;
    private string p_note;

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

    public bool IsImpAlberatoStradale
    {
      get => this._is_imp_alberato_stradale;
      set
      {
        this._is_imp_alberato_stradale = value;
        this.OnPropertyChanged(nameof (IsImpAlberatoStradale));
      }
    }

    public bool IsImpVialeAlberato
    {
      get => this._is_imp_viale_alberato;
      set
      {
        this._is_imp_viale_alberato = value;
        this.OnPropertyChanged(nameof (IsImpVialeAlberato));
      }
    }

    public bool IsImpAiuola
    {
      get => this._is_imp_aiuola;
      set
      {
        this._is_imp_aiuola = value;
        this.OnPropertyChanged(nameof (IsImpAiuola));
      }
    }

    public bool IsImpParco
    {
      get => this._is_imp_parco;
      set
      {
        this._is_imp_parco = value;
        this.OnPropertyChanged(nameof (IsImpParco));
      }
    }

    public bool IsImpGiocoSport
    {
      get => this._is_imp_gioco_sport;
      set
      {
        this._is_imp_gioco_sport = value;
        this.OnPropertyChanged(nameof (IsImpGiocoSport));
      }
    }

    public bool IsImpVerdePert
    {
      get => this._is_imp_verde_pert;
      set
      {
        this._is_imp_verde_pert = value;
        this.OnPropertyChanged(nameof (IsImpVerdePert));
      }
    }

    public bool IsIntIngressiAccessi
    {
      get => this._is_int_ingressi_accessi;
      set
      {
        this._is_int_ingressi_accessi = value;
        this.OnPropertyChanged(nameof (IsIntIngressiAccessi));
      }
    }

    public bool IsIntUfficiPubblici
    {
      get => this._is_int_uffici_pubblici;
      set
      {
        this._is_int_uffici_pubblici = value;
        this.OnPropertyChanged(nameof (IsIntUfficiPubblici));
      }
    }

    public bool IsIntLuoghiCulto
    {
      get => this._is_int_luoghi_culto;
      set
      {
        this._is_int_luoghi_culto = value;
        this.OnPropertyChanged(nameof (IsIntLuoghiCulto));
      }
    }

    public bool IsIntScuolaPrimaria
    {
      get => this._is_int_scuola_primaria;
      set
      {
        this._is_int_scuola_primaria = value;
        this.OnPropertyChanged(nameof (IsIntScuolaPrimaria));
      }
    }

    public bool IsIntScuolaSuperiore
    {
      get => this._is_int_scuola_superiore;
      set
      {
        this._is_int_scuola_superiore = value;
        this.OnPropertyChanged(nameof (IsIntScuolaSuperiore));
      }
    }

    public bool IsIntCentroSportivo
    {
      get => this._is_int_centro_sportivo;
      set
      {
        this._is_int_centro_sportivo = value;
        this.OnPropertyChanged(nameof (IsIntCentroSportivo));
      }
    }

    public bool IsIntAreaElevFreq
    {
      get => this._is_int_area_elev_freq;
      set
      {
        this._is_int_area_elev_freq = value;
        this.OnPropertyChanged(nameof (IsIntAreaElevFreq));
      }
    }

    public bool IsIntAttivitaComm
    {
      get => this._is_int_attivita_comm;
      set
      {
        this._is_int_attivita_comm = value;
        this.OnPropertyChanged(nameof (IsIntAttivitaComm));
      }
    }

    public bool IsIntManufatti
    {
      get => this._is_int_manufatti;
      set
      {
        this._is_int_manufatti = value;
        this.OnPropertyChanged(nameof (IsIntManufatti));
      }
    }

    public bool IsIntSedeStradale
    {
      get => this._is_int_sede_stradale;
      set
      {
        this._is_int_sede_stradale = value;
        this.OnPropertyChanged(nameof (IsIntSedeStradale));
      }
    }

    public bool IsIntSedePedonale
    {
      get => this._is_int_sede_pedonale;
      set
      {
        this._is_int_sede_pedonale = value;
        this.OnPropertyChanged("IsIntSedeStradale");
      }
    }

    public bool IsIntAltaViabilita
    {
      get => this._is_int_alta_viabilita;
      set
      {
        this._is_int_alta_viabilita = value;
        this.OnPropertyChanged(nameof (IsIntAltaViabilita));
      }
    }

    public bool IsVulTrascurabile
    {
      get => this._is_vul_trascurabile;
      set
      {
        this._is_vul_trascurabile = value;
        this.OnPropertyChanged(nameof (IsVulTrascurabile));
      }
    }

    public bool IsVulBassa
    {
      get => this._is_vul_bassa;
      set
      {
        this._is_vul_bassa = value;
        this.OnPropertyChanged(nameof (IsVulBassa));
      }
    }

    public bool IsVulModerata
    {
      get => this._is_vul_moderata;
      set
      {
        this._is_vul_moderata = value;
        this.OnPropertyChanged(nameof (IsVulModerata));
      }
    }

    public bool IsVulElevata
    {
      get => this._is_vul_elevata;
      set
      {
        this._is_vul_elevata = value;
        this.OnPropertyChanged(nameof (IsVulElevata));
      }
    }

    public bool IsVulEstrema
    {
      get => this._is_vul_estrema;
      set
      {
        this._is_vul_estrema = value;
        this.OnPropertyChanged(nameof (IsVulEstrema));
      }
    }

    public bool IsFitBuono
    {
      get => this._is_fit_buono;
      set
      {
        this._is_fit_buono = value;
        this.OnPropertyChanged(nameof (IsFitBuono));
      }
    }

    public bool IsFitDiscreto
    {
      get => this._is_fit_discreto;
      set
      {
        this._is_fit_discreto = value;
        this.OnPropertyChanged(nameof (IsFitDiscreto));
      }
    }

    public bool IsFitModesto
    {
      get => this._is_fit_modesto;
      set
      {
        this._is_fit_modesto = value;
        this.OnPropertyChanged(nameof (IsFitModesto));
      }
    }

    public bool IsFitScarso
    {
      get => this._is_fit_scarso;
      set
      {
        this._is_fit_scarso = value;
        this.OnPropertyChanged(nameof (IsFitScarso));
      }
    }

    public bool IsFitGrave
    {
      get => this._is_fit_grave;
      set
      {
        this._is_fit_grave = value;
        this.OnPropertyChanged(nameof (IsFitGrave));
      }
    }

    public bool IsTriVerde
    {
      get => this._is_tri_verde;
      set
      {
        this._is_tri_verde = value;
        this.OnPropertyChanged(nameof (IsTriVerde));
      }
    }

    public bool IsTriGiallo
    {
      get => this._is_tri_giallo;
      set
      {
        this._is_tri_giallo = value;
        this.OnPropertyChanged(nameof (IsTriGiallo));
      }
    }

    public bool IsTriRosso
    {
      get => this._is_tri_rosso;
      set
      {
        this._is_tri_rosso = value;
        this.OnPropertyChanged(nameof (IsTriRosso));
      }
    }

    public bool IsVerNonNecessaria
    {
      get => this._is_ver_non_necessaria;
      set
      {
        this._is_ver_non_necessaria = value;
        this.OnPropertyChanged(nameof (IsVerNonNecessaria));
      }
    }

    public bool IsVerVisivaAvanzata
    {
      get => this._is_ver_visiva_avanzata;
      set
      {
        this._is_ver_visiva_avanzata = value;
        this.OnPropertyChanged(nameof (IsVerVisivaAvanzata));
      }
    }

    public bool IsVerScollRadicale
    {
      get => this._is_ver_scoll_radicale;
      set
      {
        this._is_ver_scoll_radicale = value;
        this.OnPropertyChanged(nameof (IsVerScollRadicale));
      }
    }

    public bool IsVerResiColletto
    {
      get => this._is_ver_resi_colletto;
      set
      {
        this._is_ver_resi_colletto = value;
        this.OnPropertyChanged(nameof (IsVerResiColletto));
      }
    }

    public bool IsVerResiFusto
    {
      get => this._is_ver_resi_fusto;
      set
      {
        this._is_ver_resi_fusto = value;
        this.OnPropertyChanged(nameof (IsVerResiFusto));
      }
    }

    public bool IsVerTomografiaSon
    {
      get => this._is_ver_tomografia_son;
      set
      {
        this._is_ver_tomografia_son = value;
        this.OnPropertyChanged(nameof (IsVerTomografiaSon));
      }
    }

    public bool IsVerTomografiaElet
    {
      get => this._is_ver_tomografia_elet;
      set
      {
        this._is_ver_tomografia_elet = value;
        this.OnPropertyChanged(nameof (IsVerTomografiaElet));
      }
    }

    public bool IsVerPullingTest
    {
      get => this._is_ver_pulling_test;
      set
      {
        this._is_ver_pulling_test = value;
        this.OnPropertyChanged(nameof (IsVerPullingTest));
      }
    }

    public bool IsVerAnalisiDinamica
    {
      get => this._is_ver_analisi_dinamica;
      set
      {
        this._is_ver_analisi_dinamica = value;
        this.OnPropertyChanged(nameof (IsVerAnalisiDinamica));
      }
    }

    public bool IsVerVaQuota
    {
      get => this._is_ver_va_quota;
      set
      {
        this._is_ver_va_quota = value;
        this.OnPropertyChanged(nameof (IsVerVaQuota));
      }
    }

    public bool IsVerStrumQuota
    {
      get => this._is_ver_strum_quota;
      set
      {
        this._is_ver_strum_quota = value;
        this.OnPropertyChanged(nameof (IsVerStrumQuota));
      }
    }

    public bool IsVerContrInclino
    {
      get => this._is_ver_contr_inclino;
      set
      {
        this._is_ver_contr_inclino = value;
        this.OnPropertyChanged(nameof (IsVerContrInclino));
      }
    }

    public string NoteCensimento
    {
      get => this.p_note;
      set
      {
        this.p_note = value;
        this.OnPropertyChanged(nameof (NoteCensimento));
      }
    }

    [NoExport]
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
