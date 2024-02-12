// Decompiled with JetBrains decompiler
// Type: XNBExport.Form1
// Assembly: XNBExport, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F8623A86-D234-4E52-8F18-222BFB81F914
// Assembly location: C:\Users\Admin\Desktop\RE\XNBExporter\XNBExport-xna31.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace XNBExport
{
  public class Form1 : Form
  {
    private Button button1;
    private IContainer components;
    private Label label1;
    private TextBox textBox1;

    public Form1() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e)
    {
      new Thread((ParameterizedThreadStart) (name => new ExportGame((string) name).Run())).Start((object) this.textBox1.Text);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.textBox1 = new TextBox();
      this.button1 = new Button();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new Size(115, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Filename (without .xnb)";
      this.textBox1.Location = new Point(134, 10);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(291, 20);
      this.textBox1.TabIndex = 1;
      this.button1.Location = new Point(16, 40);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Go for it!";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(437, 83);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (Form1);
      this.Text = "XNB Exporter";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
