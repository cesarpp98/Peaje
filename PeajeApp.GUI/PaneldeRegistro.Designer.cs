using System;

namespace PeajeApp.GUI
{
    partial class RegistrodeVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbmpago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbcvehiculo = new System.Windows.Forms.ComboBox();
            this.cmbtarifa = new System.Windows.Forms.ComboBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtidrecibo = new System.Windows.Forms.TextBox();
            this.cmbvia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Via";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modo de pago";
            // 
            // cmbmpago
            // 
            this.cmbmpago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbmpago.FormattingEnabled = true;
            this.cmbmpago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta débito",
            "Tarjeta crédito"});
            this.cmbmpago.Location = new System.Drawing.Point(522, 138);
            this.cmbmpago.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbmpago.Name = "cmbmpago";
            this.cmbmpago.Size = new System.Drawing.Size(175, 29);
            this.cmbmpago.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo de Vehiculo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(454, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tarifa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Placa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Número de recibo";
            // 
            // cmbcvehiculo
            // 
            this.cmbcvehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbcvehiculo.FormattingEnabled = true;
            this.cmbcvehiculo.Items.AddRange(new object[] {
            "Pequeño",
            "Mediano",
            "Grande"});
            this.cmbcvehiculo.Location = new System.Drawing.Point(172, 84);
            this.cmbcvehiculo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbcvehiculo.Name = "cmbcvehiculo";
            this.cmbcvehiculo.Size = new System.Drawing.Size(175, 29);
            this.cmbcvehiculo.TabIndex = 16;
            this.cmbcvehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbcvehiculo_SelectedIndexChanged);
            // 
            // cmbtarifa
            // 
            this.cmbtarifa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbtarifa.FormattingEnabled = true;
            this.cmbtarifa.Items.AddRange(new object[] {
            "Basica",
            "Mediana",
            "Alta"});
            this.cmbtarifa.Location = new System.Drawing.Point(522, 84);
            this.cmbtarifa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbtarifa.Name = "cmbtarifa";
            this.cmbtarifa.Size = new System.Drawing.Size(175, 29);
            this.cmbtarifa.TabIndex = 17;
            this.cmbtarifa.SelectedIndexChanged += new System.EventHandler(this.cmbtarifa_SelectedIndexChanged);
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(522, 23);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(175, 28);
            this.txtplaca.TabIndex = 18;
            // 
            // txtidrecibo
            // 
            this.txtidrecibo.Location = new System.Drawing.Point(174, 23);
            this.txtidrecibo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtidrecibo.Name = "txtidrecibo";
            this.txtidrecibo.Size = new System.Drawing.Size(173, 28);
            this.txtidrecibo.TabIndex = 19;
            this.txtidrecibo.TextChanged += new System.EventHandler(this.txtidrecibo_TextChanged);
            // 
            // cmbvia
            // 
            this.cmbvia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbvia.FormattingEnabled = true;
            this.cmbvia.Items.AddRange(new object[] {
            "Nacional",
            "Departamental",
            "Segundaria"});
            this.cmbvia.Location = new System.Drawing.Point(172, 138);
            this.cmbvia.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbvia.Name = "cmbvia";
            this.cmbvia.Size = new System.Drawing.Size(175, 29);
            this.cmbvia.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Monto a pagar ($)";
            // 
            // txtpago
            // 
            this.txtpago.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpago.Location = new System.Drawing.Point(15, 236);
            this.txtpago.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtpago.Multiline = true;
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(470, 107);
            this.txtpago.TabIndex = 22;
            this.txtpago.TextChanged += new System.EventHandler(this.txtpago_TextChanged);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(497, 236);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(244, 107);
            this.btnregistrar.TabIndex = 23;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // RegistrodeVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 356);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbvia);
            this.Controls.Add(this.txtidrecibo);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.cmbtarifa);
            this.Controls.Add(this.cmbcvehiculo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbmpago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "RegistrodeVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Vehiculo";
            this.Load += new System.EventHandler(this.RegistrodeVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbmpago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbcvehiculo;
        private System.Windows.Forms.ComboBox cmbtarifa;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtidrecibo;
        private System.Windows.Forms.ComboBox cmbvia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Button btnregistrar;

        public EventHandler textBox1_TextChanged { get; private set; }
    }
}