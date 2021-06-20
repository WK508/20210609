
namespace _20210620
{
    partial class Lotto
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num7 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num4 = new System.Windows.Forms.TextBox();
            this.num5 = new System.Windows.Forms.TextBox();
            this.num6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(160, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "로또 당첨 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(478, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "보너스 번호";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(110, 99);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(42, 21);
            this.num1.TabIndex = 2;
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(490, 97);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(42, 21);
            this.num7.TabIndex = 3;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(180, 98);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(42, 21);
            this.num2.TabIndex = 4;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(248, 98);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(42, 21);
            this.num3.TabIndex = 5;
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(110, 142);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(42, 21);
            this.num4.TabIndex = 6;
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(180, 142);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(42, 21);
            this.num5.TabIndex = 7;
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(248, 143);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(42, 21);
            this.num6.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(348, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lotto";
            this.Text = "Lotto";
            this.Load += new System.EventHandler(this.Lotto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num7;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num4;
        private System.Windows.Forms.TextBox num5;
        private System.Windows.Forms.TextBox num6;
        private System.Windows.Forms.Button button1;
    }
}

