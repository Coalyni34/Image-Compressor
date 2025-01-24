
namespace ImageCompressor
{
    public partial class ImageCompressorForm : Form
    {
        Image Source;
        public ImageCompressorForm()
        {
            InitializeComponent();
            TrackBar[] trackBars = [RforegroundTrackBar, GforegroundTrackBar, BforegroundTrackBar, RbackgroundTrackBar, GbackgroundTrackBar, BbackgroundTrackBar,];
            Label[] trackLabels = [rfore_count, gfore_count, bfore_count, rback_count, gback_count, bback_count];
            for (short i = 0; i < trackBars.Length; i++)
            {
                trackLabels[i].Text = trackBars[i].Value.ToString();
                trackBars[i].Scroll += ChangingValue;
            }
        }
        public void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                Address.Text = Path.GetFileName(ofd.FileName);
                Source = Image.FromFile(ofd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            try
            {
                ImageManager imageManager = new ImageManager();
                Image newImage = imageManager.ConvertDataToImage(imageManager.ConvertImageToData(Source,
                    Convert.ToInt16(rBrigTextBox.Text),
                    Convert.ToInt16(gBrigTextBox.Text),
                    Convert.ToInt16(bBrigTextbox.Text)),
                    ForeGroundTestColor.BackColor,
                    BackGroundTestColor.BackColor);
                if (Finalart.BackgroundImage != newImage) 
                {
                    while (progressBar.Value != 10)
                    {
                        progressBar.Value++;
                    }
                    Finalart.BackgroundImage = newImage;
                }        
                else
                {
                    progressBar.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ChangingValue(object sender, EventArgs e)
        {
            try
            {
                TrackBar[] trackBars = [RforegroundTrackBar, GforegroundTrackBar, BforegroundTrackBar, RbackgroundTrackBar, GbackgroundTrackBar, BbackgroundTrackBar,];
                Label[] trackLabels = [rfore_count, gfore_count, bfore_count, rback_count, gback_count, bback_count];
                for (short i = 0; i < trackBars.Length; i++)
                {
                    trackLabels[i].Text = trackBars[i].Value.ToString();
                }

                ForegroundColorTextBox.Text = $"{trackBars[0].Value}, {trackBars[1].Value}, {trackBars[2].Value}";
                BackgroundColorTextBox.Text = $"{trackBars[3].Value}, {trackBars[4].Value}, {trackBars[5].Value}";

                ForeGroundTestColor.BackColor = Color.FromArgb(trackBars[0].Value, trackBars[1].Value, trackBars[2].Value);
                BackGroundTestColor.BackColor = Color.FromArgb(trackBars[3].Value, trackBars[4].Value, trackBars[5].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "*Image files | (*jpg, *png, *gif, *bmp, *tif";
                saveFileDialog.Title = "Saving image";
                saveFileDialog.FileName = $"{Path.GetFileNameWithoutExtension(Address.Text)}_compressed.png";
                saveFileDialog.ShowDialog();
                Finalart.BackgroundImage.Save(saveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                Finalart.BackgroundImage = null;    
                progressBar.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }        
    }
}
