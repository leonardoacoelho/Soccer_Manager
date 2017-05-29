namespace SoccerManager.UI.Reports
{
    partial class JogadoresPorPosicaoReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.JogadoresPorPosicaoReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.JogadoresPorPosicaoReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // JogadoresPorPosicaoReportBindingSource
            // 
            this.JogadoresPorPosicaoReportBindingSource.DataSource = typeof(SoccerManager.UI.Reports.JogadoresPorPosicaoReport);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.JogadoresPorPosicaoReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoccerManager.UI.Reports.JogadoresPorPosicaoReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 436);
            this.reportViewer1.TabIndex = 0;
            // 
            // JogadoresPorPosicaoReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 436);
            this.Controls.Add(this.reportViewer1);
            this.Name = "JogadoresPorPosicaoReportForm";
            this.ShowIcon = false;
            this.Text = "Jogadores Por Posição";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JogadoresPorPosicaoReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JogadoresPorPosicaoReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource JogadoresPorPosicaoReportBindingSource;
    }
}