using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace kmp
{
	class kmp
	{

		public double hashdegeraranacakmetin(string aranacakmetin)
		{
			double hasharanacakmetin = 0;
			for (int i = 0; i < aranacakmetin.Length; i++)
			{
				double b = Convert.ToInt32(aranacakmetin[i]);
				double c = Math.Pow(101,aranacakmetin.Length- (i + 1));
				hasharanacakmetin = hasharanacakmetin + (b * c);
			}
			return hasharanacakmetin;
			
		}
		public double hashdegermetin(string metin)
		{
			double hashmetin = 0;
			for (int i = 0; i < metin.Length; i++)
			{
				double b = Convert.ToInt32(metin[i]);
				double c = Math.Pow(101, metin.Length - (i + 1));
				hashmetin = hashmetin + (b * c);
			}
			return hashmetin;

		}
	}
}
