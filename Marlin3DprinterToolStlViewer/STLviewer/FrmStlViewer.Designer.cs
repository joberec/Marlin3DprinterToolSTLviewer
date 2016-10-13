namespace STLviewer
{
    partial class FrmStlViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStlViewer));
            this.elementHostSTLviewerWPF = new System.Windows.Forms.Integration.ElementHost();
            this.stLviewerWPF1 = new STLviewer.STLviewerWPF();
            this.SuspendLayout();
            // 
            // elementHostSTLviewerWPF
            // 
            this.elementHostSTLviewerWPF.AllowDrop = true;
            this.elementHostSTLviewerWPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHostSTLviewerWPF.Location = new System.Drawing.Point(0, 0);
            this.elementHostSTLviewerWPF.Name = "elementHostSTLviewerWPF";
            this.elementHostSTLviewerWPF.Size = new System.Drawing.Size(284, 262);
            this.elementHostSTLviewerWPF.TabIndex = 0;
            this.elementHostSTLviewerWPF.Text = "elementHostSTLviewerWPF";
            this.elementHostSTLviewerWPF.Child = this.stLviewerWPF1;
            // 
            // FrmStlViewer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.elementHostSTLviewerWPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStlViewer";
            this.Text = "Stl Viewer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmStlViewer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmStlViewer_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHostSTLviewerWPF;
        private STLviewerWPF stLviewerWPF1;
    }
}

