namespace TH_Buoi_3
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxSelection = new System.Windows.Forms.TextBox();
            this.txtboxResult = new System.Windows.Forms.TextBox();
            this.btnKeo = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Selection:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Result:";
            // 
            // txtboxSelection
            // 
            this.txtboxSelection.Location = new System.Drawing.Point(136, 28);
            this.txtboxSelection.Multiline = true;
            this.txtboxSelection.Name = "txtboxSelection";
            this.txtboxSelection.Size = new System.Drawing.Size(404, 32);
            this.txtboxSelection.TabIndex = 2;
            // 
            // txtboxResult
            // 
            this.txtboxResult.Location = new System.Drawing.Point(136, 244);
            this.txtboxResult.Multiline = true;
            this.txtboxResult.Name = "txtboxResult";
            this.txtboxResult.Size = new System.Drawing.Size(213, 32);
            this.txtboxResult.TabIndex = 3;
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(43, 92);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(123, 119);
            this.btnKeo.TabIndex = 4;
            this.btnKeo.Text = "Kéo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(222, 92);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(123, 119);
            this.btnBua.TabIndex = 5;
            this.btnBua.Text = "Búa";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(402, 92);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(123, 119);
            this.btnBao.TabIndex = 6;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 303);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.txtboxResult);
            this.Controls.Add(this.txtboxSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxSelection;
        private System.Windows.Forms.TextBox txtboxResult;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnBao;
    }
}

