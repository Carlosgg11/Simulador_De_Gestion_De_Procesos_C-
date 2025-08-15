using System;

namespace Gestion_De_Procesos
{
    partial class Ventana_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarProceso = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dataGridViewProceso = new System.Windows.Forms.DataGridView();
            this.labelProceso = new System.Windows.Forms.Label();
            this.btnFCFS = new System.Windows.Forms.Button();
            this.btnSJF = new System.Windows.Forms.Button();
            this.btnRR = new System.Windows.Forms.Button();
            this.labelLlegada = new System.Windows.Forms.Label();
            this.dataGridViewLlegada = new System.Windows.Forms.DataGridView();
            this.labelCPU = new System.Windows.Forms.Label();
            this.dataGridViewCPU = new System.Windows.Forms.DataGridView();
            this.labelPrioridad = new System.Windows.Forms.Label();
            this.dataGridViewPrioridad = new System.Windows.Forms.DataGridView();
            this.labelListo = new System.Windows.Forms.Label();
            this.dataGridViewListo = new System.Windows.Forms.DataGridView();
            this.labelEjecucion = new System.Windows.Forms.Label();
            this.dataGridViewEjecucion = new System.Windows.Forms.DataGridView();
            this.labelTerminado = new System.Windows.Forms.Label();
            this.dataGridViewTerminado = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer();
            this.timer1.Interval = 1000; // 1 segundo
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLlegada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrioridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEjecucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerminado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProceso
            // 
            this.btnAgregarProceso.BackColor = System.Drawing.Color.Linen;
            this.btnAgregarProceso.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProceso.Location = new System.Drawing.Point(136, 71);
            this.btnAgregarProceso.Name = "btnAgregarProceso";
            this.btnAgregarProceso.Size = new System.Drawing.Size(220, 34);
            this.btnAgregarProceso.TabIndex = 0;
            this.btnAgregarProceso.Text = "Agregar Proceso";
            this.btnAgregarProceso.UseVisualStyleBackColor = false;
            btnAgregarProceso.Click += new EventHandler(btnAgregarProceso_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Black;
            this.labelTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitulo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitulo.Location = new System.Drawing.Point(261, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(492, 28);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Simulador de Gestión de Procesos";
            // 
            // dataGridViewProceso
            // 
            this.dataGridViewProceso.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProceso.Location = new System.Drawing.Point(136, 211);
            this.dataGridViewProceso.Name = "dataGridViewProceso";
            this.dataGridViewProceso.RowHeadersWidth = 51;
            this.dataGridViewProceso.RowTemplate.Height = 24;
            this.dataGridViewProceso.Size = new System.Drawing.Size(118, 171);
            this.dataGridViewProceso.TabIndex = 2;
            this.dataGridViewProceso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProceso_CellContentClick);
            // 
            // labelProceso
            // 
            this.labelProceso.AutoSize = true;
            this.labelProceso.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProceso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProceso.Location = new System.Drawing.Point(162, 184);
            this.labelProceso.Name = "labelProceso";
            this.labelProceso.Size = new System.Drawing.Size(70, 15);
            this.labelProceso.TabIndex = 3;
            this.labelProceso.Text = "Proceso";
            this.labelProceso.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFCFS
            // 
            this.btnFCFS.BackColor = System.Drawing.Color.Linen;
            this.btnFCFS.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFCFS.Location = new System.Drawing.Point(452, 71);
            this.btnFCFS.Name = "btnFCFS";
            this.btnFCFS.Size = new System.Drawing.Size(134, 34);
            this.btnFCFS.TabIndex = 4;
            this.btnFCFS.Text = "FCFS";
            this.btnFCFS.UseVisualStyleBackColor = false;
            // 
            // btnSJF
            // 
            this.btnSJF.BackColor = System.Drawing.Color.Linen;
            this.btnSJF.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSJF.Location = new System.Drawing.Point(610, 71);
            this.btnSJF.Name = "btnSJF";
            this.btnSJF.Size = new System.Drawing.Size(113, 34);
            this.btnSJF.TabIndex = 5;
            this.btnSJF.Text = "SJF";
            this.btnSJF.UseVisualStyleBackColor = false;
            btnSJF.Click += new System.EventHandler(this.btnSJF_Click);
            // 
            // btnRR
            // 
            this.btnRR.BackColor = System.Drawing.Color.Linen;
            this.btnRR.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRR.Location = new System.Drawing.Point(747, 71);
            this.btnRR.Name = "btnRR";
            this.btnRR.Size = new System.Drawing.Size(149, 34);
            this.btnRR.TabIndex = 6;
            this.btnRR.Text = "Round Robin";
            this.btnRR.UseVisualStyleBackColor = false;
            // 
            // labelLlegada
            // 
            this.labelLlegada.AutoSize = true;
            this.labelLlegada.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLlegada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLlegada.Location = new System.Drawing.Point(316, 184);
            this.labelLlegada.Name = "labelLlegada";
            this.labelLlegada.Size = new System.Drawing.Size(160, 15);
            this.labelLlegada.TabIndex = 7;
            this.labelLlegada.Text = "Tiempo De Llegada";
            // 
            // dataGridViewLlegada
            // 
            this.dataGridViewLlegada.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLlegada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLlegada.Location = new System.Drawing.Point(335, 211);
            this.dataGridViewLlegada.Name = "dataGridViewLlegada";
            this.dataGridViewLlegada.RowHeadersWidth = 51;
            this.dataGridViewLlegada.RowTemplate.Height = 24;
            this.dataGridViewLlegada.Size = new System.Drawing.Size(118, 171);
            this.dataGridViewLlegada.TabIndex = 8;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCPU.Location = new System.Drawing.Point(532, 184);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(124, 15);
            this.labelCPU.TabIndex = 9;
            this.labelCPU.Text = "Tiempo En CPU";
            this.labelCPU.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridViewCPU
            // 
            this.dataGridViewCPU.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCPU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCPU.GridColor = System.Drawing.Color.Black;
            this.dataGridViewCPU.Location = new System.Drawing.Point(535, 211);
            this.dataGridViewCPU.Name = "dataGridViewCPU";
            this.dataGridViewCPU.RowHeadersWidth = 51;
            this.dataGridViewCPU.RowTemplate.Height = 24;
            this.dataGridViewCPU.Size = new System.Drawing.Size(118, 171);
            this.dataGridViewCPU.TabIndex = 10;
            // 
            // labelPrioridad
            // 
            this.labelPrioridad.AutoSize = true;
            this.labelPrioridad.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrioridad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPrioridad.Location = new System.Drawing.Point(744, 184);
            this.labelPrioridad.Name = "labelPrioridad";
            this.labelPrioridad.Size = new System.Drawing.Size(88, 15);
            this.labelPrioridad.TabIndex = 11;
            this.labelPrioridad.Text = "Prioridad";
            // 
            // dataGridViewPrioridad
            // 
            this.dataGridViewPrioridad.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPrioridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrioridad.Location = new System.Drawing.Point(727, 211);
            this.dataGridViewPrioridad.Name = "dataGridViewPrioridad";
            this.dataGridViewPrioridad.RowHeadersWidth = 51;
            this.dataGridViewPrioridad.RowTemplate.Height = 24;
            this.dataGridViewPrioridad.Size = new System.Drawing.Size(121, 171);
            this.dataGridViewPrioridad.TabIndex = 12;
            // 
            // labelListo
            // 
            this.labelListo.AutoSize = true;
            this.labelListo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelListo.Location = new System.Drawing.Point(332, 415);
            this.labelListo.Name = "labelListo";
            this.labelListo.Size = new System.Drawing.Size(52, 15);
            this.labelListo.TabIndex = 13;
            this.labelListo.Text = "Listo";
            // 
            // dataGridViewListo
            // 
            this.dataGridViewListo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewListo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListo.Location = new System.Drawing.Point(319, 445);
            this.dataGridViewListo.Name = "dataGridViewListo";
            this.dataGridViewListo.RowHeadersWidth = 51;
            this.dataGridViewListo.RowTemplate.Height = 24;
            this.dataGridViewListo.Size = new System.Drawing.Size(79, 150);
            this.dataGridViewListo.TabIndex = 14;
            // 
            // labelEjecucion
            // 
            this.labelEjecucion.AutoSize = true;
            this.labelEjecucion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjecucion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEjecucion.Location = new System.Drawing.Point(436, 415);
            this.labelEjecucion.Name = "labelEjecucion";
            this.labelEjecucion.Size = new System.Drawing.Size(115, 15);
            this.labelEjecucion.TabIndex = 15;
            this.labelEjecucion.Text = "En ejecución";
            // 
            // dataGridViewEjecucion
            // 
            this.dataGridViewEjecucion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEjecucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEjecucion.Location = new System.Drawing.Point(452, 445);
            this.dataGridViewEjecucion.Name = "dataGridViewEjecucion";
            this.dataGridViewEjecucion.RowHeadersWidth = 51;
            this.dataGridViewEjecucion.RowTemplate.Height = 24;
            this.dataGridViewEjecucion.Size = new System.Drawing.Size(79, 150);
            this.dataGridViewEjecucion.TabIndex = 16;
            // 
            // labelTerminado
            // 
            this.labelTerminado.AutoSize = true;
            this.labelTerminado.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerminado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTerminado.Location = new System.Drawing.Point(584, 415);
            this.labelTerminado.Name = "labelTerminado";
            this.labelTerminado.Size = new System.Drawing.Size(88, 15);
            this.labelTerminado.TabIndex = 17;
            this.labelTerminado.Text = "Terminado";
            // 
            // dataGridViewTerminado
            // 
            this.dataGridViewTerminado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTerminado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTerminado.Location = new System.Drawing.Point(587, 445);
            this.dataGridViewTerminado.Name = "dataGridViewTerminado";
            this.dataGridViewTerminado.RowHeadersWidth = 51;
            this.dataGridViewTerminado.RowTemplate.Height = 24;
            this.dataGridViewTerminado.Size = new System.Drawing.Size(79, 150);
            this.dataGridViewTerminado.TabIndex = 18;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Linen;
            this.btnSalir.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(888, 591);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 36);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(635, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantum:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(747, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 29);
            this.textBox1.TabIndex = 21;
            // 
            // Ventana_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(997, 639);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridViewTerminado);
            this.Controls.Add(this.labelTerminado);
            this.Controls.Add(this.dataGridViewEjecucion);
            this.Controls.Add(this.labelEjecucion);
            this.Controls.Add(this.dataGridViewListo);
            this.Controls.Add(this.labelListo);
            this.Controls.Add(this.dataGridViewPrioridad);
            this.Controls.Add(this.labelPrioridad);
            this.Controls.Add(this.dataGridViewCPU);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.dataGridViewLlegada);
            this.Controls.Add(this.labelLlegada);
            this.Controls.Add(this.btnRR);
            this.Controls.Add(this.btnSJF);
            this.Controls.Add(this.btnFCFS);
            this.Controls.Add(this.labelProceso);
            this.Controls.Add(this.dataGridViewProceso);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnAgregarProceso);
            this.Name = "Ventana_Principal";
            this.Text = "ProSim";
            this.Load += new System.EventHandler(this.Ventana_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLlegada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrioridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEjecucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerminado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProceso;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewProceso;
        private System.Windows.Forms.Label labelProceso;
        private System.Windows.Forms.Button btnFCFS;
        private System.Windows.Forms.Button btnSJF;
        private System.Windows.Forms.Button btnRR;
        private System.Windows.Forms.Label labelLlegada;
        private System.Windows.Forms.DataGridView dataGridViewLlegada;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.DataGridView dataGridViewCPU;
        private System.Windows.Forms.Label labelPrioridad;
        private System.Windows.Forms.DataGridView dataGridViewPrioridad;
        private System.Windows.Forms.Label labelListo;
        private System.Windows.Forms.DataGridView dataGridViewListo;
        private System.Windows.Forms.Label labelEjecucion;
        private System.Windows.Forms.DataGridView dataGridViewEjecucion;
        private System.Windows.Forms.Label labelTerminado;
        private System.Windows.Forms.DataGridView dataGridViewTerminado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

