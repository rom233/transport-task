
namespace Transport_task
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputRows = new System.Windows.Forms.NumericUpDown();
            this.inputColumns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExample1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableX2 = new Transport_task.TableX();
            this.tableX1 = new Transport_task.TableX();
            ((System.ComponentModel.ISupportInitialize)(this.inputRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // inputRows
            // 
            this.inputRows.Location = new System.Drawing.Point(73, 79);
            this.inputRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputRows.Name = "inputRows";
            this.inputRows.Size = new System.Drawing.Size(120, 29);
            this.inputRows.TabIndex = 1;
            this.inputRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputRows.ValueChanged += new System.EventHandler(this.inputColumnsRows_ValueChanged);
            // 
            // inputColumns
            // 
            this.inputColumns.Location = new System.Drawing.Point(287, 79);
            this.inputColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputColumns.Name = "inputColumns";
            this.inputColumns.Size = new System.Drawing.Size(120, 29);
            this.inputColumns.TabIndex = 2;
            this.inputColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputColumns.ValueChanged += new System.EventHandler(this.inputColumnsRows_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "m =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "n =";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(746, 815);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(187, 65);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(543, 815);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(187, 65);
            this.btnExample1.TabIndex = 10;
            this.btnExample1.Text = "Пример №1";
            this.btnExample1.UseVisualStyleBackColor = true;
            this.btnExample1.Click += new System.EventHandler(this.btnExample1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Исходные данные:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Результат:";
            // 
            // tableX2
            // 
            this.tableX2.BackColor = System.Drawing.Color.White;
            this.tableX2.Columns = 1;
            this.tableX2.Location = new System.Drawing.Point(32, 510);
            this.tableX2.Name = "tableX2";
            this.tableX2.Rows = 1;
            this.tableX2.Size = new System.Drawing.Size(762, 286);
            this.tableX2.TabIndex = 13;
            // 
            // tableX1
            // 
            this.tableX1.BackColor = System.Drawing.Color.White;
            this.tableX1.Columns = 1;
            this.tableX1.Location = new System.Drawing.Point(32, 134);
            this.tableX1.Name = "tableX1";
            this.tableX1.Rows = 1;
            this.tableX1.Size = new System.Drawing.Size(762, 286);
            this.tableX1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 914);
            this.Controls.Add(this.tableX2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExample1);
            this.Controls.Add(this.tableX1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputColumns);
            this.Controls.Add(this.inputRows);
            this.Name = "Form1";
            this.Text = "Transport task";
            ((System.ComponentModel.ISupportInitialize)(this.inputRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown inputRows;
        private System.Windows.Forms.NumericUpDown inputColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private TableX tableX1;
        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private TableX tableX2;
    }
}

