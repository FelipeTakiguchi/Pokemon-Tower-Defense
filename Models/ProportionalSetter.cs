using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_towerdefense.Models
{
    public class ProportionalSetter
    {
        // Get Screen Size Resolution
        public static Size windowSize = Screen.PrimaryScreen.WorkingArea.Size;

        public static int ConvertProportionalWidth(int value)
        {
            double proportionalWidth = windowSize.Width / 1920.0;

            return Convert.ToInt16(Convert.ToDouble(value) * proportionalWidth);
        }

        public static int ConvertProportionalHeight(int value)
        {
            double proportionalHeight = windowSize.Height / 1040.0;

            return Convert.ToInt16(Convert.ToDouble(value) * proportionalHeight);
        }
        public static int ConvertFontSize(int value)
        {
            double proportionalWidth = windowSize.Width / 1920.0;
            double proportionalHeight = windowSize.Height / 1040.0;

            return Convert.ToInt16(value * (Convert.ToDouble(proportionalWidth) / Convert.ToDouble(proportionalHeight)));
        }
    }
}
