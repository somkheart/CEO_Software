namespace CEO_FPM_V3._0_Standard.Ctrl
{
    partial class CtrlExportButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlExportButton));
            this.ExportList = new System.Windows.Forms.PictureBox();
            this.BtList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExportList)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportList
            // 
            this.ExportList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportList.Location = new System.Drawing.Point(0, 0);
            this.ExportList.Name = "ExportList";
            this.ExportList.Size = new System.Drawing.Size(126, 42);
            this.ExportList.TabIndex = 0;
            this.ExportList.TabStop = false;
            this.ExportList.Click += new System.EventHandler(this.ExportList_Click);
            this.ExportList.MouseLeave += new System.EventHandler(this.ExportList_MouseLeave);
            this.ExportList.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // BtList
            // 
            this.BtList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BtList.ImageStream")));
            this.BtList.TransparentColor = System.Drawing.Color.Transparent;
            this.BtList.Images.SetKeyName(0, "button-1.png");
            this.BtList.Images.SetKeyName(1, "button-2.png");
            // 
            // CtrlExportButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExportList);
            this.Name = "CtrlExportButton";
            this.Size = new System.Drawing.Size(128, 50);
            ((System.ComponentModel.ISupportInitialize)(this.ExportList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ExportList;
        private System.Windows.Forms.ImageList BtList;

    }
}
