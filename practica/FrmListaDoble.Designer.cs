namespace practica
{
    partial class FrmListaDoble
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
            this.listBox_Numeros = new System.Windows.Forms.ListBox();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Insertar = new System.Windows.Forms.Button();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Numeros
            // 
            this.listBox_Numeros.FormattingEnabled = true;
            this.listBox_Numeros.ItemHeight = 16;
            this.listBox_Numeros.Location = new System.Drawing.Point(210, 150);
            this.listBox_Numeros.Name = "listBox_Numeros";
            this.listBox_Numeros.Size = new System.Drawing.Size(195, 244);
            this.listBox_Numeros.TabIndex = 19;
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(40, 200);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(131, 38);
            this.button_Eliminar.TabIndex = 18;
            this.button_Eliminar.Text = "ELIMINAR";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            // 
            // button_Insertar
            // 
            this.button_Insertar.Location = new System.Drawing.Point(40, 147);
            this.button_Insertar.Name = "button_Insertar";
            this.button_Insertar.Size = new System.Drawing.Size(131, 38);
            this.button_Insertar.TabIndex = 17;
            this.button_Insertar.Text = "INSERTAR";
            this.button_Insertar.UseVisualStyleBackColor = true;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(210, 91);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(195, 22);
            this.textBoxNum.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingresar numero: ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // FrmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.listBox_Numeros);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Insertar);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.label2);
            this.Name = "FrmListaDoble";
            this.Text = "FrmListaDoble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Numeros;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Insertar;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label2;
    }
}