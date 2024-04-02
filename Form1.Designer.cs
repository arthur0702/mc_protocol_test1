
namespace mc_protocol_test1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_TxCommand = new System.Windows.Forms.TextBox();
            this.txt_RxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Tx = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_MessageCLR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(204, 27);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(100, 56);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(61, 27);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(100, 25);
            this.txt_IP.TabIndex = 1;
            this.txt_IP.Text = "192.168.3.250";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(61, 58);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(100, 25);
            this.txt_Port.TabIndex = 2;
            this.txt_Port.Text = "5000";
            this.txt_Port.TextChanged += new System.EventHandler(this.txt_Port_TextChanged);
            // 
            // txt_TxCommand
            // 
            this.txt_TxCommand.Location = new System.Drawing.Point(22, 187);
            this.txt_TxCommand.MaxLength = 1024;
            this.txt_TxCommand.Name = "txt_TxCommand";
            this.txt_TxCommand.Size = new System.Drawing.Size(445, 25);
            this.txt_TxCommand.TabIndex = 3;
            this.txt_TxCommand.Text = "500000FF03FF000020001014010000M*00010000022347AB96";
            this.txt_TxCommand.WordWrap = false;
            // 
            // txt_RxMessage
            // 
            this.txt_RxMessage.Location = new System.Drawing.Point(22, 117);
            this.txt_RxMessage.Multiline = true;
            this.txt_RxMessage.Name = "txt_RxMessage";
            this.txt_RxMessage.Size = new System.Drawing.Size(445, 49);
            this.txt_RxMessage.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rx Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tx Command";
            // 
            // btn_Tx
            // 
            this.btn_Tx.Location = new System.Drawing.Point(342, 27);
            this.btn_Tx.Name = "btn_Tx";
            this.btn_Tx.Size = new System.Drawing.Size(95, 56);
            this.btn_Tx.TabIndex = 9;
            this.btn_Tx.Text = "Send";
            this.btn_Tx.UseVisualStyleBackColor = true;
            this.btn_Tx.Click += new System.EventHandler(this.btn_Tx_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_MessageCLR
            // 
            this.btn_MessageCLR.Location = new System.Drawing.Point(103, 92);
            this.btn_MessageCLR.Name = "btn_MessageCLR";
            this.btn_MessageCLR.Size = new System.Drawing.Size(57, 23);
            this.btn_MessageCLR.TabIndex = 10;
            this.btn_MessageCLR.Text = "CLR";
            this.btn_MessageCLR.UseVisualStyleBackColor = true;
            this.btn_MessageCLR.Click += new System.EventHandler(this.btn_MessageCLR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 249);
            this.Controls.Add(this.btn_MessageCLR);
            this.Controls.Add(this.btn_Tx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_RxMessage);
            this.Controls.Add(this.txt_TxCommand);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.btn_Connect);
            this.Name = "Form1";
            this.Text = "MC Protocol Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_RxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Tx;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_MessageCLR;
        private System.Windows.Forms.TextBox txt_TxCommand;
    }
}

