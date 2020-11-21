namespace PE3GL11_CL19037_VS2015
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvAllData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblZona1Ma = new System.Windows.Forms.Label();
            this.lblProduccion1Ma = new System.Windows.Forms.Label();
            this.lblZona2Ma = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProduccion2Ma = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblZona3Ma = new System.Windows.Forms.Label();
            this.lblProduccion3Ma = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblZona3Me = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblProduccion3Me = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblProduccion2Me = new System.Windows.Forms.Label();
            this.lblZona1Me = new System.Windows.Forms.Label();
            this.lblYear3Me = new System.Windows.Forms.Label();
            this.lblProduccion1Me = new System.Windows.Forms.Label();
            this.lblYear1Me = new System.Windows.Forms.Label();
            this.lblZona2Me = new System.Windows.Forms.Label();
            this.lblYear2Me = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblZona3 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblZona2 = new System.Windows.Forms.Label();
            this.lblProduccion3 = new System.Windows.Forms.Label();
            this.lblProduccion1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblZona1 = new System.Windows.Forms.Label();
            this.lblProduccion2 = new System.Windows.Forms.Label();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllData
            // 
            this.dgvAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvAllData.Location = new System.Drawing.Point(12, 74);
            this.dgvAllData.Name = "dgvAllData";
            this.dgvAllData.RowTemplate.Height = 24;
            this.dgvAllData.Size = new System.Drawing.Size(728, 202);
            this.dgvAllData.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "zona/año";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2018";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2019";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "2020";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(130, 12);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(112, 56);
            this.btnOperar.TabIndex = 1;
            this.btnOperar.Text = "OPERAR DATOS";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(248, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 56);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "LIMPIAR DATOS";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(628, 667);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 56);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "CERRAR PROGRAMA";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(12, 12);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(112, 56);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "INGRESAR DATOS";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "AÑO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "ZONA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "PRODUCCION:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "2018";
            // 
            // lblZona1Ma
            // 
            this.lblZona1Ma.AutoSize = true;
            this.lblZona1Ma.Location = new System.Drawing.Point(124, 67);
            this.lblZona1Ma.Name = "lblZona1Ma";
            this.lblZona1Ma.Size = new System.Drawing.Size(13, 17);
            this.lblZona1Ma.TabIndex = 10;
            this.lblZona1Ma.Text = "-";
            // 
            // lblProduccion1Ma
            // 
            this.lblProduccion1Ma.AutoSize = true;
            this.lblProduccion1Ma.Location = new System.Drawing.Point(124, 95);
            this.lblProduccion1Ma.Name = "lblProduccion1Ma";
            this.lblProduccion1Ma.Size = new System.Drawing.Size(13, 17);
            this.lblProduccion1Ma.TabIndex = 11;
            this.lblProduccion1Ma.Text = "-";
            // 
            // lblZona2Ma
            // 
            this.lblZona2Ma.AutoSize = true;
            this.lblZona2Ma.Location = new System.Drawing.Point(242, 67);
            this.lblZona2Ma.Name = "lblZona2Ma";
            this.lblZona2Ma.Size = new System.Drawing.Size(13, 17);
            this.lblZona2Ma.TabIndex = 12;
            this.lblZona2Ma.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "2019";
            // 
            // lblProduccion2Ma
            // 
            this.lblProduccion2Ma.AutoSize = true;
            this.lblProduccion2Ma.Location = new System.Drawing.Point(242, 95);
            this.lblProduccion2Ma.Name = "lblProduccion2Ma";
            this.lblProduccion2Ma.Size = new System.Drawing.Size(13, 17);
            this.lblProduccion2Ma.TabIndex = 14;
            this.lblProduccion2Ma.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "2020";
            // 
            // lblZona3Ma
            // 
            this.lblZona3Ma.AutoSize = true;
            this.lblZona3Ma.Location = new System.Drawing.Point(341, 67);
            this.lblZona3Ma.Name = "lblZona3Ma";
            this.lblZona3Ma.Size = new System.Drawing.Size(13, 17);
            this.lblZona3Ma.TabIndex = 18;
            this.lblZona3Ma.Text = "-";
            // 
            // lblProduccion3Ma
            // 
            this.lblProduccion3Ma.AutoSize = true;
            this.lblProduccion3Ma.Location = new System.Drawing.Point(341, 95);
            this.lblProduccion3Ma.Name = "lblProduccion3Ma";
            this.lblProduccion3Ma.Size = new System.Drawing.Size(13, 17);
            this.lblProduccion3Ma.TabIndex = 17;
            this.lblProduccion3Ma.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblZona3Ma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblProduccion3Ma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblProduccion2Ma);
            this.groupBox1.Controls.Add(this.lblZona1Ma);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblProduccion1Ma);
            this.groupBox1.Controls.Add(this.lblZona2Ma);
            this.groupBox1.Location = new System.Drawing.Point(12, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 143);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ZONAS CON MAYOR PRODUCCION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblZona3Me);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblProduccion3Me);
            this.groupBox2.Controls.Add(this.lblZona1Me);
            this.groupBox2.Controls.Add(this.lblYear3Me);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblProduccion2Me);
            this.groupBox2.Controls.Add(this.lblYear1Me);
            this.groupBox2.Controls.Add(this.lblZona2Me);
            this.groupBox2.Controls.Add(this.lblYear2Me);
            this.groupBox2.Controls.Add(this.lblProduccion1Me);
            this.groupBox2.Location = new System.Drawing.Point(12, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 143);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AÑOS CON MENOR PRODUCCION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "AÑO:";
            // 
            // lblZona3Me
            // 
            this.lblZona3Me.AutoSize = true;
            this.lblZona3Me.Location = new System.Drawing.Point(124, 37);
            this.lblZona3Me.Name = "lblZona3Me";
            this.lblZona3Me.Size = new System.Drawing.Size(95, 17);
            this.lblZona3Me.TabIndex = 18;
            this.lblZona3Me.Text = "OCCIDENTAL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "ZONA:";
            // 
            // lblProduccion3Me
            // 
            this.lblProduccion3Me.AutoSize = true;
            this.lblProduccion3Me.Location = new System.Drawing.Point(341, 100);
            this.lblProduccion3Me.Name = "lblProduccion3Me";
            this.lblProduccion3Me.Size = new System.Drawing.Size(13, 17);
            this.lblProduccion3Me.TabIndex = 17;
            this.lblProduccion3Me.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 17);
            this.label17.TabIndex = 8;
            this.label17.Text = "PRODUCCION:";
            // 
            // lblProduccion2Me
            // 
            this.lblProduccion2Me.AutoSize = true;
            this.lblProduccion2Me.Location = new System.Drawing.Point(242, 100);
            this.lblProduccion2Me.Name = "lblProduccion2Me";
            this.lblProduccion2Me.Size = new System.Drawing.Size(13, 17);
            this.lblProduccion2Me.TabIndex = 14;
            this.lblProduccion2Me.Text = "-";
            // 
            // lblZona1Me
            // 
            this.lblZona1Me.AutoSize = true;
            this.lblZona1Me.Location = new System.Drawing.Point(341, 37);
            this.lblZona1Me.Name = "lblZona1Me";
            this.lblZona1Me.Size = new System.Drawing.Size(77, 17);
            this.lblZona1Me.TabIndex = 10;
            this.lblZona1Me.Text = "ORIENTAL";
            // 
            // lblYear3Me
            // 
            this.lblYear3Me.AutoSize = true;
            this.lblYear3Me.Location = new System.Drawing.Point(341, 71);
            this.lblYear3Me.Name = "lblYear3Me";
            this.lblYear3Me.Size = new System.Drawing.Size(13, 17);
            this.lblYear3Me.TabIndex = 15;
            this.lblYear3Me.Text = "-";
            // 
            // lblProduccion1Me
            // 
            this.lblProduccion1Me.AutoSize = true;
            this.lblProduccion1Me.Location = new System.Drawing.Point(124, 100);
            this.lblProduccion1Me.Name = "lblProduccion1Me";
            this.lblProduccion1Me.Size = new System.Drawing.Size(13, 17);
            this.lblProduccion1Me.TabIndex = 11;
            this.lblProduccion1Me.Text = "-";
            // 
            // lblYear1Me
            // 
            this.lblYear1Me.AutoSize = true;
            this.lblYear1Me.Location = new System.Drawing.Point(124, 71);
            this.lblYear1Me.Name = "lblYear1Me";
            this.lblYear1Me.Size = new System.Drawing.Size(13, 17);
            this.lblYear1Me.TabIndex = 9;
            this.lblYear1Me.Text = "-";
            // 
            // lblZona2Me
            // 
            this.lblZona2Me.AutoSize = true;
            this.lblZona2Me.Location = new System.Drawing.Point(242, 37);
            this.lblZona2Me.Name = "lblZona2Me";
            this.lblZona2Me.Size = new System.Drawing.Size(72, 17);
            this.lblZona2Me.TabIndex = 12;
            this.lblZona2Me.Text = "CENTRAL";
            // 
            // lblYear2Me
            // 
            this.lblYear2Me.AutoSize = true;
            this.lblYear2Me.Location = new System.Drawing.Point(242, 71);
            this.lblYear2Me.Name = "lblYear2Me";
            this.lblYear2Me.Size = new System.Drawing.Size(13, 17);
            this.lblYear2Me.TabIndex = 13;
            this.lblYear2Me.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblZona3);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.lblZona2);
            this.groupBox3.Controls.Add(this.lblProduccion3);
            this.groupBox3.Controls.Add(this.lblProduccion1);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.lblZona1);
            this.groupBox3.Controls.Add(this.lblProduccion2);
            this.groupBox3.Location = new System.Drawing.Point(12, 580);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 143);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRODUCCION REGISTRADA EN EL 2019";
            // 
            // lblZona3
            // 
            this.lblZona3.AutoSize = true;
            this.lblZona3.Location = new System.Drawing.Point(341, 48);
            this.lblZona3.Name = "lblZona3";
            this.lblZona3.Size = new System.Drawing.Size(77, 17);
            this.lblZona3.TabIndex = 26;
            this.lblZona3.Text = "ORIENTAL";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 17);
            this.label26.TabIndex = 19;
            this.label26.Text = "ZONA:";
            // 
            // lblZona2
            // 
            this.lblZona2.AutoSize = true;
            this.lblZona2.Location = new System.Drawing.Point(242, 48);
            this.lblZona2.Name = "lblZona2";
            this.lblZona2.Size = new System.Drawing.Size(72, 17);
            this.lblZona2.TabIndex = 23;
            this.lblZona2.Text = "CENTRAL";
            // 
            // lblProduccion3
            // 
            this.lblProduccion3.AutoSize = true;
            this.lblProduccion3.Location = new System.Drawing.Point(341, 76);
            this.lblProduccion3.Name = "lblProduccion3";
            this.lblProduccion3.Size = new System.Drawing.Size(13, 17);
            this.lblProduccion3.TabIndex = 25;
            this.lblProduccion3.Text = "-";
            // 
            // lblProduccion1
            // 
            this.lblProduccion1.AutoSize = true;
            this.lblProduccion1.Location = new System.Drawing.Point(124, 76);
            this.lblProduccion1.Name = "lblProduccion1";
            this.lblProduccion1.Size = new System.Drawing.Size(13, 17);
            this.lblProduccion1.TabIndex = 22;
            this.lblProduccion1.Text = "-";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 76);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(104, 17);
            this.label28.TabIndex = 20;
            this.label28.Text = "PRODUCCION:";
            // 
            // lblZona1
            // 
            this.lblZona1.AutoSize = true;
            this.lblZona1.Location = new System.Drawing.Point(124, 48);
            this.lblZona1.Name = "lblZona1";
            this.lblZona1.Size = new System.Drawing.Size(95, 17);
            this.lblZona1.TabIndex = 21;
            this.lblZona1.Text = "OCCIDENTAL";
            // 
            // lblProduccion2
            // 
            this.lblProduccion2.AutoSize = true;
            this.lblProduccion2.Location = new System.Drawing.Point(242, 76);
            this.lblProduccion2.Name = "lblProduccion2";
            this.lblProduccion2.Size = new System.Drawing.Size(13, 17);
            this.lblProduccion2.TabIndex = 24;
            this.lblProduccion2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 736);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.dgvAllData);
            this.Name = "Form1";
            this.Text = "PRODUCCION CAFETALERA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllData;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblZona1Ma;
        private System.Windows.Forms.Label lblProduccion1Ma;
        private System.Windows.Forms.Label lblZona2Ma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProduccion2Ma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblZona3Ma;
        private System.Windows.Forms.Label lblProduccion3Ma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblZona3Me;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblProduccion3Me;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblYear3Me;
        private System.Windows.Forms.Label lblYear1Me;
        private System.Windows.Forms.Label lblProduccion2Me;
        private System.Windows.Forms.Label lblZona1Me;
        private System.Windows.Forms.Label lblYear2Me;
        private System.Windows.Forms.Label lblProduccion1Me;
        private System.Windows.Forms.Label lblZona2Me;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblZona3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblZona2;
        private System.Windows.Forms.Label lblProduccion3;
        private System.Windows.Forms.Label lblProduccion1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblZona1;
        private System.Windows.Forms.Label lblProduccion2;
        private System.Windows.Forms.ToolTip ttAyuda;
    }
}

