namespace WindowsClient
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRequestReplyOperation = new System.Windows.Forms.Button();
            this.btnRequestReplyOperation_ThrowsException = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.OneWayOperation = new System.Windows.Forms.Button();
            this.OneWayOperation_ThrowsException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1009, 180);
            this.listBox1.TabIndex = 0;
            // 
            // btnRequestReplyOperation
            // 
            this.btnRequestReplyOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequestReplyOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRequestReplyOperation.Location = new System.Drawing.Point(12, 236);
            this.btnRequestReplyOperation.Name = "btnRequestReplyOperation";
            this.btnRequestReplyOperation.Size = new System.Drawing.Size(1009, 74);
            this.btnRequestReplyOperation.TabIndex = 1;
            this.btnRequestReplyOperation.Text = "Request Reply Operation";
            this.btnRequestReplyOperation.UseVisualStyleBackColor = true;
            this.btnRequestReplyOperation.Click += new System.EventHandler(this.btnRequestReplyOperation_Click);
            // 
            // btnRequestReplyOperation_ThrowsException
            // 
            this.btnRequestReplyOperation_ThrowsException.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequestReplyOperation_ThrowsException.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRequestReplyOperation_ThrowsException.Location = new System.Drawing.Point(12, 337);
            this.btnRequestReplyOperation_ThrowsException.Name = "btnRequestReplyOperation_ThrowsException";
            this.btnRequestReplyOperation_ThrowsException.Size = new System.Drawing.Size(1009, 60);
            this.btnRequestReplyOperation_ThrowsException.TabIndex = 2;
            this.btnRequestReplyOperation_ThrowsException.Text = "Request Reply Operation - Throws Exception";
            this.btnRequestReplyOperation_ThrowsException.UseVisualStyleBackColor = true;
            this.btnRequestReplyOperation_ThrowsException.Click += new System.EventHandler(this.btnRequestReplyOperation_ThrowsException_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(12, 592);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(1009, 64);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // OneWayOperation
            // 
            this.OneWayOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneWayOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OneWayOperation.Location = new System.Drawing.Point(12, 418);
            this.OneWayOperation.Name = "OneWayOperation";
            this.OneWayOperation.Size = new System.Drawing.Size(1009, 60);
            this.OneWayOperation.TabIndex = 4;
            this.OneWayOperation.Text = "One Way Operation";
            this.OneWayOperation.UseVisualStyleBackColor = true;
            this.OneWayOperation.Click += new System.EventHandler(this.OneWayOperation_Click);
            // 
            // OneWayOperation_ThrowsException
            // 
            this.OneWayOperation_ThrowsException.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneWayOperation_ThrowsException.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OneWayOperation_ThrowsException.Location = new System.Drawing.Point(12, 510);
            this.OneWayOperation_ThrowsException.Name = "OneWayOperation_ThrowsException";
            this.OneWayOperation_ThrowsException.Size = new System.Drawing.Size(1009, 60);
            this.OneWayOperation_ThrowsException.TabIndex = 5;
            this.OneWayOperation_ThrowsException.Text = "One Way Operation - Throws Exception";
            this.OneWayOperation_ThrowsException.UseVisualStyleBackColor = true;
            this.OneWayOperation_ThrowsException.Click += new System.EventHandler(this.OneWayOperation_ThrowsException_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 691);
            this.Controls.Add(this.OneWayOperation_ThrowsException);
            this.Controls.Add(this.OneWayOperation);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRequestReplyOperation_ThrowsException);
            this.Controls.Add(this.btnRequestReplyOperation);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRequestReplyOperation;
        private System.Windows.Forms.Button btnRequestReplyOperation_ThrowsException;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button OneWayOperation;
        private System.Windows.Forms.Button OneWayOperation_ThrowsException;
    }
}

