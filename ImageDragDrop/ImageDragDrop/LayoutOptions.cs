using System;
using System.Windows.Forms;

namespace ImageDragDrop
{
	public partial class LayoutOptions : Form
	{
		public LayoutOptions()
		{
			InitializeComponent();
		}

		private void LayoutOptions_Load(object sender, EventArgs e)
		{
			EnableDisableOptions();
		}

		private void rbPortrait_CheckedChanged(object sender, EventArgs e)
		{
			EnableDisableOptions();
		}

		private void rbLandscape_CheckedChanged(object sender, EventArgs e)
		{
			EnableDisableOptions();
		}

		private void EnableDisableOptions()
		{
			if (rbPortrait.Checked)
			{
				gbPortraitOptions.Enabled = true;
				gbLandscapeOptions.Enabled = false;
			}
			else
			{
				gbPortraitOptions.Enabled = false;
				gbLandscapeOptions.Enabled = true;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit?", "Close Application?", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Hide();
				MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
				Application.Exit();
			}
			else
			{
				this.Activate();
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			int selectedOption = -1;

			if (rbPortrait.Checked)
			{
				if (rbPortrait3by3.Checked)
				{
					selectedOption = 0;
				}

				if (rbPortrait2by2.Checked)
				{
					selectedOption = 1;
				}

				if (rbPortrait3by2.Checked)
				{
					selectedOption = 2;
				}

				if (rbPortrait1by2.Checked)
				{
					selectedOption = 3;
				}

				if (rbPortrait1by1.Checked)
				{
					selectedOption = 4;
				}
			}
			else
			{
				if (rbLandscape1by2.Checked)
				{
					selectedOption = 5;
				}

				if (rbLandscape1by3.Checked)
				{
					selectedOption = 6;
				}
			}

			if (selectedOption == -1)
			{
				MessageBox.Show("Please select an option.");
				return;
			}

			MessageBox.Show(selectedOption.ToString());
		}
	}
}
