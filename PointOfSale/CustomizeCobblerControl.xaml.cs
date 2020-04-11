using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        public void FillingButtonClicked(object sender, EventArgs e)
        {
            if(DataContext is Cobbler)
            {
                Cobbler cobbler = (Cobbler)DataContext;
                if (sender is Button button)
                {
                    switch (button.Name)
                    {
                        case "CherryButton":
                            cobbler.Fruit = FruitFilling.Cherry;
                            break;
                        case "BlueberryButton":
                            cobbler.Fruit = FruitFilling.Blueberry;
                            break;
                        case "PeachButton":
                            cobbler.Fruit = FruitFilling.Peach;
                            break;
                        default:
                            throw new NotImplementedException("Unknown flavor selected.");
                            break;
                    }
                }
            }
            
            
        }
    }
}
