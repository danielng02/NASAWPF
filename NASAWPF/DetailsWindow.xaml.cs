using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NASAWPF
{
    /// <summary>
    /// Interakční logika pro DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        public DetailsWindow()
        {
            InitializeComponent();
        }
        public DetailsWindow(Neo n)
        {
            InitializeComponent();
            DataContext = n;
            min_diameter_m.Content = n.estimated_diameter.meters.estimated_diameter_min;
            max_diameter_m.Content = n.estimated_diameter.meters.estimated_diameter_max;

            min_diameter_f.Content = n.estimated_diameter.feet.estimated_diameter_min;
            max_diameter_f.Content = n.estimated_diameter.feet.estimated_diameter_max;

            approach_date.Content = n.close_approach_data[0].close_approach_date_full;
            epoch_approach_date.Content = n.close_approach_data[0].epoch_date_close_approach;

            orbitBody.Content = n.close_approach_data[0].orbiting_body;

            relativeVelocity_kms.Content = n.close_approach_data[0].relative_velocity.kilometers_per_second;
            relativeVelocity_kmh.Content = n.close_approach_data[0].relative_velocity.kilometers_per_hour;
            relativeVelocity_mh.Content = n.close_approach_data[0].relative_velocity.miles_per_hour;

            missDistance_lunar.Content = n.close_approach_data[0].miss_distance.lunar;
            missDistance_astronomical.Content = n.close_approach_data[0].miss_distance.astronomical;
            missDistance_kilometers.Content = n.close_approach_data[0].miss_distance.kilometers;
            missDistance_miles.Content = n.close_approach_data[0].miss_distance.miles;
        }
    }
}
