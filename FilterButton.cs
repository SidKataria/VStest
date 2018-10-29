using System.Windows.Controls;
using System.Windows.Media;

namespace realestatefinder
{
    public class FilterButton : Button
    {
        static FilterButton()
        {
        }

        public void Handle_FilterButton_Click()
        {
            this.Background = this.Background == Brushes.AliceBlue ? Brushes.SlateBlue : Brushes.AliceBlue;
        }
    }
}
