using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace kmp
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			openFileDialog1.FileName = "okunacak dosyayı seç";
			openFileDialog1.ShowDialog();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Stopwatch stopwatch = new Stopwatch();
			StreamReader oku = new StreamReader(openFileDialog1.FileName);
			kmp hash = new kmp();
	    	double hasharanacakmetin=hash.hashdegeraranacakmetin(aranan.Text);
			string satir;
			Boolean varmıyokmu=true;
			stopwatch.Start();
			while ((satir = oku.ReadLine()) != null)
			{
				if (aranan.Text.Length <= satir.Length)
				{
					for (int i = 0; i < satir.Length - aranan.Text.Length + 1; i++)
					{
						double hashdegermetin = hash.hashdegermetin(satir.Substring(i, aranan.Text.Length));
						if (hashdegermetin == hasharanacakmetin && satir.Length == aranan.Text.Length)
						{
							bulunan.Items.Add(satir);
							varmıyokmu = false;
						}
						else if (hashdegermetin == hasharanacakmetin)
						{
							if (satir.Length < aranan.Text.Length + 3)
							{
								bunumudemekistedin.Items.Add(satir);
								varmıyokmu = false;
							}
						}

					}
				}
			}
			if (varmıyokmu)
			{
				MessageBox.Show("aradığın kelime yok");
			}
			stopwatch.Stop();
			MessageBox.Show(stopwatch.Elapsed.ToString());
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void temizle_Click(object sender, EventArgs e)
		{
			bunumudemekistedin.Items.Clear();
			bulunan.Items.Clear();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
