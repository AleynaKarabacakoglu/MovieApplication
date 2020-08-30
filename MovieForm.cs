using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class MovieForm : Form
    {
        
        public MovieForm()
        {
            InitializeComponent();
        }

        Movie movie = new Movie();
        Cast cast = new Cast();
        List<Movie> movies = new List<Movie>();
        List<Cast> casts = new List<Cast>();
        List<Cast> stars = new List<Cast>();
        List<Cast> writers = new List<Cast>();
        List<Cast> directors = new List<Cast>();
        List<Movie> description = new List<Movie>();
        
        
        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {

            
          //lstDescription.Visible = true;
          //lstCast.Visible = true;
          pictureBoxMovie.Visible = true;          
          lstStars.Visible = true;
          lstDirector.Visible = true;
          lstWriter.Visible = true;
          lblDirectors.Visible = true;
          lblStars.Visible = true;
          lblWriters.Visible = true;
          listBox1.Items.Clear();
          lstDirector.Items.Clear();
          lstCast.Items.Clear();
          casts.Clear();
          writers.Clear();
          stars.Clear();
          directors.Clear();
               
          WebClient wc = new WebClient();
         

          string result = wc.DownloadString("https://www.imdb.com/" + movies[lstMovies.SelectedIndex].ImdbId);
          string resultImage = result;
                
         ///////   Descripton   //////////
         string descriptionResult = result;
         string descriptionKey = "<div class=\"summary_text\">";
         string ImageKey= "<div class=\"poster\">";
         int ImageStartIndex = resultImage.IndexOf(ImageKey);
         int ImageEndIndex= resultImage.IndexOf("</div>", ImageStartIndex);
         resultImage = resultImage.Substring(ImageStartIndex, ImageEndIndex - ImageStartIndex);
         int srcIndex = resultImage.IndexOf("src=")+5;
         int endSrcIndex = resultImage.IndexOf(">", srcIndex);
         resultImage = resultImage.Substring(srcIndex, (endSrcIndex - srcIndex)-2);
         //MessageBox.Show(resultImage);
         pictureBoxMovie.ImageLocation = resultImage;
         int startDescription = result.IndexOf(descriptionKey)+descriptionKey.Length;              
         int endDescription = result.IndexOf("</div>", startDescription);
         descriptionResult = result.Substring(startDescription, endDescription - startDescription);
         movie.Description = descriptionResult;
         string name;
         string directorResult = result;
              
         /////////////////  Director  ////////////////////////
         string directorKey = "<div class=\"credit_summary_item\">";
         int directorStartIndex = directorResult.IndexOf(directorKey);
         int directorEndIndex = directorResult.IndexOf("v>", directorStartIndex);
         directorResult = directorResult.Substring(directorStartIndex, directorEndIndex - directorStartIndex);
         string tempresult = directorResult;
         int uzunluk = tempresult.Length;
         int yeniuzunluk = tempresult.Replace("),", null).Length;
         int sonuc = (uzunluk - yeniuzunluk) / 2;
         string endkey1 ="</h4>" ;
         int atEnd = tempresult.IndexOf(endkey1);
         int newStart= atEnd+endkey1.Length;
         int endofIndex = tempresult.IndexOf("</di");
         directorResult = tempresult.Substring(newStart,endofIndex-newStart);
         directorStartIndex = 0;
         directorEndIndex = 0;
         int i = 0;
         lstDirector.Items.Clear();
         while (i<=sonuc)
         {
                i++;
                Cast director = new Cast();
                string directorKey2 = "<a href=";
                directorStartIndex = directorResult.IndexOf(directorKey2) + directorKey2.Length;
                string endKey = ">";
                directorEndIndex = directorResult.IndexOf(endKey, directorStartIndex);               
                director.ImdbId = directorResult.Substring(directorStartIndex, directorEndIndex - directorStartIndex);
                directorStartIndex = directorEndIndex + endKey.Length;
                string newEndKey = "</"; //</a>                   
                directorEndIndex = directorResult.IndexOf(newEndKey, directorStartIndex);
                string tempdirectorResult = directorResult.Substring(directorStartIndex, directorEndIndex - directorStartIndex);
                directorStartIndex = directorEndIndex + newEndKey.Length;
                directors.Add(director);
                lstDirector.Items.Add(tempdirectorResult);
                directorResult = directorResult.Remove(0, directorStartIndex);
                listBox1.Items.Add(director.ImdbId);

            }

        /////////////////////WRITER///////////////////////////////////
        string writerResult = result;
        string writerKey = "<div class=\"credit_summary_item\">";
        String deleteKey = "</div>";
        int deleteStartIndex = writerResult.IndexOf(writerKey);
        int deleteEndIndex = writerResult.IndexOf(deleteKey, deleteStartIndex);
        int deletecounter = deleteEndIndex + deleteKey.Length;
        String deleteresult = writerResult.Substring(deleteStartIndex, deleteEndIndex - deleteStartIndex);
        int writerStartIndex = deletecounter; //writerResult.IndexOf(writerKey);
        int writerEndIndex = writerResult.IndexOf("v>", writerStartIndex);
        writerResult = writerResult.Substring(writerStartIndex, writerEndIndex - writerStartIndex);
        string writertempresult = writerResult;
        int length = writertempresult.Length;
        int newlength = writertempresult.Replace("),", null).Length;
        int response = (length - newlength) / 2;
        string endkeywriter = "</h4>";
        int atEndwriter = writertempresult.IndexOf(endkeywriter);
        int newWriterStart = atEndwriter + endkeywriter.Length;
        int writerendofIndex = writertempresult.IndexOf("</di");
        writerResult = writertempresult.Substring(newWriterStart, writerendofIndex - newWriterStart);
        writerStartIndex = 0;
        writerEndIndex = 0;
        int j = 0;
        while(j <= response)
        {
                j++;
                Cast writer = new Cast();


                string writerKey2 = "<a href=";
                writerStartIndex = writerResult.IndexOf(writerKey2) + writerKey2.Length;

                string endKeyWriter = ">";
                writerEndIndex = writerResult.IndexOf(endKeyWriter, writerStartIndex);
                //link atıldı
                writer.ImdbId = writerResult.Substring(writerStartIndex, writerEndIndex - writerStartIndex);

                writerStartIndex = writerEndIndex + endKeyWriter.Length;

                string newwriterEndKey = "</";

                writerEndIndex = writerResult.IndexOf(newwriterEndKey, writerStartIndex);
                string tempwriterResult = writerResult.Substring(writerStartIndex, writerEndIndex - writerStartIndex);
                writerStartIndex = writerEndIndex + newwriterEndKey.Length;
                writer.Name = tempwriterResult;

                writers.Add(writer);
                lstWriter.Items.Add(writer.Name);
                writerResult = writerResult.Remove(0, writerStartIndex);
                //lstWriter.Items.Add(writer.ImdbId);                    

            }
            //////////////    STARS   //////////
        string starsResult = result;
        string starsKey = "<div class=\"credit_summary_item\">";
        string deleteStarsKey = "</div>";
        int starsDeleteStartIndex = starsResult.IndexOf(starsKey);
        int starsDeleteEndIndex = starsResult.IndexOf(deleteStarsKey, starsDeleteStartIndex);
        int starsDeletecounter = starsDeleteEndIndex + deleteStarsKey.Length;
        string deleteStarsResult = starsResult.Substring(starsDeleteStartIndex, starsDeleteEndIndex - starsDeleteStartIndex);
        starsDeleteStartIndex = starsResult.IndexOf(starsKey, starsDeletecounter);
        starsDeleteEndIndex = starsResult.IndexOf(deleteStarsKey, starsDeletecounter)+deleteStarsKey.Length;
        int StarsStartIndex = starsDeleteEndIndex; //writerResult.IndexOf(writerKey);
        int StarsEndIndex = starsResult.IndexOf("v>", StarsStartIndex);
        starsResult = starsResult.Substring(StarsStartIndex, StarsEndIndex - StarsStartIndex);
        string starstempresult = starsResult;
        int length2 = starstempresult.Length;
        int newlength2 = starstempresult.Replace(",", null).Length;
        int respons2 = (length2 - newlength2) / 2;
        string endkeyStars = "</h4>";
        int atEndStars= starstempresult.IndexOf(endkeyStars);
        int newStarsStart = atEndStars + endkeyStars.Length;
        int StarsEndofIndex = starstempresult.IndexOf("</di");
        starsResult = starstempresult.Substring(newStarsStart, StarsEndofIndex - newStarsStart);
        StarsStartIndex = 0;
        StarsEndIndex = 0;
        int k = 0;
        while(k <= respons2+1)
        {
             k++;
             Cast star = new Cast();
             string StarsKey2 = "<a href=";
             StarsStartIndex = starsResult.IndexOf(StarsKey2) + StarsKey2.Length;
             string endKeyStars = ">";
             StarsEndIndex = starsResult.IndexOf(endKeyStars, StarsStartIndex);
             star.ImdbId = starsResult.Substring(StarsStartIndex, StarsEndIndex - StarsStartIndex);
             StarsStartIndex = StarsEndIndex + endKeyStars.Length;
             string newwriterEndKey = "</";
             StarsEndIndex = starsResult.IndexOf(newwriterEndKey, StarsStartIndex);
             string tempStarsResult = starsResult.Substring(StarsStartIndex, StarsEndIndex - StarsStartIndex);
             StarsStartIndex = StarsEndIndex + newwriterEndKey.Length;
             star.Name = tempStarsResult;
             stars.Add(star);
             lstStars.Items.Add(star.Name);
             starsResult = starsResult.Remove(0, StarsStartIndex);

            }
       //////////////  CAST       //////////////////////////////////////////
        string CastKey = " <div class=\"article\" id=\"titleCast\">";
        int CastStartIndex = result.IndexOf(CastKey);
        int endIndex = result.IndexOf("<script>", CastStartIndex);
        string castResultName = result.Substring(CastStartIndex, endIndex - CastStartIndex);
        string nameCastKey = "alt=\"";
        string tempResult = castResultName;
        while (true)
        {
             CastStartIndex = tempResult.IndexOf(nameCastKey) + nameCastKey.Length;
             endIndex = tempResult.IndexOf("\"", CastStartIndex + 1);
             if (CastStartIndex - nameCastKey.Length < 0) break;
             name = tempResult.Substring(CastStartIndex, endIndex - CastStartIndex);
             Cast cast = new Cast() { Name = name };
             lstCast.Items.Add(cast);
             casts.Add(cast);
             //MessageBox.Show(name);
             tempResult = tempResult.Remove(0, CastStartIndex);

        }
            
    }
        /*
        public string parseHtml(string result, string url, string startKey, string endKey)
          {
            WebClient wc = new WebClient();
            result = wc.DownloadString(url + txtMovieName.Text.Trim());
            int startIndex = result.IndexOf(startKey);
            int endIndex = result.IndexOf(endKey, startIndex);
            result = result.Substring(startIndex, endIndex - startIndex);
            return result;
          }
        */
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            lstMovies.Items.Clear();
            stars.Clear();
            movies.Clear();
            casts.Clear();
            writers.Clear();
            directors.Clear();
            lstDirector.Items.Clear();
            lstCast.Items.Clear();
            lstStars.Items.Clear();
            lstWriter.Items.Clear();
            listBox1.Items.Clear();
            lblMovie.Visible = true;
            lstMovies.Visible = true;
            
            
            
            WebClient wc = new WebClient();
            string result = wc.DownloadString("https://www.imdb.com/find?q=" + txtMovieName.Text.Trim());

            string firstKey = "<table class=\"findList\">";
            int startIndex = result.IndexOf(firstKey);
            int endIndex = result.IndexOf("</table>", startIndex);

            result = result.Substring(startIndex, endIndex - startIndex);

            firstKey = "<td class=\"result_text\"> <a href=\"/";
            startIndex = 0;
            endIndex = 0;
          

            while (true)
            {
                Movie movie = new Movie();
                startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;

                if (startIndex - firstKey.Length < 0) break;

                string endKey = "\" >";
                endIndex = result.IndexOf(endKey, startIndex);

                movie.ImdbId = result.Substring(startIndex, endIndex - startIndex);
                //MessageBox.Show(movie.ImdbId);
                startIndex = endIndex + endKey.Length;
                endKey = "</a>";

                endIndex = result.IndexOf(endKey, startIndex);
                movie.Name = result.Substring(startIndex, endIndex - startIndex);

                movies.Add(movie);
                lstMovies.Items.Add(movie);              
            }
            Console.WriteLine(result);
        }

        private void lstDirector_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionForm frm2 = new DescriptionForm();
            frm2.IMdbId = directors[lstDirector.SelectedIndex].ImdbId;
            frm2.Show();
            
        }

        private void lstWriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionForm frm2 = new DescriptionForm();
            frm2.IMdbId = writers[lstWriter.SelectedIndex].ImdbId;
            frm2.Show();
            

        }


        private void lstStars_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionForm frm2 = new DescriptionForm();
            frm2.IMdbId = stars[lstStars.SelectedIndex].ImdbId;
            frm2.Show();
        }

        
    }
}
