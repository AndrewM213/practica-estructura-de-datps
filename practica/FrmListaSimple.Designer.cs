namespace practica
{
    partial class FrmListaSimple
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
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.button_Insertar = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_Ordenar = new System.Windows.Forms.Button();
            this.button_Mezclar = new System.Windows.Forms.Button();
            this.listBox_Numeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Enlazada Simple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar numero: ";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(227, 85);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(195, 22);
            this.textBoxNum.TabIndex = 2;
            // 
            // button_Insertar
            // 
            this.button_Insertar.Location = new System.Drawing.Point(57, 141);
            this.button_Insertar.Name = "button_Insertar";
            this.button_Insertar.Size = new System.Drawing.Size(131, 38);
            this.button_Insertar.TabIndex = 3;
            this.button_Insertar.Text = "INSERTAR";
            this.button_Insertar.UseVisualStyleBackColor = true;
            this.button_Insertar.Click += new System.EventHandler(this.button_Insertar_Click);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(57, 194);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(131, 38);
            this.button_Eliminar.TabIndex = 4;
            this.button_Eliminar.Text = "ELIMINAR";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(57, 247);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(131, 38);
            this.button_Buscar.TabIndex = 5;
            this.button_Buscar.Text = "BUSCAR";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button_Ordenar
            // 
            this.button_Ordenar.Location = new System.Drawing.Point(57, 300);
            this.button_Ordenar.Name = "button_Ordenar";
            this.button_Ordenar.Size = new System.Drawing.Size(131, 38);
            this.button_Ordenar.TabIndex = 6;
            this.button_Ordenar.Text = "ORDENAR";
            this.button_Ordenar.UseVisualStyleBackColor = true;
            this.button_Ordenar.Click += new System.EventHandler(this.button_Ordenar_Click);
            // 
            // button_Mezclar
            // 
            this.button_Mezclar.Location = new System.Drawing.Point(57, 353);
            this.button_Mezclar.Name = "button_Mezclar";
            this.button_Mezclar.Size = new System.Drawing.Size(131, 38);
            this.button_Mezclar.TabIndex = 7;
            this.button_Mezclar.Text = "MEZCLAR";
            this.button_Mezclar.UseVisualStyleBackColor = true;
            // 
            // listBox_Numeros
            // 
            this.listBox_Numeros.FormattingEnabled = true;
            this.listBox_Numeros.ItemHeight = 16;
            this.listBox_Numeros.Location = new System.Drawing.Point(227, 144);
            this.listBox_Numeros.Name = "listBox_Numeros";
            this.listBox_Numeros.Size = new System.Drawing.Size(195, 244);
            this.listBox_Numeros.TabIndex = 8;
            this.listBox_Numeros.SelectedIndexChanged += new System.EventHandler(this.listBox_Numeros_SelectedIndexChanged);
            // 
            // FrmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.listBox_Numeros);
            this.Controls.Add(this.button_Mezclar);
            this.Controls.Add(this.button_Ordenar);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Insertar);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmListaSimple";
            this.Text = "FrmListaSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button button_Insertar;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_Ordenar;
        private System.Windows.Forms.Button button_Mezclar;
        private System.Windows.Forms.ListBox listBox_Numeros;
    }
}