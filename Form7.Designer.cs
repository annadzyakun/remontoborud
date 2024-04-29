namespace уч_практика
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.отчетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ремонт_оборудованияDataSet = new уч_практика.ремонт_оборудованияDataSet();
            this.отчетTableAdapter = new уч_практика.ремонт_оборудованияDataSetTableAdapters.ОтчетTableAdapter();
            this.ремонт_оборудованияDataSet1 = new уч_практика.ремонт_оборудованияDataSet1();
            this.отчетBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.отчетTableAdapter1 = new уч_практика.ремонт_оборудованияDataSet1TableAdapters.ОтчетTableAdapter();
            this.idотчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDисполнителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материалыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.причинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.состояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ремонт_оборудованияDataSet2 = new уч_практика.ремонт_оборудованияDataSet2();
            this.отчетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отчетыTableAdapter = new уч_практика.ремонт_оборудованияDataSet2TableAdapters.ОтчетыTableAdapter();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_оборудованияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_оборудованияDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_оборудованияDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество выполненных завок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Среднее время выполнения заявки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "подсчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.button6);
            this.panelMenu.Controls.Add(this.button7);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 39);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(195, 552);
            this.panelMenu.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(3, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 51);
            this.button4.TabIndex = 17;
            this.button4.Text = "статистика";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(5, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 51);
            this.button2.TabIndex = 16;
            this.button2.Text = "отчет исполнителя";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(3, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 51);
            this.button3.TabIndex = 15;
            this.button3.Text = "опрос";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(3, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 51);
            this.button5.TabIndex = 14;
            this.button5.Text = "исполнитель";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(5, 121);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 51);
            this.button6.TabIndex = 13;
            this.button6.Text = "просмотр и поиск";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(3, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 51);
            this.button7.TabIndex = 10;
            this.button7.Text = "Добавление заявки";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 39);
            this.panel2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(542, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "IT-Решения";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(199, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 550);
            this.panel1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idотчетаDataGridViewTextBoxColumn,
            this.номерзаявкиDataGridViewTextBoxColumn,
            this.iDисполнителяDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.материалыDataGridViewTextBoxColumn,
            this.причинаDataGridViewTextBoxColumn,
            this.состояниеDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.отчетыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(139, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // отчетBindingSource
            // 
            this.отчетBindingSource.DataMember = "Отчет";
            this.отчетBindingSource.DataSource = this.ремонт_оборудованияDataSet;
            // 
            // ремонт_оборудованияDataSet
            // 
            this.ремонт_оборудованияDataSet.DataSetName = "ремонт_оборудованияDataSet";
            this.ремонт_оборудованияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отчетTableAdapter
            // 
            this.отчетTableAdapter.ClearBeforeFill = true;
            // 
            // ремонт_оборудованияDataSet1
            // 
            this.ремонт_оборудованияDataSet1.DataSetName = "ремонт_оборудованияDataSet1";
            this.ремонт_оборудованияDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отчетBindingSource1
            // 
            this.отчетBindingSource1.DataMember = "Отчет";
            this.отчетBindingSource1.DataSource = this.ремонт_оборудованияDataSet1;
            // 
            // отчетTableAdapter1
            // 
            this.отчетTableAdapter1.ClearBeforeFill = true;
            // 
            // idотчетаDataGridViewTextBoxColumn
            // 
            this.idотчетаDataGridViewTextBoxColumn.DataPropertyName = "id_отчета";
            this.idотчетаDataGridViewTextBoxColumn.HeaderText = "id_отчета";
            this.idотчетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idотчетаDataGridViewTextBoxColumn.Name = "idотчетаDataGridViewTextBoxColumn";
            this.idотчетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерзаявкиDataGridViewTextBoxColumn
            // 
            this.номерзаявкиDataGridViewTextBoxColumn.DataPropertyName = "Номер_заявки";
            this.номерзаявкиDataGridViewTextBoxColumn.HeaderText = "Номер_заявки";
            this.номерзаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерзаявкиDataGridViewTextBoxColumn.Name = "номерзаявкиDataGridViewTextBoxColumn";
            this.номерзаявкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDисполнителяDataGridViewTextBoxColumn
            // 
            this.iDисполнителяDataGridViewTextBoxColumn.DataPropertyName = "ID_исполнителя";
            this.iDисполнителяDataGridViewTextBoxColumn.HeaderText = "ID_исполнителя";
            this.iDисполнителяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDисполнителяDataGridViewTextBoxColumn.Name = "iDисполнителяDataGridViewTextBoxColumn";
            this.iDисполнителяDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "время";
            this.времяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            this.времяDataGridViewTextBoxColumn.Width = 125;
            // 
            // материалыDataGridViewTextBoxColumn
            // 
            this.материалыDataGridViewTextBoxColumn.DataPropertyName = "материалы";
            this.материалыDataGridViewTextBoxColumn.HeaderText = "материалы";
            this.материалыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.материалыDataGridViewTextBoxColumn.Name = "материалыDataGridViewTextBoxColumn";
            this.материалыDataGridViewTextBoxColumn.Width = 125;
            // 
            // причинаDataGridViewTextBoxColumn
            // 
            this.причинаDataGridViewTextBoxColumn.DataPropertyName = "причина";
            this.причинаDataGridViewTextBoxColumn.HeaderText = "причина";
            this.причинаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.причинаDataGridViewTextBoxColumn.Name = "причинаDataGridViewTextBoxColumn";
            this.причинаDataGridViewTextBoxColumn.Width = 125;
            // 
            // состояниеDataGridViewTextBoxColumn
            // 
            this.состояниеDataGridViewTextBoxColumn.DataPropertyName = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.состояниеDataGridViewTextBoxColumn.Name = "состояниеDataGridViewTextBoxColumn";
            this.состояниеDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.Width = 125;
            // 
            // ремонт_оборудованияDataSet2
            // 
            this.ремонт_оборудованияDataSet2.DataSetName = "ремонт_оборудованияDataSet2";
            this.ремонт_оборудованияDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отчетыBindingSource
            // 
            this.отчетыBindingSource.DataMember = "Отчеты";
            this.отчетыBindingSource.DataSource = this.ремонт_оборудованияDataSet2;
            // 
            // отчетыTableAdapter
            // 
            this.отчетыTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 591);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_оборудованияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_оборудованияDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_оборудованияDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ремонт_оборудованияDataSet ремонт_оборудованияDataSet;
        private System.Windows.Forms.BindingSource отчетBindingSource;
        private ремонт_оборудованияDataSetTableAdapters.ОтчетTableAdapter отчетTableAdapter;
        private ремонт_оборудованияDataSet1 ремонт_оборудованияDataSet1;
        private System.Windows.Forms.BindingSource отчетBindingSource1;
        private ремонт_оборудованияDataSet1TableAdapters.ОтчетTableAdapter отчетTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idотчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDисполнителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материалыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn причинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn состояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private ремонт_оборудованияDataSet2 ремонт_оборудованияDataSet2;
        private System.Windows.Forms.BindingSource отчетыBindingSource;
        private ремонт_оборудованияDataSet2TableAdapters.ОтчетыTableAdapter отчетыTableAdapter;
    }
}