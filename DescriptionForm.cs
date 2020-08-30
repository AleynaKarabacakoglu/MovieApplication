using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class DescriptionForm : Form
    {
        public string IMdbId;
       
        public DescriptionForm()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
            WebClient wc = new WebClient();
            string key = IMdbId.Trim();
            key = key.Substring(1, key.Length - 2);
           
            string result = wc.DownloadString("https://www.imdb.com"+key);
            string photoResult = result;
           // MessageBox.Show(IMdbId);

            string photoStartKey = "<div class=\"poster-hero-container\">";
            int photoStartIndex = photoResult.IndexOf(photoStartKey);
            int photoEndIndex = photoResult.IndexOf("</a>", photoStartIndex);
            photoResult = photoResult.Substring(photoStartIndex, photoEndIndex - photoStartIndex);
            string srcKey = "src=";
            int srcStartIndex = photoResult.IndexOf(srcKey) + srcKey.Length;
            int srcEndIndex = photoResult.IndexOf("/>", srcStartIndex);
            photoResult = photoResult.Substring(srcStartIndex, srcEndIndex - srcStartIndex);
            photoResult = photoResult.Substring(1, photoResult.Length - 2);       
            pictureBoxCast.ImageLocation = photoResult;
            /////////////////////////////////////7
            ///
            string bioResult = result;
            string bioStartKey = "<div class=\"inline\">";
            int bioStartIndex = bioResult.IndexOf(bioStartKey)+bioStartKey.Length;
            int bioEndIndex = bioResult.IndexOf("<", bioStartIndex);
            bioResult = bioResult.Substring(bioStartIndex, bioEndIndex - bioStartIndex);
            txtBio.Text = bioResult+"...";
            ////////////
            ///
            string nameResult = result;
            string  nameStartKey= "<h1 class=\"header\"> <span class=\"itemprop\">";
            int nameStartIndex = nameResult.IndexOf(nameStartKey) + nameStartKey.Length;
            int nameEndIndex = nameResult.IndexOf("</span>", nameStartIndex);
            nameResult = nameResult.Substring(nameStartIndex, nameEndIndex - nameStartIndex);
            lblName.Text = nameResult;

        }
    }
}
