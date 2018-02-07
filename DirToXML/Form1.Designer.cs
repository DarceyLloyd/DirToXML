namespace DirToXML
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblDir = new System.Windows.Forms.Label();
            this.btnGetDir = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.cbFileSizeInBytes = new System.Windows.Forms.CheckBox();
            this.cbCdata = new System.Windows.Forms.CheckBox();
            this.cbFilePathAsAttribute = new System.Windows.Forms.CheckBox();
            this.cbIncludeExtInFileName = new System.Windows.Forms.CheckBox();
            this.txtAttributeAppend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRootNode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChildNode = new System.Windows.Forms.TextBox();
            this.cbIncludePathInRootNode = new System.Windows.Forms.CheckBox();
            this.btnGenerateSimpleList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtWith = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUseQuotes = new System.Windows.Forms.CheckBox();
            this.cbAddTypeDetection = new System.Windows.Forms.CheckBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnSaveXMLFile = new System.Windows.Forms.Button();
            this.cbAddXMLRootNode = new System.Windows.Forms.CheckBox();
            this.txtDebug = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(828, 119);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(124, 25);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "GENERATE XML";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(12, 9);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(29, 13);
            this.lblDir.TabIndex = 1;
            this.lblDir.Text = "DIR:";
            // 
            // btnGetDir
            // 
            this.btnGetDir.Location = new System.Drawing.Point(1125, 4);
            this.btnGetDir.Name = "btnGetDir";
            this.btnGetDir.Size = new System.Drawing.Size(75, 23);
            this.btnGetDir.TabIndex = 2;
            this.btnGetDir.Text = "BROWSE";
            this.btnGetDir.UseVisualStyleBackColor = true;
            this.btnGetDir.Click += new System.EventHandler(this.btnGetDir_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(47, 7);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(1072, 20);
            this.txtDir.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(12, 148);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1185, 420);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Text = "";
            this.txtOutput.WordWrap = false;
            // 
            // cbFileSizeInBytes
            // 
            this.cbFileSizeInBytes.AutoSize = true;
            this.cbFileSizeInBytes.Checked = true;
            this.cbFileSizeInBytes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFileSizeInBytes.Location = new System.Drawing.Point(1109, 41);
            this.cbFileSizeInBytes.Name = "cbFileSizeInBytes";
            this.cbFileSizeInBytes.Size = new System.Drawing.Size(91, 17);
            this.cbFileSizeInBytes.TabIndex = 5;
            this.cbFileSizeInBytes.Text = "File size in KB";
            this.cbFileSizeInBytes.UseVisualStyleBackColor = true;
            // 
            // cbCdata
            // 
            this.cbCdata.AutoSize = true;
            this.cbCdata.Location = new System.Drawing.Point(784, 41);
            this.cbCdata.Name = "cbCdata";
            this.cbCdata.Size = new System.Drawing.Size(113, 17);
            this.cbCdata.TabIndex = 6;
            this.cbCdata.Text = "Use CDATA tags?";
            this.cbCdata.UseVisualStyleBackColor = true;
            // 
            // cbFilePathAsAttribute
            // 
            this.cbFilePathAsAttribute.AutoSize = true;
            this.cbFilePathAsAttribute.Checked = true;
            this.cbFilePathAsAttribute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFilePathAsAttribute.Location = new System.Drawing.Point(626, 41);
            this.cbFilePathAsAttribute.Name = "cbFilePathAsAttribute";
            this.cbFilePathAsAttribute.Size = new System.Drawing.Size(127, 17);
            this.cbFilePathAsAttribute.TabIndex = 7;
            this.cbFilePathAsAttribute.Text = "File path as attribute?";
            this.cbFilePathAsAttribute.UseVisualStyleBackColor = true;
            // 
            // cbIncludeExtInFileName
            // 
            this.cbIncludeExtInFileName.AutoSize = true;
            this.cbIncludeExtInFileName.Location = new System.Drawing.Point(919, 41);
            this.cbIncludeExtInFileName.Name = "cbIncludeExtInFileName";
            this.cbIncludeExtInFileName.Size = new System.Drawing.Size(171, 17);
            this.cbIncludeExtInFileName.TabIndex = 8;
            this.cbIncludeExtInFileName.Text = "Include extension in file name?";
            this.cbIncludeExtInFileName.UseVisualStyleBackColor = true;
            // 
            // txtAttributeAppend
            // 
            this.txtAttributeAppend.Location = new System.Drawing.Point(106, 64);
            this.txtAttributeAppend.Name = "txtAttributeAppend";
            this.txtAttributeAppend.Size = new System.Drawing.Size(1094, 20);
            this.txtAttributeAppend.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Attribute append:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Root node name:";
            // 
            // txtRootNode
            // 
            this.txtRootNode.Location = new System.Drawing.Point(106, 38);
            this.txtRootNode.Name = "txtRootNode";
            this.txtRootNode.Size = new System.Drawing.Size(104, 20);
            this.txtRootNode.TabIndex = 11;
            this.txtRootNode.Text = "files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Child node name:";
            // 
            // txtChildNode
            // 
            this.txtChildNode.Location = new System.Drawing.Point(323, 38);
            this.txtChildNode.Name = "txtChildNode";
            this.txtChildNode.Size = new System.Drawing.Size(104, 20);
            this.txtChildNode.TabIndex = 13;
            this.txtChildNode.Text = "file";
            // 
            // cbIncludePathInRootNode
            // 
            this.cbIncludePathInRootNode.AutoSize = true;
            this.cbIncludePathInRootNode.Location = new System.Drawing.Point(457, 41);
            this.cbIncludePathInRootNode.Name = "cbIncludePathInRootNode";
            this.cbIncludePathInRootNode.Size = new System.Drawing.Size(150, 17);
            this.cbIncludePathInRootNode.TabIndex = 20;
            this.cbIncludePathInRootNode.Text = "Include path in root node?";
            this.cbIncludePathInRootNode.UseVisualStyleBackColor = true;
            // 
            // btnGenerateSimpleList
            // 
            this.btnGenerateSimpleList.Location = new System.Drawing.Point(712, 119);
            this.btnGenerateSimpleList.Name = "btnGenerateSimpleList";
            this.btnGenerateSimpleList.Size = new System.Drawing.Size(110, 25);
            this.btnGenerateSimpleList.TabIndex = 21;
            this.btnGenerateSimpleList.Text = "GENERATE LIST";
            this.btnGenerateSimpleList.UseVisualStyleBackColor = true;
            this.btnGenerateSimpleList.Click += new System.EventHandler(this.btnGenerateSimpleList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Path replace:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(106, 93);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(391, 20);
            this.txtFind.TabIndex = 22;
            // 
            // txtWith
            // 
            this.txtWith.Location = new System.Drawing.Point(554, 93);
            this.txtWith.Name = "txtWith";
            this.txtWith.Size = new System.Drawing.Size(391, 20);
            this.txtWith.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "with";
            // 
            // cbUseQuotes
            // 
            this.cbUseQuotes.AutoSize = true;
            this.cbUseQuotes.Checked = true;
            this.cbUseQuotes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseQuotes.Location = new System.Drawing.Point(15, 119);
            this.cbUseQuotes.Name = "cbUseQuotes";
            this.cbUseQuotes.Size = new System.Drawing.Size(107, 17);
            this.cbUseQuotes.TabIndex = 26;
            this.cbUseQuotes.Text = "Use \" instead of \'";
            this.cbUseQuotes.UseVisualStyleBackColor = true;
            // 
            // cbAddTypeDetection
            // 
            this.cbAddTypeDetection.AutoSize = true;
            this.cbAddTypeDetection.Location = new System.Drawing.Point(148, 119);
            this.cbAddTypeDetection.Name = "cbAddTypeDetection";
            this.cbAddTypeDetection.Size = new System.Drawing.Size(156, 17);
            this.cbAddTypeDetection.TabIndex = 27;
            this.cbAddTypeDetection.Text = "Add type detection attribute";
            this.cbAddTypeDetection.UseVisualStyleBackColor = true;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(958, 119);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(133, 23);
            this.btnCopyToClipboard.TabIndex = 28;
            this.btnCopyToClipboard.Text = "COPY TO CLIPBOARD";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnSaveXMLFile
            // 
            this.btnSaveXMLFile.Location = new System.Drawing.Point(1097, 119);
            this.btnSaveXMLFile.Name = "btnSaveXMLFile";
            this.btnSaveXMLFile.Size = new System.Drawing.Size(103, 23);
            this.btnSaveXMLFile.TabIndex = 29;
            this.btnSaveXMLFile.Text = "SAVE XML FILE";
            this.btnSaveXMLFile.UseVisualStyleBackColor = true;
            this.btnSaveXMLFile.Click += new System.EventHandler(this.btnSaveXMLFile_Click);
            // 
            // cbAddXMLRootNode
            // 
            this.cbAddXMLRootNode.AutoSize = true;
            this.cbAddXMLRootNode.Checked = true;
            this.cbAddXMLRootNode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddXMLRootNode.Location = new System.Drawing.Point(323, 120);
            this.cbAddXMLRootNode.Name = "cbAddXMLRootNode";
            this.cbAddXMLRootNode.Size = new System.Drawing.Size(124, 17);
            this.cbAddXMLRootNode.TabIndex = 30;
            this.cbAddXMLRootNode.Text = "Add XML root node?";
            this.cbAddXMLRootNode.UseVisualStyleBackColor = true;
            // 
            // txtDebug
            // 
            this.txtDebug.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebug.Location = new System.Drawing.Point(12, 574);
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(1185, 23);
            this.txtDebug.TabIndex = 31;
            this.txtDebug.Text = "";
            this.txtDebug.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 609);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.cbAddXMLRootNode);
            this.Controls.Add(this.btnSaveXMLFile);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.cbAddTypeDetection);
            this.Controls.Add(this.cbUseQuotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWith);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnGenerateSimpleList);
            this.Controls.Add(this.cbIncludePathInRootNode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChildNode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRootNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAttributeAppend);
            this.Controls.Add(this.cbIncludeExtInFileName);
            this.Controls.Add(this.cbFilePathAsAttribute);
            this.Controls.Add(this.cbCdata);
            this.Controls.Add(this.cbFileSizeInBytes);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.btnGetDir);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.btnGenerate);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIR to XML v1.07 by Darcey@AllForTheCode.co.uk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Button btnGetDir;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.CheckBox cbFileSizeInBytes;
        private System.Windows.Forms.CheckBox cbCdata;
        private System.Windows.Forms.CheckBox cbFilePathAsAttribute;
        private System.Windows.Forms.CheckBox cbIncludeExtInFileName;
        private System.Windows.Forms.TextBox txtAttributeAppend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRootNode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChildNode;
        private System.Windows.Forms.CheckBox cbIncludePathInRootNode;
        private System.Windows.Forms.Button btnGenerateSimpleList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtWith;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbUseQuotes;
        private System.Windows.Forms.CheckBox cbAddTypeDetection;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnSaveXMLFile;
        private System.Windows.Forms.CheckBox cbAddXMLRootNode;
        private System.Windows.Forms.RichTextBox txtDebug;
    }
}

