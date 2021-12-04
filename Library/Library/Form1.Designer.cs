
using System.Threading.Tasks;

namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnDefaultList = new System.Windows.Forms.Button();
            this.BtnUyeList = new System.Windows.Forms.Button();
            this.BtnKitapList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnKitapAllList = new System.Windows.Forms.Button();
            this.BtnUyeAllList = new System.Windows.Forms.Button();
            this.BtnAllEmanetList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedIslemTarihi = new System.Windows.Forms.MaskedTextBox();
            this.maskedGeriAlma = new System.Windows.Forms.MaskedTextBox();
            this.maskedVerme = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbBoxTeslim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.gbxEmanet = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.mtbxEnd = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mtbxStart = new System.Windows.Forms.MaskedTextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.rbtEmanetGeriAlma = new System.Windows.Forms.RadioButton();
            this.rbtEmanetVerme = new System.Windows.Forms.RadioButton();
            this.rbtEmanetIslem = new System.Windows.Forms.RadioButton();
            this.btnEmanetAra = new System.Windows.Forms.Button();
            this.gbxArama = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.gbxEmanet.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.gbxArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // BtnDefaultList
            // 
            resources.ApplyResources(this.BtnDefaultList, "BtnDefaultList");
            this.BtnDefaultList.Name = "BtnDefaultList";
            this.BtnDefaultList.UseVisualStyleBackColor = true;
            this.BtnDefaultList.Click += new System.EventHandler(this.BtnDefaultList_Click);
            // 
            // BtnUyeList
            // 
            resources.ApplyResources(this.BtnUyeList, "BtnUyeList");
            this.BtnUyeList.Name = "BtnUyeList";
            this.BtnUyeList.UseVisualStyleBackColor = true;
            this.BtnUyeList.Click += new System.EventHandler(this.BtnUyeList_Click);
            // 
            // BtnKitapList
            // 
            resources.ApplyResources(this.BtnKitapList, "BtnKitapList");
            this.BtnKitapList.Name = "BtnKitapList";
            this.BtnKitapList.UseVisualStyleBackColor = true;
            this.BtnKitapList.Click += new System.EventHandler(this.BtnKitapList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.BtnDefaultList);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnKitapAllList);
            this.groupBox4.Controls.Add(this.BtnUyeAllList);
            this.groupBox4.Controls.Add(this.BtnAllEmanetList);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // BtnKitapAllList
            // 
            resources.ApplyResources(this.BtnKitapAllList, "BtnKitapAllList");
            this.BtnKitapAllList.Name = "BtnKitapAllList";
            this.BtnKitapAllList.UseVisualStyleBackColor = true;
            this.BtnKitapAllList.Click += new System.EventHandler(this.BtnKitapAllList_Click);
            // 
            // BtnUyeAllList
            // 
            resources.ApplyResources(this.BtnUyeAllList, "BtnUyeAllList");
            this.BtnUyeAllList.Name = "BtnUyeAllList";
            this.BtnUyeAllList.UseVisualStyleBackColor = true;
            this.BtnUyeAllList.Click += new System.EventHandler(this.BtnUyeAllList_Click);
            // 
            // BtnAllEmanetList
            // 
            resources.ApplyResources(this.BtnAllEmanetList, "BtnAllEmanetList");
            this.BtnAllEmanetList.Name = "BtnAllEmanetList";
            this.BtnAllEmanetList.UseVisualStyleBackColor = true;
            this.BtnAllEmanetList.Click += new System.EventHandler(this.BtnAllEmanetList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnKitapList);
            this.groupBox3.Controls.Add(this.BtnUyeList);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.maskedIslemTarihi);
            this.groupBox2.Controls.Add(this.maskedGeriAlma);
            this.groupBox2.Controls.Add(this.maskedVerme);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CmbBoxTeslim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.button1);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button7);
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.button7, "button7");
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Controls.Add(this.button5);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedIslemTarihi
            // 
            resources.ApplyResources(this.maskedIslemTarihi, "maskedIslemTarihi");
            this.maskedIslemTarihi.Name = "maskedIslemTarihi";
            this.maskedIslemTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // maskedGeriAlma
            // 
            resources.ApplyResources(this.maskedGeriAlma, "maskedGeriAlma");
            this.maskedGeriAlma.Name = "maskedGeriAlma";
            this.maskedGeriAlma.ValidatingType = typeof(System.DateTime);
            // 
            // maskedVerme
            // 
            resources.ApplyResources(this.maskedVerme, "maskedVerme");
            this.maskedVerme.Name = "maskedVerme";
            this.maskedVerme.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // CmbBoxTeslim
            // 
            resources.ApplyResources(this.CmbBoxTeslim, "CmbBoxTeslim");
            this.CmbBoxTeslim.FormattingEnabled = true;
            this.CmbBoxTeslim.Items.AddRange(new object[] {
            resources.GetString("CmbBoxTeslim.Items"),
            resources.GetString("CmbBoxTeslim.Items1"),
            resources.GetString("CmbBoxTeslim.Items2")});
            this.CmbBoxTeslim.Name = "CmbBoxTeslim";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.gbxEmanet);
            this.groupBox9.Controls.Add(this.gbxArama);
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // gbxEmanet
            // 
            this.gbxEmanet.Controls.Add(this.groupBox11);
            this.gbxEmanet.Controls.Add(this.groupBox10);
            this.gbxEmanet.Controls.Add(this.btnEmanetAra);
            resources.ApplyResources(this.gbxEmanet, "gbxEmanet");
            this.gbxEmanet.Name = "gbxEmanet";
            this.gbxEmanet.TabStop = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.mtbxEnd);
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.mtbxStart);
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            // 
            // mtbxEnd
            // 
            resources.ApplyResources(this.mtbxEnd, "mtbxEnd");
            this.mtbxEnd.Name = "mtbxEnd";
            this.mtbxEnd.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // mtbxStart
            // 
            resources.ApplyResources(this.mtbxStart, "mtbxStart");
            this.mtbxStart.Name = "mtbxStart";
            this.mtbxStart.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.rbtEmanetGeriAlma);
            this.groupBox10.Controls.Add(this.rbtEmanetVerme);
            this.groupBox10.Controls.Add(this.rbtEmanetIslem);
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            // 
            // rbtEmanetGeriAlma
            // 
            resources.ApplyResources(this.rbtEmanetGeriAlma, "rbtEmanetGeriAlma");
            this.rbtEmanetGeriAlma.Name = "rbtEmanetGeriAlma";
            this.rbtEmanetGeriAlma.TabStop = true;
            this.rbtEmanetGeriAlma.UseVisualStyleBackColor = true;
            // 
            // rbtEmanetVerme
            // 
            resources.ApplyResources(this.rbtEmanetVerme, "rbtEmanetVerme");
            this.rbtEmanetVerme.Name = "rbtEmanetVerme";
            this.rbtEmanetVerme.TabStop = true;
            this.rbtEmanetVerme.UseVisualStyleBackColor = true;
            // 
            // rbtEmanetIslem
            // 
            resources.ApplyResources(this.rbtEmanetIslem, "rbtEmanetIslem");
            this.rbtEmanetIslem.Name = "rbtEmanetIslem";
            this.rbtEmanetIslem.TabStop = true;
            this.rbtEmanetIslem.UseVisualStyleBackColor = true;
            // 
            // btnEmanetAra
            // 
            resources.ApplyResources(this.btnEmanetAra, "btnEmanetAra");
            this.btnEmanetAra.Name = "btnEmanetAra";
            this.btnEmanetAra.UseVisualStyleBackColor = true;
            this.btnEmanetAra.Click += new System.EventHandler(this.btnEmanetAra_Click);
            // 
            // gbxArama
            // 
            this.gbxArama.Controls.Add(this.tbxSearch);
            resources.ApplyResources(this.gbxArama, "gbxArama");
            this.gbxArama.Name = "gbxArama";
            this.gbxArama.TabStop = false;
            // 
            // tbxSearch
            // 
            resources.ApplyResources(this.tbxSearch, "tbxSearch");
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.gbxEmanet.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.gbxArama.ResumeLayout(false);
            this.gbxArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnDefaultList;
        private System.Windows.Forms.Button BtnUyeList;
        private System.Windows.Forms.Button BtnKitapList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnUyeAllList;
        private System.Windows.Forms.Button BtnKitapAllList;
        private System.Windows.Forms.Button BtnAllEmanetList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBoxTeslim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedVerme;
        private System.Windows.Forms.MaskedTextBox maskedIslemTarihi;
        private System.Windows.Forms.MaskedTextBox maskedGeriAlma;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox gbxArama;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox gbxEmanet;
        private System.Windows.Forms.RadioButton rbtEmanetIslem;
        private System.Windows.Forms.RadioButton rbtEmanetGeriAlma;
        private System.Windows.Forms.RadioButton rbtEmanetVerme;
        private System.Windows.Forms.Button btnEmanetAra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbxStart;
        private System.Windows.Forms.MaskedTextBox mtbxEnd;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
    }
}

