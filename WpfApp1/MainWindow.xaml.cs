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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace AutoChess_Counter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAbaddonPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtAbaddonCount.Text);
            if (count < 3)
                ++count;
            TxtAbaddonCount.Text = count.ToString();
        }

        private void BtnAbaddonMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtAbaddonCount.Text);
            if (count > 0)
                --count;
            TxtAbaddonCount.Text = count.ToString();
        }

        private void BtnAlchemistPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtAlchemistCount.Text);
            if (count < 3)
                ++count;
            TxtAlchemistCount.Text = count.ToString();
        }

        private void BtnAlchemistMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtAlchemistCount.Text);
            if (count > 0)
                --count;
            TxtAlchemistCount.Text = count.ToString();
        }

        private void BtnAntiMagePlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtAntiMageCount.Text);
            if (count < 3)
                ++count;
            TxtAntiMageCount.Text = count.ToString();
        }

        private void BtnAntiMageMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtAntiMageCount.Text);
            if (count > 0)
                --count;
            TxtAntiMageCount.Text = count.ToString();
        }

        private void BtnAxePlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtAxeCount.Text);
            if (count < 3)
                ++count;
            TxtAxeCount.Text = count.ToString();
        }

        private void BtnAxeMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtAxeCount.Text);
            if (count > 0)
                --count;
            TxtAxeCount.Text = count.ToString();
        }

        private void BtnBatriderPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtBatriderCount.Text);
            if (count < 3)
                ++count;
            TxtBatriderCount.Text = count.ToString();
        }

        private void BtnBatriderMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtBatriderCount.Text);
            if (count > 0)
                --count;
            TxtBatriderCount.Text = count.ToString();
        }

        private void BtnBeastmasterPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtBeastmasterCount.Text);
            if (count < 3)
                ++count;
            TxtBeastmasterCount.Text = count.ToString();
        }

        private void BtnBeastmasterMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtBeastmasterCount.Text);
            if (count > 0)
                --count;
            TxtBeastmasterCount.Text = count.ToString();
        }

        private void BtnBountyHunterPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtBountyHunterCount.Text);
            if (count < 3)
                ++count;
            TxtBountyHunterCount.Text = count.ToString();
        }

        private void BtnBountyHunterMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtBountyHunterCount.Text);
            if (count > 0)
                --count;
            TxtBountyHunterCount.Text = count.ToString();
        }

        private void BtnChaosKnightPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtChaosKnightCount.Text);
            if (count < 3)
                ++count;
            TxtChaosKnightCount.Text = count.ToString();
        }

        private void BtnChaosKnightMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtChaosKnightCount.Text);
            if (count > 0)
                --count;
            TxtChaosKnightCount.Text = count.ToString();
        }

        private void BtnClockwerkPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtClockwerkCount.Text);
            if (count < 3)
                ++count;
            TxtClockwerkCount.Text = count.ToString();
        }

        private void BtnClockwerkMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtClockwerkCount.Text);
            if (count > 0)
                --count;
            TxtClockwerkCount.Text = count.ToString();
        }

        private void BtnCrystalMaidenPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtCrystalMaidenCount.Text);
            if (count < 3)
                ++count;
            TxtCrystalMaidenCount.Text = count.ToString();
        }

        private void BtnCrystalMaidenMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtCrystalMaidenCount.Text);
            if (count > 0)
                --count;
            TxtCrystalMaidenCount.Text = count.ToString();
        }

        private void BtnDisruptorPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtDisruptorCount.Text);
            if (count < 3)
                ++count;
            TxtDisruptorCount.Text = count.ToString();
        }

        private void BtnDisruptorMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtDisruptorCount.Text);
            if (count > 0)
                --count;
            TxtDisruptorCount.Text = count.ToString();
        }

        private void BtnDoomPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtDoomCount.Text);
            if (count < 3)
                ++count;
            TxtDoomCount.Text = count.ToString();
        }

        private void BtnDoomMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtDoomCount.Text);
            if (count > 0)
                --count;
            TxtDoomCount.Text = count.ToString();
        }

        private void BtnDragonKnightPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtDragonKnightCount.Text);
            if (count < 3)
                ++count;
            TxtDragonKnightCount.Text = count.ToString();
        }

        private void BtnDragonKnightMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtDragonKnightCount.Text);
            if (count > 0)
                --count;
            TxtDragonKnightCount.Text = count.ToString();
        }

        private void BtnDrowRangerPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtDrowRangerCount.Text);
            if (count < 3)
                ++count;
            TxtDrowRangerCount.Text = count.ToString();
        }

        private void BtnDrowRangerMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtDrowRangerCount.Text);
            if (count > 0)
                --count;
            TxtDrowRangerCount.Text = count.ToString();
        }

        private void BtnEnchantressPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtEnchantressCount.Text);
            if (count < 3)
                ++count;
            TxtEnchantressCount.Text = count.ToString();
        }

        private void BtnEnchantressMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtEnchantressCount.Text);
            if (count > 0)
                --count;
            TxtEnchantressCount.Text = count.ToString();
        }

        private void BtnEnigmaPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtEnigmaCount.Text);
            if (count < 3)
                ++count;
            TxtEnigmaCount.Text = count.ToString();
        }

        private void BtnEnigmaMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtEnigmaCount.Text);
            if (count > 0)
                --count;
            TxtEnigmaCount.Text = count.ToString();
        }

        private void BtnGyrocopterPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtGyrocopterCount.Text);
            if (count < 3)
                ++count;
            TxtGyrocopterCount.Text = count.ToString();
        }

        private void BtnGyrocopterMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtGyrocopterCount.Text);
            if (count > 0)
                --count;
            TxtGyrocopterCount.Text = count.ToString();
        }

        private void BtnJuggernautPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtJuggernautCount.Text);
            if (count < 3)
                ++count;
            TxtJuggernautCount.Text = count.ToString();
        }

        private void BtnJuggernautMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtJuggernautCount.Text);
            if (count > 0)
                --count;
            TxtJuggernautCount.Text = count.ToString();
        }

        private void BtnKeeperoftheLightPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtKeeperoftheLightCount.Text);
            if (count < 3)
                ++count;
            TxtKeeperoftheLightCount.Text = count.ToString();
        }

        private void BtnKeeperoftheLightMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtKeeperoftheLightCount.Text);
            if (count > 0)
                --count;
            TxtKeeperoftheLightCount.Text = count.ToString();
        }

        private void BtnKunkkaPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtKunkkaCount.Text);
            if (count < 3)
                ++count;
            TxtKunkkaCount.Text = count.ToString();
        }

        private void BtnKunkkaMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtKunkkaCount.Text);
            if (count > 0)
                --count;
            TxtKunkkaCount.Text = count.ToString();
        }

        private void BtnLichPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtLichCount.Text);
            if (count < 3)
                ++count;
            TxtLichCount.Text = count.ToString();
        }

        private void BtnLichMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtLichCount.Text);
            if (count > 0)
                --count;
            TxtLichCount.Text = count.ToString();
        }

        private void BtnLinaPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtLinaCount.Text);
            if (count < 3)
                ++count;
            TxtLinaCount.Text = count.ToString();
        }

        private void BtnLinaMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtLinaCount.Text);
            if (count > 0)
                --count;
            TxtLinaCount.Text = count.ToString();
        }

        private void BtnLoneDruidPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtLoneDruidCount.Text);
            if (count < 3)
                ++count;
            TxtLoneDruidCount.Text = count.ToString();
        }

        private void BtnLoneDruidMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtLoneDruidCount.Text);
            if (count > 0)
                --count;
            TxtLoneDruidCount.Text = count.ToString();
        }

        private void BtnLunaPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtLunaCount.Text);
            if (count < 3)
                ++count;
            TxtLunaCount.Text = count.ToString();
        }

        private void BtnLunaMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtLunaCount.Text);
            if (count > 0)
                --count;
            TxtLunaCount.Text = count.ToString();
        }

        private void BtnLycanPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtLycanCount.Text);
            if (count < 3)
                ++count;
            TxtLycanCount.Text = count.ToString();
        }

        private void BtnLycanMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtLycanCount.Text);
            if (count > 0)
                --count;
            TxtLycanCount.Text = count.ToString();
        }

        private void BtnMedusaPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtMedusaCount.Text);
            if (count < 3)
                ++count;
            TxtMedusaCount.Text = count.ToString();
        }

        private void BtnMedusaMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtMedusaCount.Text);
            if (count > 0)
                --count;
            TxtMedusaCount.Text = count.ToString();
        }

        private void BtnMorphlingPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtMorphlingCount.Text);
            if (count < 3)
                ++count;
            TxtMorphlingCount.Text = count.ToString();
        }

        private void BtnMorphlingMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtMorphlingCount.Text);
            if (count > 0)
                --count;
            TxtMorphlingCount.Text = count.ToString();
        }

        private void BtnNaturesProphetPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtNaturesProphetCount.Text);
            if (count < 3)
                ++count;
            TxtNaturesProphetCount.Text = count.ToString();
        }

        private void BtnNaturesProphetMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtNaturesProphetCount.Text);
            if (count > 0)
                --count;
            TxtNaturesProphetCount.Text = count.ToString();
        }

        private void BtnNecrophosPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtNecrophosCount.Text);
            if (count < 3)
                ++count;
            TxtNecrophosCount.Text = count.ToString();
        }

        private void BtnNecrophosMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtNecrophosCount.Text);
            if (count > 0)
                --count;
            TxtNecrophosCount.Text = count.ToString();
        }

        private void BtnOgreMagiPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtOgreMagiCount.Text);
            if (count < 3)
                ++count;
            TxtOgreMagiCount.Text = count.ToString();
        }

        private void BtnOgreMagiMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtOgreMagiCount.Text);
            if (count > 0)
                --count;
            TxtOgreMagiCount.Text = count.ToString();
        }

        private void BtnOmniknightPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtOmniknightCount.Text);
            if (count < 3)
                ++count;
            TxtOmniknightCount.Text = count.ToString();
        }

        private void BtnOmniknightMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtOmniknightCount.Text);
            if (count > 0)
                --count;
            TxtOmniknightCount.Text = count.ToString();
        }

        private void BtnPhantomAssassinPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtPhantomAssassinCount.Text);
            if (count < 3)
                ++count;
            TxtPhantomAssassinCount.Text = count.ToString();
        }

        private void BtnPhantomAssassinMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtPhantomAssassinCount.Text);
            if (count > 0)
                --count;
            TxtPhantomAssassinCount.Text = count.ToString();
        }

        private void BtnPuckPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtPuckCount.Text);
            if (count < 3)
                ++count;
            TxtPuckCount.Text = count.ToString();
        }

        private void BtnPuckMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtPuckCount.Text);
            if (count > 0)
                --count;
            TxtPuckCount.Text = count.ToString();
        }

        private void BtnQueenofPainPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtQueenofPainCount.Text);
            if (count < 3)
                ++count;
            TxtQueenofPainCount.Text = count.ToString();
        }

        private void BtnQueenofPainMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtQueenofPainCount.Text);
            if (count > 0)
                --count;
            TxtQueenofPainCount.Text = count.ToString();
        }

        private void BtnRazorPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtRazorCount.Text);
            if (count < 3)
                ++count;
            TxtRazorCount.Text = count.ToString();
        }

        private void BtnRazorMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtRazorCount.Text);
            if (count > 0)
                --count;
            TxtRazorCount.Text = count.ToString();
        }

        private void BtnSandKingPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtSandKingCount.Text);
            if (count < 3)
                ++count;
            TxtSandKingCount.Text = count.ToString();
        }

        private void BtnSandKingMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtSandKingCount.Text);
            if (count > 0)
                --count;
            TxtSandKingCount.Text = count.ToString();
        }

        private void BtnShadowFiendPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtShadowFiendCount.Text);
            if (count < 3)
                ++count;
            TxtShadowFiendCount.Text = count.ToString();
        }

        private void BtnShadowFiendMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtShadowFiendCount.Text);
            if (count > 0)
                --count;
            TxtShadowFiendCount.Text = count.ToString();
        }

        private void BtnShadowShamanPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtShadowShamanCount.Text);
            if (count < 3)
                ++count;
            TxtShadowShamanCount.Text = count.ToString();
        }

        private void BtnShadowShamanMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtShadowShamanCount.Text);
            if (count > 0)
                --count;
            TxtShadowShamanCount.Text = count.ToString();
        }

        private void BtnSlardarPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtSlardarCount.Text);
            if (count < 3)
                ++count;
            TxtSlardarCount.Text = count.ToString();
        }

        private void BtnSlardarMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtSlardarCount.Text);
            if (count > 0)
                --count;
            TxtSlardarCount.Text = count.ToString();
        }

        private void BtnSlarkPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtSlarkCount.Text);
            if (count < 3)
                ++count;
            TxtSlarkCount.Text = count.ToString();
        }

        private void BtnSlarkMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtSlarkCount.Text);
            if (count > 0)
                --count;
            TxtSlarkCount.Text = count.ToString();
        }

        private void BtnSniperPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtSniperCount.Text);
            if (count < 3)
                ++count;
            TxtSniperCount.Text = count.ToString();
        }

        private void BtnSniperMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtSniperCount.Text);
            if (count > 0)
                --count;
            TxtSniperCount.Text = count.ToString();
        }

        private void BtnTechiesPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTechiesCount.Text);
            if (count < 3)
                ++count;
            TxtTechiesCount.Text = count.ToString();
        }

        private void BtnTechiesMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTechiesCount.Text);
            if (count > 0)
                --count;
            TxtTechiesCount.Text = count.ToString();
        }

        private void BtnTemplarAssassinPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTemplarAssassinCount.Text);
            if (count < 3)
                ++count;
            TxtTemplarAssassinCount.Text = count.ToString();
        }

        private void BtnTemplarAssassinMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTemplarAssassinCount.Text);
            if (count > 0)
                --count;
            TxtTemplarAssassinCount.Text = count.ToString();
        }

        private void BtnTerrorbladePlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTerrorbladeCount.Text);
            if (count < 3)
                ++count;
            TxtTerrorbladeCount.Text = count.ToString();
        }

        private void BtnTerrorbladeMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTerrorbladeCount.Text);
            if (count > 0)
                --count;
            TxtTerrorbladeCount.Text = count.ToString();
        }

        private void BtnTidehunterPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTidehunterCount.Text);
            if (count < 3)
                ++count;
            TxtTidehunterCount.Text = count.ToString();
        }

        private void BtnTidehunterMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTidehunterCount.Text);
            if (count > 0)
                --count;
            TxtTidehunterCount.Text = count.ToString();
        }

        private void BtnTimbersawPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTimbersawCount.Text);
            if (count < 3)
                ++count;
            TxtTimbersawCount.Text = count.ToString();
        }

        private void BtnTimbersawMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTimbersawCount.Text);
            if (count > 0)
                --count;
            TxtTimbersawCount.Text = count.ToString();
        }

        private void BtnTinkerPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTinkerCount.Text);
            if (count < 3)
                ++count;
            TxtTinkerCount.Text = count.ToString();
        }

        private void BtnTinkerMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTinkerCount.Text);
            if (count > 0)
                --count;
            TxtTinkerCount.Text = count.ToString();
        }

        private void BtnTinyPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTinyCount.Text);
            if (count < 3)
                ++count;
            TxtTinyCount.Text = count.ToString();
        }

        private void BtnTinyMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTinyCount.Text);
            if (count > 0)
                --count;
            TxtTinyCount.Text = count.ToString();
        }

        private void BtnTreantProtectorPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTreantProtectorCount.Text);
            if (count < 3)
                ++count;
            TxtTreantProtectorCount.Text = count.ToString();
        }

        private void BtnTreantProtectorMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTreantProtectorCount.Text);
            if (count > 0)
                --count;
            TxtTreantProtectorCount.Text = count.ToString();
        }

        private void BtnTrollWarlordPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTrollWarlordCount.Text);
            if (count < 3)
                ++count;
            TxtTrollWarlordCount.Text = count.ToString();
        }

        private void BtnTrollWarlordMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTrollWarlordCount.Text);
            if (count > 0)
                --count;
            TxtTrollWarlordCount.Text = count.ToString();
        }

        private void BtnTuskPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTuskCount.Text);
            if (count < 3)
                ++count;
            TxtTuskCount.Text = count.ToString();
        }

        private void BtnTuskMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtTuskCount.Text);
            if (count > 0)
                --count;
            TxtTuskCount.Text = count.ToString();
        }

        private void BtnVenomancerPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtVenomancerCount.Text);
            if (count < 3)
                ++count;
            TxtVenomancerCount.Text = count.ToString();
        }

        private void BtnVenomancerMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtVenomancerCount.Text);
            if (count > 0)
                --count;
            TxtVenomancerCount.Text = count.ToString();
        }

        private void BtnViperPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtViperCount.Text);
            if (count < 3)
                ++count;
            TxtViperCount.Text = count.ToString();
        }

        private void BtnViperMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtViperCount.Text);
            if (count > 0)
                --count;
            TxtViperCount.Text = count.ToString();
        }

        private void BtnWindrangerPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtWindrangerCount.Text);
            if (count < 3)
                ++count;
            TxtWindrangerCount.Text = count.ToString();
        }

        private void BtnWindrangerMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtWindrangerCount.Text);
            if (count > 0)
                --count;
            TxtWindrangerCount.Text = count.ToString();
        }

        private void BtnWitchDoctorPlus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtWitchDoctorCount.Text);
            if (count < 3)
                ++count;
            TxtWitchDoctorCount.Text = count.ToString();
        }

        private void BtnWitchDoctorMinus_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(TxtWitchDoctorCount.Text);
            if (count > 0)
                --count;
            TxtWitchDoctorCount.Text = count.ToString();
        }
    }
}
