namespace kmp
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
			this.aranan = new System.Windows.Forms.TextBox();
			this.bulunan = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.bunumudemekistedin = new System.Windows.Forms.ListBox();
			this.temizle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// aranan
			// 
			this.aranan.Location = new System.Drawing.Point(12, 58);
			this.aranan.Name = "aranan";
			this.aranan.Size = new System.Drawing.Size(327, 20);
			this.aranan.TabIndex = 0;
			this.aranan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// bulunan
			// 
			this.bulunan.FormattingEnabled = true;
			this.bulunan.Location = new System.Drawing.Point(359, 34);
			this.bulunan.Name = "bulunan";
			this.bulunan.Size = new System.Drawing.Size(135, 251);
			this.bulunan.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 84);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(327, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "okunacak dosyayı seç";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 113);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(327, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "ara";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// bunumudemekistedin
			// 
			this.bunumudemekistedin.FormattingEnabled = true;
			this.bunumudemekistedin.Location = new System.Drawing.Point(500, 34);
			this.bunumudemekistedin.Name = "bunumudemekistedin";
			this.bunumudemekistedin.Size = new System.Drawing.Size(144, 251);
			this.bunumudemekistedin.TabIndex = 5;
			// 
			// temizle
			// 
			this.temizle.Location = new System.Drawing.Point(359, 291);
			this.temizle.Name = "temizle";
			this.temizle.Size = new System.Drawing.Size(285, 23);
			this.temizle.TabIndex = 6;
			this.temizle.Text = "temizle";
			this.temizle.UseVisualStyleBackColor = true;
			this.temizle.Click += new System.EventHandler(this.temizle_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.temizle);
			this.Controls.Add(this.bunumudemekistedin);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bulunan);
			this.Controls.Add(this.aranan);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox aranan;
		private System.Windows.Forms.ListBox bulunan;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ListBox bunumudemekistedin;
		private System.Windows.Forms.Button temizle;
	}
}

