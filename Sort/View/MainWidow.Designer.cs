
namespace Sort
{
    partial class MainWindow
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
            this.TxtInputArray = new System.Windows.Forms.TextBox();
            this.LblInputArray = new System.Windows.Forms.Label();
            this.TxtSortedArray = new System.Windows.Forms.TextBox();
            this.LblSortedArray = new System.Windows.Forms.Label();
            this.BtnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtInputArray
            // 
            this.TxtInputArray.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtInputArray.Location = new System.Drawing.Point(12, 40);
            this.TxtInputArray.Name = "TxtInputArray";
            this.TxtInputArray.ReadOnly = true;
            this.TxtInputArray.Size = new System.Drawing.Size(318, 25);
            this.TxtInputArray.TabIndex = 0;
            // 
            // LblInputArray
            // 
            this.LblInputArray.AutoSize = true;
            this.LblInputArray.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblInputArray.Location = new System.Drawing.Point(8, 18);
            this.LblInputArray.Name = "LblInputArray";
            this.LblInputArray.Size = new System.Drawing.Size(119, 19);
            this.LblInputArray.TabIndex = 1;
            this.LblInputArray.Text = "Входной массив";
            // 
            // TxtSortedArray
            // 
            this.TxtSortedArray.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtSortedArray.Location = new System.Drawing.Point(12, 145);
            this.TxtSortedArray.Name = "TxtSortedArray";
            this.TxtSortedArray.ReadOnly = true;
            this.TxtSortedArray.Size = new System.Drawing.Size(318, 25);
            this.TxtSortedArray.TabIndex = 2;
            // 
            // LblSortedArray
            // 
            this.LblSortedArray.AutoSize = true;
            this.LblSortedArray.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSortedArray.Location = new System.Drawing.Point(8, 123);
            this.LblSortedArray.Name = "LblSortedArray";
            this.LblSortedArray.Size = new System.Drawing.Size(188, 19);
            this.LblSortedArray.TabIndex = 3;
            this.LblSortedArray.Text = "Отсортированный массив";
            // 
            // BtnSort
            // 
            this.BtnSort.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSort.Location = new System.Drawing.Point(352, 138);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(98, 37);
            this.BtnSort.TabIndex = 5;
            this.BtnSort.Text = "Сортировать";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(467, 195);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.LblSortedArray);
            this.Controls.Add(this.TxtSortedArray);
            this.Controls.Add(this.LblInputArray);
            this.Controls.Add(this.TxtInputArray);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInputArray;
        private System.Windows.Forms.Label LblInputArray;
        private System.Windows.Forms.TextBox TxtSortedArray;
        private System.Windows.Forms.Label LblSortedArray;
        private System.Windows.Forms.Button BtnSort;
    }
}

