using System;
using System.Windows.Forms;

/*
 * Name: Aaron McArdle
 * 
 * Write a GUI application for a photography business.
 *  - 8 x 10 photos are $3.99
 *  - 10 x 12 photos are $5.99
 *  - All other sizes are $9.99
 *  - Customers can add either a Matte or a Frame.
 *  - Matted photos are an additional $10.
 *  - Framed photos are an additional $25.
 *  - Override the ToString() methods on the Photo, MattedPhoto, and FramedPhoto classes 
 *    so they display all of the information in the fields.
 *    
 */

namespace Ch14_15Photos
{
    public partial class FormPhotoShop : Form
    {
        // Global Constants
        const decimal EIGHTXTEN = 3.99M;
        const decimal TENXTWELVE = 5.99M;
        const decimal OTHERSIZES = 9.99M;
        const decimal UNFRAMED = 0.00M;
        const decimal MATTED = 10.00M;
        const decimal FRAMED = 25.00M;

        // Global variables 
        double width = 0.00;
        double height = 0.00;
        decimal totalCost = 0.00M;
        RadioButton radioButtonFrame;
        RadioButton radioButtonColor;
        RadioButton radioButtonMaterial;
        RadioButton radioButtonStyle;
        string frameStr = "";
        string colorStr = "";
        string materialStr = "";
        string styleStr = "";

        public FormPhotoShop()
        {
            InitializeComponent();

            // Set up framed groupBox radioButtons
            radioButtonUnframed.CheckedChanged += new EventHandler(framed_Check_Changed);
            radioButtonMatted.CheckedChanged += new EventHandler(framed_Check_Changed);
            radioButtonFramed.CheckedChanged += new EventHandler(framed_Check_Changed);

            // Set up color groupBox radioButtons
            radioButtonBlack.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonRed.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonGreen.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonBlue.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonWhite.CheckedChanged += new EventHandler(color_Check_Changed);

            // Set up material groupBox radioButtons
            radioButtonPine.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonOak.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonSteel.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonSilver.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonGold.CheckedChanged += new EventHandler(material_Check_Changed);

            // Set up style groupBox radioButtons
            radioButtonSimple.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonModern.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonAntique.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonVintage.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonEclectic.CheckedChanged += new EventHandler(style_Check_Changed);
        }

        private void framed_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonFrame = (RadioButton)sender;

                frameStr = radioButtonFrame.Name.Substring(11);

                switch (frameStr)
                {
                    case "Unframed":
                        groupBoxColor.Enabled = false;
                        groupBoxMaterial.Enabled = false;
                        groupBoxStyle.Enabled = false;
                        break;

                    case "Matted":
                        groupBoxColor.Enabled = true;
                        radioButtonBlack.Checked = true;
                        groupBoxMaterial.Enabled = false;
                        groupBoxStyle.Enabled = false;
                        break;

                    case "Framed":
                        groupBoxColor.Enabled = false;
                        groupBoxMaterial.Enabled = true;
                        radioButtonPine.Enabled = true;
                        groupBoxStyle.Enabled = true;
                        radioButtonSimple.Enabled = true;
                        break;

                    default:
                        groupBoxColor.Enabled = false;
                        groupBoxMaterial.Enabled = false;
                        groupBoxStyle.Enabled = false;
                        break;
                }
            }
        }

        private void color_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonColor = (RadioButton)sender;
                colorStr = radioButtonColor.Name.Substring(11);
            }
        }

        private void material_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonMaterial = (RadioButton)sender;
                materialStr = radioButtonMaterial.Name.Substring(11);
            }
        }

        private void style_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonStyle = (RadioButton)sender;
                styleStr = radioButtonStyle.Name.Substring(11);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateWidth();

            if (keepGoing)
            {
                keepGoing = ValidateHeight();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateCost();
            }
            else
            {
                return;
            }
        }
        private bool ValidateWidth()
        {
            try
            {
                width = Convert.ToDouble(txtWidth.Text);
                return true;
            }
            catch (FormatException fe)
            {
                WriteMessage("Width Inputted Was Not Numeric.", "ILLEGAL WIDTH INPUTTED!!!");
                txtWidth.Text = "";
                txtWidth.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException oore)
            {
                WriteMessage("Width Inputted Was <= 0", "NON-POSITIVE WIDTH INPUTTED!!!");
                txtWidth.Text = "";
                txtWidth.Focus();
                return false;
            }
        }

        private bool ValidateHeight()
        {
            try
            {
                height = Convert.ToDouble(txtHeight.Text);

                if (height <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }
            catch (FormatException fe)
            {
                WriteMessage("Height Inputted Was Not Numeric.", "ILLEGAL HEIGHT INPUTTED!!!");
                txtHeight.Text = "";
                txtHeight.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException oore)
            {
                WriteMessage("Height Inputted Was <= 0", "NON-POSITIVE HEIGHT INPUTTED!!!");
                txtHeight.Text = "";
                txtHeight.Focus();
                return false;
            }
        }

        private void CalculateCost()
        {
            decimal areaCost = CalculateAreaCost();
            decimal frameCost = CalculateFrameCost();
            totalCost = areaCost + frameCost;

            lblCostResult.Text = totalCost.ToString("c");
        }

        private decimal CalculateAreaCost()
        {
            double area = width * height;
            decimal ac = 0.00M;

            switch (area)
            {
                case 80.0:
                    ac = EIGHTXTEN;
                    break;

                case 120.0:
                    ac = TENXTWELVE;
                    break;

                default:
                    ac = OTHERSIZES;
                    break;
            }

            return ac;
        }

        private decimal CalculateFrameCost()
        {
            decimal fc = 0.0M;

            switch (radioButtonFrame.Name.Substring(11))
            {
                case "Unframed":
                    fc = UNFRAMED;
                    Photo p = new Photo(width, height);
                    lblResults.Text = p.ToString();
                    break;

                case "Matted":
                    fc = MATTED;
                    MattedPhoto.Color colorEnum = (MattedPhoto.Color)Enum.Parse(typeof(MattedPhoto.Color), radioButtonColor.Text.ToUpper());
                    MattedPhoto mp = new MattedPhoto(width, height, colorEnum);
                    lblResults.Text = mp.ToString();
                    break;

                case "Framed":
                    fc = FRAMED;
                    FramedPhoto.Material materialEnum = (FramedPhoto.Material)Enum.Parse(typeof(FramedPhoto.Material), radioButtonMaterial.Text.ToUpper());
                    FramedPhoto.Style styleEnum = (FramedPhoto.Style)Enum.Parse(typeof(FramedPhoto.Style), radioButtonStyle.Text.ToUpper());
                    FramedPhoto fp = new FramedPhoto(width, height, materialEnum, styleEnum);
                    lblResults.Text = fp.ToString();
                    break;

                default:
                    break;
            }

            return fc;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            width = 0.0;
            height = 0.0;
            txtWidth.Text = "";
            txtHeight.Text = "";
            radioButtonUnframed.Checked = true;
            radioButtonBlack.Checked = true;
            radioButtonPine.Checked = true;
            radioButtonSimple.Checked = true;
            lblCostResult.Text = "";
            lblResults.Text = "";
            txtWidth.Focus();
        }

        private void WriteMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
