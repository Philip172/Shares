
namespace Акции
{
    partial class Shares_gameForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.tb_buy_chalk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sale_chalk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buy_chalk = new System.Windows.Forms.Button();
            this.btn_sale_chalk = new System.Windows.Forms.Button();
            this.tb_cost_chalk = new System.Windows.Forms.TextBox();
            this.tb_have_chalk = new System.Windows.Forms.TextBox();
            this.GB_chalk = new System.Windows.Forms.GroupBox();
            this.tb_almoney_chalk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_saleAll_chalk = new System.Windows.Forms.Button();
            this.btn_buyAll_chalk = new System.Windows.Forms.Button();
            this.label_name_chalk = new System.Windows.Forms.Label();
            this.reload_textbox = new System.Windows.Forms.Timer(this.components);
            this.next_day = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.events = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_almoney_gold = new System.Windows.Forms.TextBox();
            this.btn_saleAll_gold = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_buyAll_gold = new System.Windows.Forms.Button();
            this.label_name_gold = new System.Windows.Forms.Label();
            this.btn_buy_gold = new System.Windows.Forms.Button();
            this.btn_sale_gold = new System.Windows.Forms.Button();
            this.tb_buy_gold = new System.Windows.Forms.TextBox();
            this.tb_cost_gold = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_sale_gold = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_have_gold = new System.Windows.Forms.TextBox();
            this.GB_chalk.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(925, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Деньги";
            // 
            // tb_money
            // 
            this.tb_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_money.Location = new System.Drawing.Point(631, 56);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(748, 39);
            this.tb_money.TabIndex = 1;
            // 
            // tb_buy_chalk
            // 
            this.tb_buy_chalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_buy_chalk.Location = new System.Drawing.Point(164, 224);
            this.tb_buy_chalk.Name = "tb_buy_chalk";
            this.tb_buy_chalk.Size = new System.Drawing.Size(262, 41);
            this.tb_buy_chalk.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "стоимость:";
            // 
            // tb_sale_chalk
            // 
            this.tb_sale_chalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sale_chalk.Location = new System.Drawing.Point(164, 283);
            this.tb_sale_chalk.Name = "tb_sale_chalk";
            this.tb_sale_chalk.Size = new System.Drawing.Size(262, 41);
            this.tb_sale_chalk.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "у вас:";
            // 
            // btn_buy_chalk
            // 
            this.btn_buy_chalk.Location = new System.Drawing.Point(12, 220);
            this.btn_buy_chalk.Name = "btn_buy_chalk";
            this.btn_buy_chalk.Size = new System.Drawing.Size(146, 46);
            this.btn_buy_chalk.TabIndex = 4;
            this.btn_buy_chalk.Text = "купить";
            this.btn_buy_chalk.UseVisualStyleBackColor = true;
            this.btn_buy_chalk.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sale_chalk
            // 
            this.btn_sale_chalk.Location = new System.Drawing.Point(12, 279);
            this.btn_sale_chalk.Name = "btn_sale_chalk";
            this.btn_sale_chalk.Size = new System.Drawing.Size(146, 46);
            this.btn_sale_chalk.TabIndex = 4;
            this.btn_sale_chalk.Text = "продать";
            this.btn_sale_chalk.UseVisualStyleBackColor = true;
            this.btn_sale_chalk.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_cost_chalk
            // 
            this.tb_cost_chalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_cost_chalk.Location = new System.Drawing.Point(164, 113);
            this.tb_cost_chalk.Name = "tb_cost_chalk";
            this.tb_cost_chalk.Size = new System.Drawing.Size(262, 41);
            this.tb_cost_chalk.TabIndex = 2;
            // 
            // tb_have_chalk
            // 
            this.tb_have_chalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_have_chalk.Location = new System.Drawing.Point(164, 172);
            this.tb_have_chalk.Name = "tb_have_chalk";
            this.tb_have_chalk.Size = new System.Drawing.Size(262, 41);
            this.tb_have_chalk.TabIndex = 2;
            // 
            // GB_chalk
            // 
            this.GB_chalk.Controls.Add(this.tb_almoney_chalk);
            this.GB_chalk.Controls.Add(this.label4);
            this.GB_chalk.Controls.Add(this.btn_saleAll_chalk);
            this.GB_chalk.Controls.Add(this.btn_buyAll_chalk);
            this.GB_chalk.Controls.Add(this.label_name_chalk);
            this.GB_chalk.Controls.Add(this.btn_buy_chalk);
            this.GB_chalk.Controls.Add(this.btn_sale_chalk);
            this.GB_chalk.Controls.Add(this.tb_buy_chalk);
            this.GB_chalk.Controls.Add(this.tb_cost_chalk);
            this.GB_chalk.Controls.Add(this.label3);
            this.GB_chalk.Controls.Add(this.tb_sale_chalk);
            this.GB_chalk.Controls.Add(this.label2);
            this.GB_chalk.Controls.Add(this.tb_have_chalk);
            this.GB_chalk.Location = new System.Drawing.Point(79, 185);
            this.GB_chalk.Name = "GB_chalk";
            this.GB_chalk.Size = new System.Drawing.Size(709, 358);
            this.GB_chalk.TabIndex = 5;
            this.GB_chalk.TabStop = false;
            // 
            // tb_almoney_chalk
            // 
            this.tb_almoney_chalk.Location = new System.Drawing.Point(456, 55);
            this.tb_almoney_chalk.Name = "tb_almoney_chalk";
            this.tb_almoney_chalk.Size = new System.Drawing.Size(244, 38);
            this.tb_almoney_chalk.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "стоимость ваших активов";
            // 
            // btn_saleAll_chalk
            // 
            this.btn_saleAll_chalk.Location = new System.Drawing.Point(432, 279);
            this.btn_saleAll_chalk.Name = "btn_saleAll_chalk";
            this.btn_saleAll_chalk.Size = new System.Drawing.Size(187, 46);
            this.btn_saleAll_chalk.TabIndex = 6;
            this.btn_saleAll_chalk.Text = "продать всё";
            this.btn_saleAll_chalk.UseVisualStyleBackColor = true;
            this.btn_saleAll_chalk.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_buyAll_chalk
            // 
            this.btn_buyAll_chalk.Location = new System.Drawing.Point(432, 220);
            this.btn_buyAll_chalk.Name = "btn_buyAll_chalk";
            this.btn_buyAll_chalk.Size = new System.Drawing.Size(187, 46);
            this.btn_buyAll_chalk.TabIndex = 6;
            this.btn_buyAll_chalk.Text = "купить всё";
            this.btn_buyAll_chalk.UseVisualStyleBackColor = true;
            this.btn_buyAll_chalk.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_name_chalk
            // 
            this.label_name_chalk.AutoSize = true;
            this.label_name_chalk.Location = new System.Drawing.Point(241, 21);
            this.label_name_chalk.Name = "label_name_chalk";
            this.label_name_chalk.Size = new System.Drawing.Size(66, 31);
            this.label_name_chalk.TabIndex = 5;
            this.label_name_chalk.Text = "Мел";
            // 
            // reload_textbox
            // 
            this.reload_textbox.Enabled = true;
            this.reload_textbox.Interval = 1;
            this.reload_textbox.Tick += new System.EventHandler(this.timer_reload_tick);
            // 
            // next_day
            // 
            this.next_day.Enabled = true;
            this.next_day.Interval = 3800;
            this.next_day.Tick += new System.EventHandler(this.next_day_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1326, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "События:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "_";
            this.label6.Visible = false;
            // 
            // events
            // 
            this.events.Enabled = true;
            this.events.Interval = 12000;
            this.events.Tick += new System.EventHandler(this.events_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_almoney_gold);
            this.groupBox1.Controls.Add(this.btn_saleAll_gold);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_buyAll_gold);
            this.groupBox1.Controls.Add(this.label_name_gold);
            this.groupBox1.Controls.Add(this.btn_buy_gold);
            this.groupBox1.Controls.Add(this.btn_sale_gold);
            this.groupBox1.Controls.Add(this.tb_buy_gold);
            this.groupBox1.Controls.Add(this.tb_cost_gold);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_sale_gold);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_have_gold);
            this.groupBox1.Location = new System.Drawing.Point(79, 560);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 358);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tb_almoney_gold
            // 
            this.tb_almoney_gold.Location = new System.Drawing.Point(459, 54);
            this.tb_almoney_gold.Name = "tb_almoney_gold";
            this.tb_almoney_gold.Size = new System.Drawing.Size(244, 38);
            this.tb_almoney_gold.TabIndex = 8;
            // 
            // btn_saleAll_gold
            // 
            this.btn_saleAll_gold.Location = new System.Drawing.Point(432, 279);
            this.btn_saleAll_gold.Name = "btn_saleAll_gold";
            this.btn_saleAll_gold.Size = new System.Drawing.Size(187, 46);
            this.btn_saleAll_gold.TabIndex = 6;
            this.btn_saleAll_gold.Text = "продать всё";
            this.btn_saleAll_gold.UseVisualStyleBackColor = true;
            this.btn_saleAll_gold.Click += new System.EventHandler(this.btn_saleAll_gold_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "стоимость ваших активов";
            // 
            // btn_buyAll_gold
            // 
            this.btn_buyAll_gold.Location = new System.Drawing.Point(432, 220);
            this.btn_buyAll_gold.Name = "btn_buyAll_gold";
            this.btn_buyAll_gold.Size = new System.Drawing.Size(187, 46);
            this.btn_buyAll_gold.TabIndex = 6;
            this.btn_buyAll_gold.Text = "купить всё";
            this.btn_buyAll_gold.UseVisualStyleBackColor = true;
            this.btn_buyAll_gold.Click += new System.EventHandler(this.btn_buyAll_gold_Click);
            // 
            // label_name_gold
            // 
            this.label_name_gold.AutoSize = true;
            this.label_name_gold.Location = new System.Drawing.Point(224, 20);
            this.label_name_gold.Name = "label_name_gold";
            this.label_name_gold.Size = new System.Drawing.Size(103, 31);
            this.label_name_gold.TabIndex = 5;
            this.label_name_gold.Text = "Золото";
            // 
            // btn_buy_gold
            // 
            this.btn_buy_gold.Location = new System.Drawing.Point(12, 220);
            this.btn_buy_gold.Name = "btn_buy_gold";
            this.btn_buy_gold.Size = new System.Drawing.Size(146, 46);
            this.btn_buy_gold.TabIndex = 4;
            this.btn_buy_gold.Text = "купить";
            this.btn_buy_gold.UseVisualStyleBackColor = true;
            this.btn_buy_gold.Click += new System.EventHandler(this.btn_buy_gold_Click);
            // 
            // btn_sale_gold
            // 
            this.btn_sale_gold.Location = new System.Drawing.Point(12, 279);
            this.btn_sale_gold.Name = "btn_sale_gold";
            this.btn_sale_gold.Size = new System.Drawing.Size(146, 46);
            this.btn_sale_gold.TabIndex = 4;
            this.btn_sale_gold.Text = "продать";
            this.btn_sale_gold.UseVisualStyleBackColor = true;
            this.btn_sale_gold.Click += new System.EventHandler(this.btn_sale_gold_Click);
            // 
            // tb_buy_gold
            // 
            this.tb_buy_gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_buy_gold.Location = new System.Drawing.Point(164, 224);
            this.tb_buy_gold.Name = "tb_buy_gold";
            this.tb_buy_gold.Size = new System.Drawing.Size(262, 41);
            this.tb_buy_gold.TabIndex = 2;
            // 
            // tb_cost_gold
            // 
            this.tb_cost_gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_cost_gold.Location = new System.Drawing.Point(164, 113);
            this.tb_cost_gold.Name = "tb_cost_gold";
            this.tb_cost_gold.Size = new System.Drawing.Size(262, 41);
            this.tb_cost_gold.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "у вас:";
            // 
            // tb_sale_gold
            // 
            this.tb_sale_gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sale_gold.Location = new System.Drawing.Point(164, 283);
            this.tb_sale_gold.Name = "tb_sale_gold";
            this.tb_sale_gold.Size = new System.Drawing.Size(262, 41);
            this.tb_sale_gold.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "стоимость:";
            // 
            // tb_have_gold
            // 
            this.tb_have_gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_have_gold.Location = new System.Drawing.Point(164, 172);
            this.tb_have_gold.Name = "tb_have_gold";
            this.tb_have_gold.Size = new System.Drawing.Size(262, 41);
            this.tb_have_gold.TabIndex = 2;
            // 
            // Shares_gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GB_chalk);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Shares_gameForm";
            this.Text = "Shares";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GB_chalk.ResumeLayout(false);
            this.GB_chalk.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.TextBox tb_buy_chalk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sale_chalk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buy_chalk;
        private System.Windows.Forms.Button btn_sale_chalk;
        private System.Windows.Forms.TextBox tb_cost_chalk;
        private System.Windows.Forms.TextBox tb_have_chalk;
        private System.Windows.Forms.GroupBox GB_chalk;
        private System.Windows.Forms.Label label_name_chalk;
        private System.Windows.Forms.Timer reload_textbox;
        private System.Windows.Forms.Timer next_day;
        private System.Windows.Forms.Button btn_saleAll_chalk;
        private System.Windows.Forms.Button btn_buyAll_chalk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer events;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_saleAll_gold;
        private System.Windows.Forms.Button btn_buyAll_gold;
        private System.Windows.Forms.Label label_name_gold;
        private System.Windows.Forms.Button btn_buy_gold;
        private System.Windows.Forms.Button btn_sale_gold;
        private System.Windows.Forms.TextBox tb_buy_gold;
        private System.Windows.Forms.TextBox tb_cost_gold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_sale_gold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_have_gold;
        private System.Windows.Forms.TextBox tb_almoney_chalk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_almoney_gold;
        private System.Windows.Forms.Label label7;
    }
}

