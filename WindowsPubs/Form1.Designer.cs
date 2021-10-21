
namespace WindowsPubs
{
    partial class Form1
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
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAuthor
            // 
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridAuthor.Location = new System.Drawing.Point(0, 0);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.Size = new System.Drawing.Size(391, 450);
            this.gridAuthor.TabIndex = 0;
            // 
            // gridPublisher
            // 
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridPublisher.Location = new System.Drawing.Point(397, 0);
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.Size = new System.Drawing.Size(403, 450);
            this.gridPublisher.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridPublisher);
            this.Controls.Add(this.gridAuthor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAuthor;
        private System.Windows.Forms.DataGridView gridPublisher;
    }
}

