// Decompiled with JetBrains decompiler
// Type: FitoCensus.Data.Record.SpeditivaRecord
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using FitoCensusDesktop.Export;
using SQLite;
using System.ComponentModel;

namespace FitoCensus.Data.Record
{
  [Table("SpeditivaRecord")]
  public class SpeditivaRecord : INotifyPropertyChanged
  {
    private int _id;
    private int _id_general;
    private bool _clt_azzampato = false;
    private bool _clt_cavita = false;
    private bool _clt_carie = false;
    private bool _clt_carpofori = false;
    private bool _clt_radici_strozz = false;
    private bool _clt_depressioni = false;
    private bool _clt_soll_ceppaia = false;
    private bool _clt_scavi_rec = false;
    private string _clt_altro;
    private bool _fst_filato = false;
    private bool _fst_arcuato = false;
    private bool _fst_inclinato = false;
    private bool _fst_torsione = false;
    private bool _fst_fessure = false;
    private bool _fst_depressioni = false;
    private bool _fst_cavita = false;
    private bool _fst_carpofori = false;
    private string _fst_altro = string.Empty;
    private bool _chm_asimmetrica = false;
    private bool _chm_sbilanciata = false;
    private bool _chm_cime_secche = false;
    private bool _chm_branche_stronc = false;
    private bool _chm_ferite_pot = false;
    private bool _chm_seccume_diff = false;
    private bool _chm_parassiti = false;
    private bool _chm_clorosi = false;
    private string _chm_altro = string.Empty;
    private bool _int_potatura = false;
    private bool _int_rimonda = false;
    private bool _int_abbattimento = false;
    private bool _int_verifica = false;
    private bool _tmp_emergenza = false;
    private bool _tmp_urgente = false;
    private bool _tmp_necessario = false;
    private bool _tmp_consigliato = false;
    private bool _is_pos_isolato;
    private bool _is_pos_filare;
    private bool _is_pos_doppio_filare;
    private bool _is_pos_gruppo_puro;
    private bool _is_pos_gruppo_misto;
    private bool _is_pos_giardino;
    private bool _is_pos_parco;
    private bool _is_pos_altro;
    private bool _is_for_esemplare;
    private bool _is_for_I;
    private bool _is_for_II;
    private bool _is_for_III;
    private bool _is_for_nuovo_imp;
    private bool _is_sede_t_imperm = false;
    private bool _is_sede_t_perm = false;
    private bool _is_sede_t_asfalto = false;
    private bool _is_sede_t_pavimentazione = false;
    private bool _is_sede_t_aiuola = false;
    private bool _is_infr_sottoservizi = false;
    private bool _is_infr_monumenti = false;
    private bool _is_infr_linee_aeree = false;
    private bool _is_infr_muri_confine = false;
    private bool _is_infr_altro = false;
    private string _is_infr_altro_note;
    private bool _is_freq_alta;
    private bool _is_freq_media;
    private bool _is_freq_bassa;
    private bool _is_ber_strada = false;
    private bool _is_ber_scuola = false;
    private bool _is_ber_fabbr = false;
    private bool _is_ber_verde_quartiere = false;
    private bool _is_ber_giardino_centro_urbano = false;
    private bool _is_ber_parchi_centro_urbano = false;
    private bool _is_ber_verde_estensivo = false;

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

    [ExcelExport("D", 33, ExcelFormatMode.CensimentoRoma)]
    public bool IsCollettoAzzampato
    {
      get => this._clt_azzampato;
      set
      {
        this._clt_azzampato = value;
        this.OnPropertyChanged("_clt_azzampato");
      }
    }

    [ExcelExport("D", 35, ExcelFormatMode.CensimentoRoma)]
    public bool IsCollettoCavita
    {
      get => this._clt_cavita;
      set
      {
        this._clt_cavita = value;
        this.OnPropertyChanged("_clt_cavita");
      }
    }

    [ExcelExport("D", 37, ExcelFormatMode.CensimentoRoma)]
    public bool IsCollettoCarie
    {
      get => this._clt_carie;
      set
      {
        this._clt_carie = value;
        this.OnPropertyChanged("_clt_carie");
      }
    }

    [ExcelExport("D", 39, ExcelFormatMode.CensimentoRoma)]
    public bool IsCollettoCarpofori
    {
      get => this._clt_carpofori;
      set
      {
        this._clt_carpofori = value;
        this.OnPropertyChanged("_clt_carpofori");
      }
    }

    [ExcelExport("D", 41, ExcelFormatMode.CensimentoRoma)]
    public bool IsCollettoRadiciStrozzanti
    {
      get => this._clt_radici_strozz;
      set
      {
        this._clt_radici_strozz = value;
        this.OnPropertyChanged("_clt_radici_strozz");
      }
    }

    [ExcelExport("K", 33, ExcelFormatMode.CensimentoRoma)]
    public bool IsCollettoDepressioni
    {
      get => this._clt_depressioni;
      set
      {
        this._clt_depressioni = value;
        this.OnPropertyChanged("_clt_depressioni");
      }
    }

    [ExcelExport("K", 35, ExcelFormatMode.CensimentoRoma)]
    public bool IsCollettoSollevamentoCeppaia
    {
      get => this._clt_soll_ceppaia;
      set
      {
        this._clt_soll_ceppaia = value;
        this.OnPropertyChanged("_clt_soll_ceppaia");
      }
    }

    [ExcelExport("K", 37, ExcelFormatMode.CensimentoRoma)]
    public bool IsCollettoScaviRecenti
    {
      get => this._clt_scavi_rec;
      set
      {
        this._clt_scavi_rec = value;
        this.OnPropertyChanged("_clt_scavi_rec");
      }
    }

    [ExcelExport("K", 39, ExcelFormatMode.CensimentoRoma)]
    public string IsCollettoAltro
    {
      get => this._clt_altro;
      set
      {
        this._clt_altro = value;
        this.OnPropertyChanged("_clt_altro");
      }
    }

    [ExcelExport("D", 46, ExcelFormatMode.CensimentoRoma)]
    public bool IsFustoFilato
    {
      get => this._fst_filato;
      set
      {
        this._fst_filato = value;
        this.OnPropertyChanged("_fst_filato");
      }
    }

    [ExcelExport("D", 48, ExcelFormatMode.CensimentoRoma)]
    public bool IsFustoArcuato
    {
      get => this._fst_arcuato;
      set
      {
        this._fst_arcuato = value;
        this.OnPropertyChanged("_fst_arcuato");
      }
    }

    [ExcelExport("D", 50, ExcelFormatMode.CensimentoRoma)]
    public bool IsFustoInclinato
    {
      get => this._fst_inclinato;
      set
      {
        this._fst_inclinato = value;
        this.OnPropertyChanged("_fst_inclinato");
      }
    }

    [ExcelExport("D", 52, ExcelFormatMode.CensimentoRoma)]
    public bool IsFustoTorsione
    {
      get => this._fst_torsione;
      set
      {
        this._fst_torsione = value;
        this.OnPropertyChanged("_fst_torsione");
      }
    }

    [ExcelExport("D", 54, ExcelFormatMode.CensimentoRoma)]
    public bool IsFustoFessure
    {
      get => this._fst_fessure;
      set
      {
        this._fst_fessure = value;
        this.OnPropertyChanged("_fst_fessure");
      }
    }

    [ExcelExport("K", 46, ExcelFormatMode.CensimentoRoma)]
    public bool IsFustoDepressioni
    {
      get => this._fst_depressioni;
      set
      {
        this._fst_depressioni = value;
        this.OnPropertyChanged("_fst_depressioni");
      }
    }

    [ExcelExport("K", 48, ExcelFormatMode.CensimentoRoma)]
    public bool IsFustoCavita
    {
      get => this._fst_cavita;
      set
      {
        this._fst_cavita = value;
        this.OnPropertyChanged("_fst_cavita");
      }
    }

    [ExcelExport("K", 50, ExcelFormatMode.CensimentoRoma)]
    public bool IsFustoCarpofori
    {
      get => this._fst_carpofori;
      set
      {
        this._fst_carpofori = value;
        this.OnPropertyChanged("_fst_carpofori");
      }
    }

    [ExcelExport("K", 52, ExcelFormatMode.CensimentoRoma)]
    public string IsFustoAltro
    {
      get => this._fst_altro;
      set
      {
        this._fst_altro = value;
        this.OnPropertyChanged("_fst_altro");
      }
    }

    [ExcelExport("D", 59, ExcelFormatMode.CensimentoRoma)]
    public bool IsChiomaAsimmetrica
    {
      get => this._chm_asimmetrica;
      set
      {
        this._chm_asimmetrica = value;
        this.OnPropertyChanged("_chm_asimmetrica");
      }
    }

    [ExcelExport("D", 61, ExcelFormatMode.CensimentoRoma)]
    public bool IsChiomaSbilanciata
    {
      get => this._chm_sbilanciata;
      set
      {
        this._chm_sbilanciata = value;
        this.OnPropertyChanged("_chm_sbilanciata");
      }
    }

    [ExcelExport("D", 63, ExcelFormatMode.CensimentoRoma)]
    public bool IsChiomaCimeSecche
    {
      get => this._chm_cime_secche;
      set
      {
        this._chm_cime_secche = value;
        this.OnPropertyChanged("_chm_cime_secche");
      }
    }

    [ExcelExport("D", 65, ExcelFormatMode.CensimentoRoma)]
    public bool IsChiomaBrancheStroncate
    {
      get => this._chm_branche_stronc;
      set
      {
        this._chm_branche_stronc = value;
        this.OnPropertyChanged("_chm_branche_stronc");
      }
    }

    [ExcelExport("D", 67, ExcelFormatMode.CensimentoRoma)]
    public bool IsChiomaFeritePotatura
    {
      get => this._chm_ferite_pot;
      set
      {
        this._chm_ferite_pot = value;
        this.OnPropertyChanged("_chm_ferite_pot");
      }
    }

    [ExcelExport("K", 59, ExcelFormatMode.CensimentoRoma)]
    public bool IsChiomaSeccumeDiffuso
    {
      get => this._chm_seccume_diff;
      set
      {
        this._chm_seccume_diff = value;
        this.OnPropertyChanged("_chm_seccume_diff");
      }
    }

    [ExcelExport("K", 61, ExcelFormatMode.CensimentoRoma)]
    public bool IsChiomaParassiti
    {
      get => this._chm_parassiti;
      set
      {
        this._chm_parassiti = value;
        this.OnPropertyChanged("_chm_parassiti");
      }
    }

    [ExcelExport("D", 63, ExcelFormatMode.CensimentoRoma)]
    public bool IsChiomaClorosi
    {
      get => this._chm_clorosi;
      set
      {
        this._chm_clorosi = value;
        this.OnPropertyChanged("_chm_clorosi");
      }
    }

    [ExcelExport("D", 65, ExcelFormatMode.CensimentoRoma)]
    public string IsChiomaAltro
    {
      get => this._chm_altro;
      set
      {
        this._chm_altro = value;
        this.OnPropertyChanged("_chm_altro");
      }
    }

    [ExcelExport("B", 85, ExcelFormatMode.CensimentoRoma)]
    public bool IsIntPotatura
    {
      get => this._int_potatura;
      set
      {
        this._int_potatura = value;
        this.OnPropertyChanged(nameof (IsIntPotatura));
      }
    }

    [ExcelExport("B", 87, ExcelFormatMode.CensimentoRoma)]
    public bool IsIntRimonda
    {
      get => this._int_rimonda;
      set
      {
        this._int_rimonda = value;
        this.OnPropertyChanged(nameof (IsIntRimonda));
      }
    }

    [ExcelExport("B", 89, ExcelFormatMode.CensimentoRoma)]
    public bool IsIntAbbattimento
    {
      get => this._int_abbattimento;
      set
      {
        this._int_abbattimento = value;
        this.OnPropertyChanged(nameof (IsIntAbbattimento));
      }
    }

    [ExcelExport("B", 91, ExcelFormatMode.CensimentoRoma)]
    public bool IsIntVerificaFitostatica
    {
      get => this._int_verifica;
      set
      {
        this._int_verifica = value;
        this.OnPropertyChanged(nameof (IsIntVerificaFitostatica));
      }
    }

    [ExcelExport("G", 85, ExcelFormatMode.CensimentoRoma)]
    public bool IsTmpEmergenza
    {
      get => this._tmp_emergenza;
      set
      {
        this._tmp_emergenza = value;
        this.OnPropertyChanged(nameof (IsTmpEmergenza));
      }
    }

    [ExcelExport("G", 87, ExcelFormatMode.CensimentoRoma)]
    public bool IsTmpUrgente
    {
      get => this._tmp_urgente;
      set
      {
        this._tmp_urgente = value;
        this.OnPropertyChanged(nameof (IsTmpUrgente));
      }
    }

    [ExcelExport("G", 89, ExcelFormatMode.CensimentoRoma)]
    public bool IsTmpNecessario
    {
      get => this._tmp_necessario;
      set
      {
        this._tmp_necessario = value;
        this.OnPropertyChanged(nameof (IsTmpNecessario));
      }
    }

    [ExcelExport("G", 91, ExcelFormatMode.CensimentoRoma)]
    public bool IsTmpConsigliato
    {
      get => this._tmp_consigliato;
      set
      {
        this._tmp_consigliato = value;
        this.OnPropertyChanged(nameof (IsTmpConsigliato));
      }
    }

    [ExcelExport("E", 18, ExcelFormatMode.CensimentoRoma)]
    public bool IsPosIsolato
    {
      get => this._is_pos_isolato;
      set
      {
        this._is_pos_isolato = value;
        this.OnPropertyChanged(nameof (IsPosIsolato));
      }
    }

    [ExcelExport("E", 20, ExcelFormatMode.CensimentoRoma)]
    public bool IsPosFilare
    {
      get => this._is_pos_filare;
      set
      {
        this._is_pos_filare = value;
        this.OnPropertyChanged(nameof (IsPosFilare));
      }
    }

    [ExcelExport("E", 22, ExcelFormatMode.CensimentoRoma)]
    public bool IsPosDoppioFilare
    {
      get => this._is_pos_doppio_filare;
      set
      {
        this._is_pos_doppio_filare = value;
        this.OnPropertyChanged(nameof (IsPosDoppioFilare));
      }
    }

    public bool IsPosGruppoPuro
    {
      get => this._is_pos_gruppo_puro;
      set
      {
        this._is_pos_gruppo_puro = value;
        this.OnPropertyChanged(nameof (IsPosGruppoPuro));
      }
    }

    public bool IsPosGruppoMisto
    {
      get => this._is_pos_gruppo_misto;
      set
      {
        this._is_pos_gruppo_misto = value;
        this.OnPropertyChanged(nameof (IsPosGruppoMisto));
      }
    }

    [ExcelExport("E", 24, ExcelFormatMode.CensimentoRoma)]
    public bool IsPosGiardino
    {
      get => this._is_pos_giardino;
      set
      {
        this._is_pos_giardino = value;
        this.OnPropertyChanged(nameof (IsPosGiardino));
      }
    }

    [ExcelExport("E", 26, ExcelFormatMode.CensimentoRoma)]
    public bool IsPosParco
    {
      get => this._is_pos_parco;
      set
      {
        this._is_pos_parco = value;
        this.OnPropertyChanged(nameof (IsPosParco));
      }
    }

    public bool IsPosAltro
    {
      get => this._is_pos_altro;
      set
      {
        this._is_pos_altro = value;
        this.OnPropertyChanged(nameof (IsPosAltro));
      }
    }

    [ExcelExport("B", 18, ExcelFormatMode.CensimentoRoma)]
    public bool IsForzaEsemplare
    {
      get => this._is_for_esemplare;
      set
      {
        this._is_for_esemplare = value;
        this.OnPropertyChanged(nameof (IsForzaEsemplare));
      }
    }

    [ExcelExport("B", 20, ExcelFormatMode.CensimentoRoma)]
    public bool IsForzaI
    {
      get => this._is_for_I;
      set
      {
        this._is_for_I = value;
        this.OnPropertyChanged(nameof (IsForzaI));
      }
    }

    [ExcelExport("B", 22, ExcelFormatMode.CensimentoRoma)]
    public bool IsForzaII
    {
      get => this._is_for_II;
      set
      {
        this._is_for_II = value;
        this.OnPropertyChanged(nameof (IsForzaII));
      }
    }

    [ExcelExport("B", 24, ExcelFormatMode.CensimentoRoma)]
    public bool IsForzaIII
    {
      get => this._is_for_III;
      set
      {
        this._is_for_III = value;
        this.OnPropertyChanged(nameof (IsForzaIII));
      }
    }

    [ExcelExport("B", 26, ExcelFormatMode.CensimentoRoma)]
    public bool IsForzaNuovoImpianto
    {
      get => this._is_for_nuovo_imp;
      set
      {
        this._is_for_nuovo_imp = value;
        this.OnPropertyChanged(nameof (IsForzaNuovoImpianto));
      }
    }

    [ExcelExport("H", 20, ExcelFormatMode.CensimentoRoma)]
    public bool IsSedeTImperm
    {
      get => this._is_sede_t_imperm;
      set
      {
        this._is_sede_t_imperm = value;
        this.OnPropertyChanged(nameof (IsSedeTImperm));
      }
    }

    [ExcelExport("H", 18, ExcelFormatMode.CensimentoRoma)]
    public bool IsSedeTPerm
    {
      get => this._is_sede_t_perm;
      set
      {
        this._is_sede_t_perm = value;
        this.OnPropertyChanged(nameof (IsSedeTPerm));
      }
    }

    [ExcelExport("H", 22, ExcelFormatMode.CensimentoRoma)]
    public bool IsSedeAsfalto
    {
      get => this._is_sede_t_asfalto;
      set
      {
        this._is_sede_t_asfalto = value;
        this.OnPropertyChanged(nameof (IsSedeAsfalto));
      }
    }

    [ExcelExport("H", 24, ExcelFormatMode.CensimentoRoma)]
    public bool IsSedePavimentazione
    {
      get => this._is_sede_t_pavimentazione;
      set
      {
        this._is_sede_t_pavimentazione = value;
        this.OnPropertyChanged(nameof (IsSedePavimentazione));
      }
    }

    [ExcelExport("H", 26, ExcelFormatMode.CensimentoRoma)]
    public bool IsSedeAiuola
    {
      get => this._is_sede_t_aiuola;
      set
      {
        this._is_sede_t_aiuola = value;
        this.OnPropertyChanged(nameof (IsSedeAiuola));
      }
    }

    [ExcelExport("K", 18, ExcelFormatMode.CensimentoRoma)]
    public bool IsInfrSottoservizi
    {
      get => this._is_infr_sottoservizi;
      set
      {
        this._is_infr_sottoservizi = value;
        this.OnPropertyChanged(nameof (IsInfrSottoservizi));
      }
    }

    [ExcelExport("K", 20, ExcelFormatMode.CensimentoRoma)]
    public bool IsInfrMonumenti
    {
      get => this._is_infr_monumenti;
      set
      {
        this._is_infr_monumenti = value;
        this.OnPropertyChanged(nameof (IsInfrMonumenti));
      }
    }

    [ExcelExport("K", 22, ExcelFormatMode.CensimentoRoma)]
    public bool IsInfrLineeAeree
    {
      get => this._is_infr_linee_aeree;
      set
      {
        this._is_infr_linee_aeree = value;
        this.OnPropertyChanged(nameof (IsInfrLineeAeree));
      }
    }

    [ExcelExport("K", 24, ExcelFormatMode.CensimentoRoma)]
    public bool IsInfrMuriConfine
    {
      get => this._is_infr_muri_confine;
      set
      {
        this._is_infr_muri_confine = value;
        this.OnPropertyChanged(nameof (IsInfrMuriConfine));
      }
    }

    public bool IsInfrAltro
    {
      get => this._is_infr_altro;
      set
      {
        this._is_infr_altro = value;
        this.OnPropertyChanged(nameof (IsInfrAltro));
      }
    }

    [ExcelExport("K", 26, ExcelFormatMode.CensimentoRoma)]
    public string IsInfrAltroNote
    {
      get => this._is_infr_altro_note;
      set
      {
        this._is_infr_altro_note = value;
        this.OnPropertyChanged(nameof (IsInfrAltroNote));
      }
    }

    [ExcelExport("I", 73, ExcelFormatMode.CensimentoRoma)]
    public bool IsFrequentazioneAlta
    {
      get => this._is_freq_alta;
      set
      {
        this._is_freq_alta = value;
        this.OnPropertyChanged(nameof (IsFrequentazioneAlta));
      }
    }

    [ExcelExport("I", 75, ExcelFormatMode.CensimentoRoma)]
    public bool IsFrequentazioneMedia
    {
      get => this._is_freq_media;
      set
      {
        this._is_freq_media = value;
        this.OnPropertyChanged(nameof (IsFrequentazioneMedia));
      }
    }

    [ExcelExport("I", 77, ExcelFormatMode.CensimentoRoma)]
    public bool IsFrequentazioneBassa
    {
      get => this._is_freq_bassa;
      set
      {
        this._is_freq_bassa = value;
        this.OnPropertyChanged(nameof (IsFrequentazioneBassa));
      }
    }

    [ExcelExport("B", 74, ExcelFormatMode.CensimentoRoma)]
    public bool IsBerStrada
    {
      get => this._is_ber_strada;
      set
      {
        this._is_ber_strada = value;
        this.OnPropertyChanged(nameof (IsBerStrada));
      }
    }

    [ExcelExport("B", 75, ExcelFormatMode.CensimentoRoma)]
    public bool IsBerScuola
    {
      get => this._is_ber_scuola;
      set
      {
        this._is_ber_scuola = value;
        this.OnPropertyChanged(nameof (IsBerScuola));
      }
    }

    [ExcelExport("B", 76, ExcelFormatMode.CensimentoRoma)]
    public bool IsBerFabbricato
    {
      get => this._is_ber_fabbr;
      set
      {
        this._is_ber_fabbr = value;
        this.OnPropertyChanged(nameof (IsBerFabbricato));
      }
    }

    [ExcelExport("B", 77, ExcelFormatMode.CensimentoRoma)]
    public bool IsBerVerdeQuartiere
    {
      get => this._is_ber_verde_quartiere;
      set
      {
        this._is_ber_verde_quartiere = value;
        this.OnPropertyChanged(nameof (IsBerVerdeQuartiere));
      }
    }

    [ExcelExport("B", 78, ExcelFormatMode.CensimentoRoma)]
    public bool IsBerGiardinoCentroUrbano
    {
      get => this._is_ber_giardino_centro_urbano;
      set
      {
        this._is_ber_giardino_centro_urbano = value;
        this.OnPropertyChanged(nameof (IsBerGiardinoCentroUrbano));
      }
    }

    [ExcelExport("B", 79, ExcelFormatMode.CensimentoRoma)]
    public bool IsBerParchiCentroUrbano
    {
      get => this._is_ber_parchi_centro_urbano;
      set
      {
        this._is_ber_parchi_centro_urbano = value;
        this.OnPropertyChanged(nameof (IsBerParchiCentroUrbano));
      }
    }

    [ExcelExport("B", 80, ExcelFormatMode.CensimentoRoma)]
    public bool IsBerVerdeEstensivo
    {
      get => this._is_ber_verde_estensivo;
      set
      {
        this._is_ber_verde_estensivo = value;
        this.OnPropertyChanged(nameof (IsBerVerdeEstensivo));
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
