using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string m_AppDir;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            captureImg();
        }

        private void captureImg()
        {
            string sMsg = "";
            try
            {
                var image = ScreenCapture.CaptureDesktop();
                this.imageDisplay.Image = image;
                if ( true == ScreenCapture.ImageSave( ref sMsg, ImageFormat.Jpeg, image ) )
                  printLog ( "Capture image: " + sMsg );
                else
                  printLog ( "Capture image Failed." + sMsg );
            }
            catch ( Exception err )
            {
                printLog( err.ToString() );
            }
        }

        private void btnAutomatic_Click( object sender, EventArgs e )
        {
            if ( btnAutomatic.Text.Trim() == "Start Automatic Capture" )
            {
                btnAutomatic.Text = "Stop Automatic Capture";
                captureImg();
                tmrCapture.Enabled = true; 
            }
            else
            {
                tmrCapture.Enabled = false;
                btnAutomatic.Text = "Start Automatic Capture";
            }
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            // create folder
            m_AppDir = Directory.GetCurrentDirectory() + @"\Screenshot\";
            if ( !( Directory.Exists( m_AppDir ) ) )
            {
              try
              {
                 Directory.CreateDirectory( m_AppDir );
                 printLog( "Create 'Screenshot' directory." );
              }
              catch
              {
                 btnManual.Enabled = false;
                 btnAutomatic.Enabled = false;
                 printLog( "Failed create 'Screenshot' directory." );                 
              }                
            }
            else
                printLog( "Screenshot directory exist." );
        }

        public void printLog( string sText )
        {
          string ftime;
          
          ftime = DateTime.Now.ToString( "dd-MM-yyyy HH:mm:ss" );
          txtStatus.Text = ftime + " " + sText;
        }

    private void tmrCapture_Tick( object sender, EventArgs e )
    {
      captureImg();
    }
  }
}
