namespace practica
{
    partial class FrmListaDobleAnalisis
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Insertar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombres,
            this.Edad});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(202, 171);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(536, 217);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombres
            // 
            this.Nombres.Text = "Nombres";
            this.Nombres.Width = 262;
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            this.Edad.Width = 205;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(19, 332);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(131, 38);
            this.button_Buscar.TabIndex = 34;
            this.button_Buscar.Text = "BUSCAR";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button_Modificar
            // 
            this.button_Modificar.Location = new System.Drawing.Point(19, 277);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(131, 38);
            this.button_Modificar.TabIndex = 33;
            this.button_Modificar.Text = "MODIFICAR";
            this.button_Modificar.UseVisualStyleBackColor = true;
            this.button_Modificar.Click += new System.EventHandler(this.button_Modificar_Click);
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(543, 109);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(195, 22);
            this.textEdad.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ingresar edad: ";
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(19, 224);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(131, 38);
            this.button_Eliminar.TabIndex = 30;
            this.button_Eliminar.Text = "ELIMINAR";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Insertar
            // 
            this.button_Insertar.Location = new System.Drawing.Point(19, 171);
            this.button_Insertar.Name = "button_Insertar";
            this.button_Insertar.Size = new System.Drawing.Size(131, 38);
            this.button_Insertar.TabIndex = 29;
            this.button_Insertar.Text = "INSERTAR";
            this.button_Insertar.UseVisualStyleBackColor = true;
            this.button_Insertar.Click += new System.EventHandler(this.button_Insertar_Click_1);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(189, 115);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(195, 22);
            this.textNombre.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ingresar nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Lista Enlazada Doble Analisis";
            // 
            // FrmListaDobleAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Insertar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmListaDobleAnalisis";
            this.Text = "FrmListaDobleAnalisis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombres;
        private System.Windows.Forms.ColumnHeader Edad;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Insertar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}