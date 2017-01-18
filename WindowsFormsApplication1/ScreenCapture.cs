using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsFormsApplication1
{
    public class ScreenCapture
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport( "user32.dll", CharSet = CharSet.Auto, ExactSpelling = true )]
        public static extern IntPtr GetDesktopWindow();

        [StructLayout( LayoutKind.Sequential )]
        private struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect( IntPtr hWnd, ref Rect rect );

        public static Image CaptureDesktop()
        {
            return CaptureWindow( GetDesktopWindow() );
        }

        public static Bitmap CaptureActiveWindow()
        {
            return CaptureWindow( GetForegroundWindow() );
        }

        public static Bitmap CaptureWindow( IntPtr handle )
        {
            var rect = new Rect();
            GetWindowRect( handle, ref rect );
            var bounds = new Rectangle( rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top );
            var result = new Bitmap( bounds.Width, bounds.Height );

            using ( var graphics = Graphics.FromImage( result ) )
            {
                graphics.CopyFromScreen( new Point( bounds.Left, bounds.Top ), Point.Empty, bounds.Size );
            }

            return result;
        }

        public static bool ImageSave( ref string Err, ImageFormat format, Image image )
        {
            string fdate, ftime, fname, sdname;

            format    = format ?? ImageFormat.Png;
            fdate     = DateTime.Now.ToString( "yyyy-MM-dd" );
            ftime     = DateTime.Now.ToString( "HH.mm.ss" );    
            sdname    = Directory.GetCurrentDirectory() + @"\Screenshot\" + fdate + @"\";
            fname     = fdate + " " + ftime + ".jpg";

            if ( !(Directory.Exists( sdname ) ) )
            {
              Directory.CreateDirectory( sdname );
            }

            try 
            {
              image.Save( sdname + fname, format );
              Err = fname;
              return true;
            }
            catch ( Exception ex )
            {
              Err = ex.ToString();
              return false;
            }     
        } // close last function         

    } // close class
} // close namespace
