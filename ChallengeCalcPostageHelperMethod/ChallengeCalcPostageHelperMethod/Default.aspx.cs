using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeCalcPostageHelperMethod
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void handleChange(object sender, EventArgs e)
		{
			performCalculation();
		}
		private void performCalculation()
		{
			// Are there values in the text and checkboxes?
			if (!valuesExist()) return;


			//What is the Volume?
			int volume = 0;
			if (!tryGetVolume(out volume)) return;

			//Which multiplier is used?
			double postageMultiplier = getPostageMultiplier();

			//Determine the cost
			double cost = volume * postageMultiplier;

			//Show the result
			resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", cost);
		}

		private bool valuesExist()
		{
			if (!airRadioButton.Checked
				&& !groundRadioButton.Checked
				&& !nextdayRadioButton.Checked)
				return false;

			if (widthTextBox.Text.Trim().Length == 0 
				|| heightTextBox.Text.Trim().Length == 0)
				return false;

			return true;
		}

		private bool tryGetVolume(out int volume)
		{
			volume = 0;
			int width = 0;
			int height = 0;
			int length = 0;

			if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
			if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
			if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

			volume = width * height * length;
			return true;

		}

		private double getPostageMultiplier()
		{
			if (groundRadioButton.Checked) return .15;
			else if (airRadioButton.Checked) return .25;
			else if (nextdayRadioButton.Checked) return .45;
			else return 0;
		}

	}
}