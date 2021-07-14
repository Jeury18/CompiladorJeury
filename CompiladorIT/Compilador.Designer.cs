
namespace CompiladorIT
{
    partial class compilador
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
            this.salir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.compilar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoSalida = new System.Windows.Forms.RichTextBox();
            this.CodigoEntrada = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AnalizadorLexico = new System.Windows.Forms.DataGridView();
            this.AnalizadorSintacticoo = new System.Windows.Forms.DataGridView();
            this.TablaDeSimbolos = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TOKEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEXEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AnalizadorLexico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalizadorSintacticoo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeSimbolos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Red;
            this.salir.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(447, 196);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(207, 38);
            this.salir.TabIndex = 15;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.Gray;
            this.limpiar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Location = new System.Drawing.Point(447, 136);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(207, 41);
            this.limpiar.TabIndex = 14;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // compilar
            // 
            this.compilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.compilar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compilar.Location = new System.Drawing.Point(447, 80);
            this.compilar.Name = "compilar";
            this.compilar.Size = new System.Drawing.Size(207, 39);
            this.compilar.TabIndex = 13;
            this.compilar.Text = "COMPILAR";
            this.compilar.UseVisualStyleBackColor = false;
            this.compilar.Click += new System.EventHandler(this.compilar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(672, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "GENERACION DE CODIGO ( C )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "CADENA DE ENTRADA";
            // 
            // CodigoSalida
            // 
            this.CodigoSalida.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoSalida.Location = new System.Drawing.Point(660, 61);
            this.CodigoSalida.Name = "CodigoSalida";
            this.CodigoSalida.Size = new System.Drawing.Size(443, 219);
            this.CodigoSalida.TabIndex = 10;
            this.CodigoSalida.Text = "";
            // 
            // CodigoEntrada
            // 
            this.CodigoEntrada.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoEntrada.Location = new System.Drawing.Point(12, 61);
            this.CodigoEntrada.Name = "CodigoEntrada";
            this.CodigoEntrada.Size = new System.Drawing.Size(429, 219);
            this.CodigoEntrada.TabIndex = 9;
            this.CodigoEntrada.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "ANALIZADOR LEXICO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "ANALIZADOR SINTACTICO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(866, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "TABLA DE SIMBOLOS";
            // 
            // AnalizadorLexico
            // 
            this.AnalizadorLexico.AllowUserToAddRows = false;
            this.AnalizadorLexico.AllowUserToDeleteRows = false;
            this.AnalizadorLexico.AllowUserToResizeRows = false;
            this.AnalizadorLexico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AnalizadorLexico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AnalizadorLexico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnalizadorLexico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AnalizadorLexico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AnalizadorLexico.ColumnHeadersHeight = 30;
            this.AnalizadorLexico.Location = new System.Drawing.Point(34, 623);
            this.AnalizadorLexico.MultiSelect = false;
            this.AnalizadorLexico.Name = "AnalizadorLexico";
            this.AnalizadorLexico.ReadOnly = true;
            this.AnalizadorLexico.RowHeadersVisible = false;
            this.AnalizadorLexico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AnalizadorLexico.Size = new System.Drawing.Size(10, 10);
            this.AnalizadorLexico.TabIndex = 24;
            // 
            // AnalizadorSintacticoo
            // 
            this.AnalizadorSintacticoo.AllowUserToAddRows = false;
            this.AnalizadorSintacticoo.AllowUserToDeleteRows = false;
            this.AnalizadorSintacticoo.AllowUserToResizeRows = false;
            this.AnalizadorSintacticoo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AnalizadorSintacticoo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AnalizadorSintacticoo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnalizadorSintacticoo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AnalizadorSintacticoo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AnalizadorSintacticoo.ColumnHeadersHeight = 30;
            this.AnalizadorSintacticoo.Location = new System.Drawing.Point(383, 308);
            this.AnalizadorSintacticoo.MultiSelect = false;
            this.AnalizadorSintacticoo.Name = "AnalizadorSintacticoo";
            this.AnalizadorSintacticoo.ReadOnly = true;
            this.AnalizadorSintacticoo.RowHeadersVisible = false;
            this.AnalizadorSintacticoo.RowHeadersWidth = 20;
            this.AnalizadorSintacticoo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AnalizadorSintacticoo.Size = new System.Drawing.Size(376, 158);
            this.AnalizadorSintacticoo.TabIndex = 26;
            // 
            // TablaDeSimbolos
            // 
            this.TablaDeSimbolos.AllowUserToAddRows = false;
            this.TablaDeSimbolos.AllowUserToDeleteRows = false;
            this.TablaDeSimbolos.AllowUserToResizeRows = false;
            this.TablaDeSimbolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaDeSimbolos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TablaDeSimbolos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaDeSimbolos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TablaDeSimbolos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaDeSimbolos.ColumnHeadersHeight = 30;
            this.TablaDeSimbolos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TablaDeSimbolos.Location = new System.Drawing.Point(765, 308);
            this.TablaDeSimbolos.MultiSelect = false;
            this.TablaDeSimbolos.Name = "TablaDeSimbolos";
            this.TablaDeSimbolos.ReadOnly = true;
            this.TablaDeSimbolos.RowHeadersVisible = false;
            this.TablaDeSimbolos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaDeSimbolos.Size = new System.Drawing.Size(350, 158);
            this.TablaDeSimbolos.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TOKEN,
            this.LEXEMA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 308);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(365, 158);
            this.dataGridView1.TabIndex = 28;
            // 
            // TOKEN
            // 
            this.TOKEN.HeaderText = "TOKEN";
            this.TOKEN.Name = "TOKEN";
            this.TOKEN.ReadOnly = true;
            // 
            // LEXEMA
            // 
            this.LEXEMA.HeaderText = "LEXEMA";
            this.LEXEMA.Name = "LEXEMA";
            this.LEXEMA.ReadOnly = true;
            // 
            // compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TablaDeSimbolos);
            this.Controls.Add(this.AnalizadorSintacticoo);
            this.Controls.Add(this.AnalizadorLexico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.compilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodigoSalida);
            this.Controls.Add(this.CodigoEntrada);
            this.Name = "compilador";
            this.Text = "COMPILADOR";
            this.Load += new System.EventHandler(this.compilador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnalizadorLexico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalizadorSintacticoo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeSimbolos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button compilar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox CodigoSalida;
        private System.Windows.Forms.RichTextBox CodigoEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView AnalizadorLexico;
        private System.Windows.Forms.DataGridView AnalizadorSintacticoo;
        private System.Windows.Forms.DataGridView TablaDeSimbolos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOKEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEXEMA;
    }
}

