namespace TicTac
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
            this.pole = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pole)).BeginInit();
            this.SuspendLayout();
            // 
            // pole
            // 
            this.pole.AllowUserToAddRows = false;
            this.pole.AllowUserToDeleteRows = false;
            this.pole.AllowUserToResizeColumns = false;
            this.pole.AllowUserToResizeRows = false;
            this.pole.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.pole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.pole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pole.ColumnHeadersVisible = false;
            this.pole.Location = new System.Drawing.Point(0, 0);
            this.pole.MultiSelect = false;
            this.pole.Name = "pole";
            this.pole.RowHeadersVisible = false;
            this.pole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.pole.Size = new System.Drawing.Size(410, 315);
            this.pole.TabIndex = 0;
            this.pole.TabStop = false;
            this.pole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 327);
            this.Controls.Add(this.pole);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pole;
    }
}

