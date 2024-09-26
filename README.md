# TempatureConverterForm

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempatureConverter {
	public partial class TempatureConverterForm : Form {
		public TempatureConverterForm() {
			InitializeComponent();
		}

		private void convertFtoCButton_Click(object sender, EventArgs e) {
			double fahrenheit = double.Parse(fahrenheitTextBox.Text);
			double celsius = (fahrenheit - 32) * 5 / 9;

			// Format the output to two decimal places
			cOutLabel.Text = $"= {celsius:F2}°C";
		}

		private void convertCtoFButton_Click(object sender, EventArgs e) {
			double celsius = double.Parse(celsiusTextBox.Text);
			double fahrenheit = (celsius * 9 / 5) + 32;

			// Format the output to two decimal places
			fOutLabel.Text = $"= {fahrenheit:F2}°F";
		}
	}
}

```
