namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lb_SIze = new System.Windows.Forms.Label();
            this.btn_temp = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_One = new System.Windows.Forms.Button();
            this.btn_getpath = new System.Windows.Forms.Button();
            this.txt_ = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1_image = new System.Windows.Forms.ListBox();
            this.btn_redo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_redo);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.lb_SIze);
            this.panel1.Controls.Add(this.btn_temp);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_order);
            this.panel1.Controls.Add(this.btn_two);
            this.panel1.Controls.Add(this.btn_One);
            this.panel1.Controls.Add(this.btn_getpath);
            this.panel1.Controls.Add(this.txt_);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 44);
            this.panel1.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(1008, 10);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(89, 23);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "Refresh(F12)";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lb_SIze
            // 
            this.lb_SIze.AutoSize = true;
            this.lb_SIze.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_SIze.ForeColor = System.Drawing.Color.Red;
            this.lb_SIze.Location = new System.Drawing.Point(328, 17);
            this.lb_SIze.Name = "lb_SIze";
            this.lb_SIze.Size = new System.Drawing.Size(110, 13);
            this.lb_SIze.TabIndex = 5;
            this.lb_SIze.Text = "사이즈 기준미달";
            // 
            // btn_temp
            // 
            this.btn_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_temp.Location = new System.Drawing.Point(771, 10);
            this.btn_temp.Name = "btn_temp";
            this.btn_temp.Size = new System.Drawing.Size(75, 23);
            this.btn_temp.TabIndex = 4;
            this.btn_temp.Text = "임시(F4)";
            this.btn_temp.UseVisualStyleBackColor = true;
            this.btn_temp.Click += new System.EventHandler(this.btn_temp_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(850, 10);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "삭제(F5)";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_order
            // 
            this.btn_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_order.Location = new System.Drawing.Point(692, 10);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "기타(F3)";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_two
            // 
            this.btn_two.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_two.Location = new System.Drawing.Point(613, 10);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(75, 23);
            this.btn_two.TabIndex = 2;
            this.btn_two.Text = "복합(F2)";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_One
            // 
            this.btn_One.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_One.Location = new System.Drawing.Point(534, 10);
            this.btn_One.Name = "btn_One";
            this.btn_One.Size = new System.Drawing.Size(75, 23);
            this.btn_One.TabIndex = 2;
            this.btn_One.Text = "단일(F1)";
            this.btn_One.UseVisualStyleBackColor = true;
            this.btn_One.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_getpath
            // 
            this.btn_getpath.Location = new System.Drawing.Point(227, 10);
            this.btn_getpath.Name = "btn_getpath";
            this.btn_getpath.Size = new System.Drawing.Size(75, 23);
            this.btn_getpath.TabIndex = 1;
            this.btn_getpath.Text = "...";
            this.btn_getpath.UseVisualStyleBackColor = true;
            this.btn_getpath.Click += new System.EventHandler(this.btn_getpath_Click);
            // 
            // txt_
            // 
            this.txt_.Location = new System.Drawing.Point(12, 12);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(209, 21);
            this.txt_.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 536);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(913, 536);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox1_image);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 536);
            this.panel3.TabIndex = 0;
            // 
            // listBox1_image
            // 
            this.listBox1_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1_image.FormattingEnabled = true;
            this.listBox1_image.ItemHeight = 12;
            this.listBox1_image.Location = new System.Drawing.Point(0, 0);
            this.listBox1_image.Name = "listBox1_image";
            this.listBox1_image.Size = new System.Drawing.Size(200, 536);
            this.listBox1_image.TabIndex = 0;
            // 
            // btn_redo
            // 
            this.btn_redo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_redo.Location = new System.Drawing.Point(929, 10);
            this.btn_redo.Name = "btn_redo";
            this.btn_redo.Size = new System.Drawing.Size(75, 23);
            this.btn_redo.TabIndex = 7;
            this.btn_redo.Text = "복구(F9)";
            this.btn_redo.UseVisualStyleBackColor = true;
            this.btn_redo.Click += new System.EventHandler(this.btn_redo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "이미지 분류기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_One;
        private System.Windows.Forms.Button btn_getpath;
        private System.Windows.Forms.TextBox txt_;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox1_image;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_temp;
        private System.Windows.Forms.Label lb_SIze;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_redo;
    }
}

