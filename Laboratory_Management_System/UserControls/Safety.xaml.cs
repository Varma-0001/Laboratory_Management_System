using System;
using System.Windows;
using System.Windows.Controls;


namespace Laboratory_Management_System.UserControls
{
    /// <summary>
    /// Interaction logic for Safety.xaml
    /// </summary>
    public partial class Safety : UserControl
    {
        private ContentControl _rightPanel;
        public Safety(ContentControl rightPanel)
        {
            InitializeComponent();
            _rightPanel = rightPanel;
        }

        private void BtnCloves_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.Cloves("Page A");
        }

        private void BtnLabCoat_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.LabCoat("Page A");
        }

        private void BtnMask_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.Mask.Mask("Page A");
        }

        private void BtnApron_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.Apron("Page A");
        }

        private void BtnSand_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.SandBucket.SandBucket("Page A");
        }

        private void BtnFirstaid_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.FirstAidKit.FirstAidKit("Page A");
        }

        private void BtnFire_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.FireExtinguisher.FireExtinguisher("Page A");
        }

        private void BtnGoggles_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.Goggles.Goggles("Page A");
        }

        private void BtnCircuit_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.CircuitBreaker.CircuitBreaker("Page A");
        }

        private void BtnTools_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.InsulatedTools.InsulatedTools("Page A");
        }

        private void BtnTongs_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.Tongs.Tongs("Page A");
        }

        private void BtnForceps_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.Forceps.Forceps("Page A");
        }

        private void BtnSafetyShield_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.SafetyShield.SafetyShield("Page A");
        }

        private void BtnSolvent_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.SolventWasteBottles.Solvent("Page A");
        }

        private void BtnOxygen_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.EmergencyOxygenKit.EmergencyOxygenKit("Page A");
        }

        private void BtnXRay_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.XRayPPE.XRayPPE("Page A");
        }

        private void BtnResistanceGlass_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.CutResistantGlass.Cut("Page A");
        }

        private void BtnFBlanket_Click(object sender, RoutedEventArgs e)
        {
            _rightPanel.Content = new UserControlsSafety.FireBlanket.FireBlanket("Page A");
        }
    }
}
