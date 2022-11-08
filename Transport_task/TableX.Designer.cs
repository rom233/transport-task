
namespace Transport_task
{
    partial class TableX
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.res0 = new System.Windows.Forms.TextBox();
            this.req0 = new System.Windows.Forms.TextBox();
            this.tb00 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // res0
            // 
            this.res0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(198)))), ((int)(((byte)(185)))));
            this.res0.Location = new System.Drawing.Point(65, 0);
            this.res0.Name = "res0";
            this.res0.Size = new System.Drawing.Size(64, 29);
            this.res0.TabIndex = 11;
            // 
            // req0
            // 
            this.req0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(198)))), ((int)(((byte)(185)))));
            this.req0.Location = new System.Drawing.Point(0, 29);
            this.req0.Name = "req0";
            this.req0.Size = new System.Drawing.Size(64, 29);
            this.req0.TabIndex = 10;
            // 
            // tb00
            // 
            this.tb00.Location = new System.Drawing.Point(0, 0);
            this.tb00.Name = "tb00";
            this.tb00.Size = new System.Drawing.Size(64, 29);
            this.tb00.TabIndex = 9;
            // 
            // TableX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.res0);
            this.Controls.Add(this.req0);
            this.Controls.Add(this.tb00);
            this.Name = "TableX";
            this.Size = new System.Drawing.Size(311, 137);
            this.Load += new System.EventHandler(this.TableX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox res0;
        private System.Windows.Forms.TextBox req0;
        private System.Windows.Forms.TextBox tb00;
    }
}
