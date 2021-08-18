
namespace TimestampsToCue
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.fileBrowserDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseFileBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timestampsTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "File path";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(13, 42);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(326, 31);
            this.filePathTextBox.TabIndex = 1;
            // 
            // fileBrowserDialog
            // 
            this.fileBrowserDialog.FileName = "openFileDialog1";
            // 
            // browseFileBtn
            // 
            this.browseFileBtn.Location = new System.Drawing.Point(346, 42);
            this.browseFileBtn.Name = "browseFileBtn";
            this.browseFileBtn.Size = new System.Drawing.Size(112, 34);
            this.browseFileBtn.TabIndex = 2;
            this.browseFileBtn.Text = "Browse";
            this.browseFileBtn.UseVisualStyleBackColor = true;
            this.browseFileBtn.Click += new System.EventHandler(this.browseFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timestamps";
            // 
            // timestampsTextBox
            // 
            this.timestampsTextBox.Location = new System.Drawing.Point(13, 171);
            this.timestampsTextBox.Name = "timestampsTextBox";
            this.timestampsTextBox.Size = new System.Drawing.Size(445, 207);
            this.timestampsTextBox.TabIndex = 4;
            this.timestampsTextBox.Text = "";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(465, 42);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(465, 336);
            this.outputTextBox.TabIndex = 5;
            this.outputTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output";
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(13, 385);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(445, 34);
            this.processBtn.TabIndex = 7;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Title";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(13, 109);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(445, 31);
            this.titleBox.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 435);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.timestampsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseFileBtn);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Timestamp to Cue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.OpenFileDialog fileBrowserDialog;
        private System.Windows.Forms.Button browseFileBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox timestampsTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleBox;
    }
}

