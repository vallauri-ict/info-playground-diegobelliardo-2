﻿
namespace TriggerTest
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.dgvStoricoCancellazioni = new System.Windows.Forms.DataGridView();
            this.dgvStoricoUpdate = new System.Windows.Forms.DataGridView();
            this.btnAggiorna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.AllowUserToDeleteRows = false;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(12, 12);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.RowHeadersVisible = false;
            this.dgvDriver.Size = new System.Drawing.Size(358, 208);
            this.dgvDriver.TabIndex = 0;
            this.dgvDriver.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.OnBeginEdit);
            this.dgvDriver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDblClick);
            // 
            // dgvStoricoCancellazioni
            // 
            this.dgvStoricoCancellazioni.AllowUserToAddRows = false;
            this.dgvStoricoCancellazioni.AllowUserToDeleteRows = false;
            this.dgvStoricoCancellazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoCancellazioni.Location = new System.Drawing.Point(376, 12);
            this.dgvStoricoCancellazioni.Name = "dgvStoricoCancellazioni";
            this.dgvStoricoCancellazioni.Size = new System.Drawing.Size(358, 208);
            this.dgvStoricoCancellazioni.TabIndex = 1;
            // 
            // dgvStoricoUpdate
            // 
            this.dgvStoricoUpdate.AllowUserToAddRows = false;
            this.dgvStoricoUpdate.AllowUserToDeleteRows = false;
            this.dgvStoricoUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoUpdate.Location = new System.Drawing.Point(12, 255);
            this.dgvStoricoUpdate.Name = "dgvStoricoUpdate";
            this.dgvStoricoUpdate.RowHeadersVisible = false;
            this.dgvStoricoUpdate.Size = new System.Drawing.Size(643, 179);
            this.dgvStoricoUpdate.TabIndex = 2;
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Location = new System.Drawing.Point(12, 226);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(129, 23);
            this.btnAggiorna.TabIndex = 3;
            this.btnAggiorna.Text = "Salva Aggiornamento";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 445);
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.dgvStoricoUpdate);
            this.Controls.Add(this.dgvStoricoCancellazioni);
            this.Controls.Add(this.dgvDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnDelete);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridView dgvStoricoCancellazioni;
        private System.Windows.Forms.DataGridView dgvStoricoUpdate;
        private System.Windows.Forms.Button btnAggiorna;
    }
}

