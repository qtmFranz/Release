// Decompiled with JetBrains decompiler
// Type: FitoCensusDsk.Form1
// Assembly: FitoCensusDsk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86D36651-69FA-4457-841F-2898A43F4421
// Assembly location: C:\Users\fsghe\Desktop\FITOCONVERTER MARZO 2022\FitoCensusDsk.exe

using FitoCensusDesktop.Export;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FitoCensusDsk
{
  public class Form1 : Form
  {
    private string current_file = "";
    private IContainer components = (IContainer) null;
    private Button loadExportFileBtn;
    private GroupBox groupBox2;
    private RadioButton rdResExp;
    private RadioButton rdCensExp;
    private RadioButton rdCmlExp;
    private Panel dragPanel;
    private Label label1;

    public Form1()
    {
      this.InitializeComponent();
      this.AllowDrop = true;
      this.dragPanel.AllowDrop = true;
      this.dragPanel.DragEnter += new DragEventHandler(this.DragPanel_DragEnter);
      this.dragPanel.DragLeave += new EventHandler(this.DragPanel_DragLeave);
      this.dragPanel.DragDrop += new DragEventHandler(this.DragPanel_DragDrop);
    }

    private void DragPanel_DragDrop(object sender, DragEventArgs e) => this.current_file = ((string[]) e.Data.GetData(DataFormats.FileDrop))[0];

    private void DragPanel_DragLeave(object sender, EventArgs e) => this.dragPanel.BackColor = Color.Transparent;

    private void DragPanel_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Copy;
      this.dragPanel.BackColor = Color.Cyan;
    }

    private void loadExportFileBtn_Click(object sender, EventArgs e)
    {
      string currentFile = this.current_file;
      string directoryName = Path.GetDirectoryName(currentFile);
            ExportManager.InputType = FileType.Tsv;
      ExportManager.InputFilePath = currentFile;
      ExportManager.OutputFilePath = directoryName;
      if (this.rdCensExp.Checked || this.rdCmlExp.Checked)
        ExportManager.Export();
      if (this.rdResExp.Checked || this.rdCmlExp.Checked)
        ExportManager.ExportResume();
      int num = (int) MessageBox.Show("Completato");
      Process.Start(directoryName);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      ExportManager.ModelFilePath = "model3.xlsx";
      ExportManager.PlainModelPath = "plain_model2.xlsx";
      ExportManager.ExportInfoCallback += new ExportManager.ExportInfo(this.ExportManager_ExportInfoCallback);
    }

    private void ExportManager_ExportInfoCallback(ExportInfoEventArgs eventArgs)
    {
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.loadExportFileBtn = new Button();
      this.groupBox2 = new GroupBox();
      this.rdCmlExp = new RadioButton();
      this.rdResExp = new RadioButton();
      this.rdCensExp = new RadioButton();
      this.dragPanel = new Panel();
      this.label1 = new Label();
      this.groupBox2.SuspendLayout();
      this.dragPanel.SuspendLayout();
      this.SuspendLayout();
      this.loadExportFileBtn.BackColor = Color.LightGreen;
      this.loadExportFileBtn.Font = new Font("Microsoft Sans Serif", 16.1f);
      this.loadExportFileBtn.Location = new Point(1229, 457);
      this.loadExportFileBtn.Name = "loadExportFileBtn";
      this.loadExportFileBtn.Size = new Size(380, 131);
      this.loadExportFileBtn.TabIndex = 0;
      this.loadExportFileBtn.Text = "Converti";
      this.loadExportFileBtn.UseVisualStyleBackColor = false;
      this.loadExportFileBtn.Click += new EventHandler(this.loadExportFileBtn_Click);
      this.groupBox2.Controls.Add((Control) this.rdCmlExp);
      this.groupBox2.Controls.Add((Control) this.rdResExp);
      this.groupBox2.Controls.Add((Control) this.rdCensExp);
      this.groupBox2.Location = new Point(1229, 41);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(355, (int) byte.MaxValue);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Modello Esportazione";
      this.rdCmlExp.AutoSize = true;
      this.rdCmlExp.Location = new Point(32, 154);
      this.rdCmlExp.Name = "rdCmlExp";
      this.rdCmlExp.Size = new Size(175, 36);
      this.rdCmlExp.TabIndex = 2;
      this.rdCmlExp.Text = "Entrambe";
      this.rdCmlExp.UseVisualStyleBackColor = true;
      this.rdResExp.AutoSize = true;
      this.rdResExp.Location = new Point(33, 103);
      this.rdResExp.Name = "rdResExp";
      this.rdResExp.Size = new Size(317, 36);
      this.rdResExp.TabIndex = 1;
      this.rdResExp.Text = "Resoconto Completo";
      this.rdResExp.UseVisualStyleBackColor = true;
      this.rdCensExp.AutoSize = true;
      this.rdCensExp.Checked = true;
      this.rdCensExp.Location = new Point(33, 51);
      this.rdCensExp.Name = "rdCensExp";
      this.rdCensExp.Size = new Size(286, 36);
      this.rdCensExp.TabIndex = 0;
      this.rdCensExp.TabStop = true;
      this.rdCensExp.Text = "Censimento Roma";
      this.rdCensExp.UseVisualStyleBackColor = true;
      this.rdCensExp.CheckedChanged += new EventHandler(this.radioButton4_CheckedChanged);
      this.dragPanel.AllowDrop = true;
      this.dragPanel.Controls.Add((Control) this.label1);
      this.dragPanel.Location = new Point(12, 12);
      this.dragPanel.Name = "dragPanel";
      this.dragPanel.Size = new Size(1192, 576);
      this.dragPanel.TabIndex = 7;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(284, 252);
      this.label1.Name = "label1";
      this.label1.Size = new Size(568, 32);
      this.label1.TabIndex = 0;
      this.label1.Text = "Trascina qui il file da convertire (.json o .zip)";
      this.AutoScaleDimensions = new SizeF(16f, 31f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ControlLight;
      this.ClientSize = new Size(1621, 650);
      this.Controls.Add((Control) this.dragPanel);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.loadExportFileBtn);
      this.Name = nameof (Form1);
      this.Text = "FitoCensusDesktopDemo";
      this.Load += new EventHandler(this.Form1_Load);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.dragPanel.ResumeLayout(false);
      this.dragPanel.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
