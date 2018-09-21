namespace tcc
{
    partial class InicioUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.txtbasal = new System.Windows.Forms.TextBox();
            this.txtpersonal = new System.Windows.Forms.TextBox();
            this.txtnutricionista = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IMC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consumo de calorias\r\npara manter o peso:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nutricionista:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(166, 96);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.Size = new System.Drawing.Size(363, 20);
            this.txtnome.TabIndex = 5;
            this.txtnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtimc
            // 
            this.txtimc.Location = new System.Drawing.Point(166, 176);
            this.txtimc.Name = "txtimc";
            this.txtimc.ReadOnly = true;
            this.txtimc.Size = new System.Drawing.Size(133, 20);
            this.txtimc.TabIndex = 6;
            this.txtimc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbasal
            // 
            this.txtbasal.Location = new System.Drawing.Point(416, 176);
            this.txtbasal.Name = "txtbasal";
            this.txtbasal.ReadOnly = true;
            this.txtbasal.Size = new System.Drawing.Size(113, 20);
            this.txtbasal.TabIndex = 7;
            this.txtbasal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpersonal
            // 
            this.txtpersonal.Location = new System.Drawing.Point(166, 258);
            this.txtpersonal.Name = "txtpersonal";
            this.txtpersonal.ReadOnly = true;
            this.txtpersonal.Size = new System.Drawing.Size(363, 20);
            this.txtpersonal.TabIndex = 8;
            this.txtpersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnutricionista
            // 
            this.txtnutricionista.Location = new System.Drawing.Point(166, 329);
            this.txtnutricionista.Name = "txtnutricionista";
            this.txtnutricionista.ReadOnly = true;
            this.txtnutricionista.Size = new System.Drawing.Size(363, 20);
            this.txtnutricionista.TabIndex = 9;
            this.txtnutricionista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "TELA INICIAL DE USUÁRIO";
            // 
            // InicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 406);
            this.Controls.Add(this.txtnutricionista);
            this.Controls.Add(this.txtpersonal);
            this.Controls.Add(this.txtbasal);
            this.Controls.Add(this.txtimc);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "InicioUsuario";
            this.Text = "InicioUsuario";
            this.Load += new System.EventHandler(this.InicioUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtimc;
        private System.Windows.Forms.TextBox txtbasal;
        private System.Windows.Forms.TextBox txtpersonal;
        private System.Windows.Forms.TextBox txtnutricionista;
        private System.Windows.Forms.Label label6;
    }
}