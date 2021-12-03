
namespace DesquemarSiTTi
{
    partial class Sitti_asignado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sitti_asignado));
            this.label6 = new System.Windows.Forms.Label();
            this.fechaquema = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.RichTextBox();
            this.fechasolicita = new System.Windows.Forms.TextBox();
            this.nositti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nick = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.asigno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Estatus:";
            // 
            // fechaquema
            // 
            this.fechaquema.Location = new System.Drawing.Point(99, 59);
            this.fechaquema.Name = "fechaquema";
            this.fechaquema.ReadOnly = true;
            this.fechaquema.Size = new System.Drawing.Size(184, 20);
            this.fechaquema.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha se quema";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Actualizar fecha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(10, 161);
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Size = new System.Drawing.Size(273, 114);
            this.descripcion.TabIndex = 16;
            this.descripcion.Text = "";
            // 
            // fechasolicita
            // 
            this.fechasolicita.Location = new System.Drawing.Point(80, 33);
            this.fechasolicita.Name = "fechasolicita";
            this.fechasolicita.ReadOnly = true;
            this.fechasolicita.Size = new System.Drawing.Size(203, 20);
            this.fechasolicita.TabIndex = 15;
            // 
            // nositti
            // 
            this.nositti.Location = new System.Drawing.Point(62, 8);
            this.nositti.Name = "nositti";
            this.nositti.ReadOnly = true;
            this.nositti.Size = new System.Drawing.Size(221, 20);
            this.nositti.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha solicita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "No SiTTi";
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(52, 110);
            this.nick.Name = "nick";
            this.nick.ReadOnly = true;
            this.nick.Size = new System.Drawing.Size(231, 20);
            this.nick.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Asigno";
            // 
            // asigno
            // 
            this.asigno.Location = new System.Drawing.Point(80, 84);
            this.asigno.Name = "asigno";
            this.asigno.ReadOnly = true;
            this.asigno.Size = new System.Drawing.Size(203, 20);
            this.asigno.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha asigno";
            // 
            // Sitti_asignado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 311);
            this.Controls.Add(this.asigno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fechaquema);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.fechasolicita);
            this.Controls.Add(this.nositti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sitti_asignado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiTTI Asignado";
            this.Load += new System.EventHandler(this.Sitti_asignado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fechaquema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox descripcion;
        private System.Windows.Forms.TextBox fechasolicita;
        private System.Windows.Forms.TextBox nositti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox asigno;
        private System.Windows.Forms.Label label8;
    }
}