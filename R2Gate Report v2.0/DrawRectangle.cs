using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Automation;
using System.Diagnostics;

namespace R2Gate_Report_v2._0
{
    public partial class DrawRectangle : Form
    {
      
        private Boolean isDrawingRectangle;
        
        private int X_begin;  // - - - - ->coordonates for point where drawing starts
        private int Y_begin;  // - - - /     

        private int X_current; // - - - - ->coordonates for point where cursor is now
        private int Y_current; // - - - / 

        private int widthRectangle;     
        private int heightRectangle;   // calculating in real time these values   
        private int TopLeftCorner_X;
        private int TopLeftCorner_Y;
        
        private static double ratioWidthHeight; // if we want to draw an on-rectangle keeping one ratio
                                                  // -> this is our static field 
        private SmallRectangleDialog smallRectangleDialog;
        public static Graphics graphics;
        private Image okButton;
        private Boolean okButtonRightPressed;
        private Pen redPen = new Pen(Color.Blue, 2);
        
        // Setter :
        public static void setRatioWidthHeight(double newRatio)
        {
            DrawRectangle.ratioWidthHeight = newRatio;
        }

        public DrawRectangle()
        {
            InitializeComponent();
           
            DrawRectangle.ratioWidthHeight = -1; // IF -1 => draw normally , without ratio
            this.ShowInTaskbar = false;
            this.BackgroundImage = Image.FromFile(@"In App - Images\Transparent Background - DrawRectagle.png"); ;
            this.okButton = Image.FromFile(@"In App - Images\OK1.jpg");
            this.isDrawingRectangle = false;
            this.okButtonRightPressed = false;
            graphics = this.CreateGraphics();
            smallRectangleDialog = new SmallRectangleDialog();
        }
        
        private void DrawRectangle_Load(object sender, EventArgs e)
        {
          
        }
    
        private void Draw_Tick(object sender, EventArgs e)
        {
            this.X_current= System.Windows.Forms.Cursor.Position.X;
            this.Y_current= System.Windows.Forms.Cursor.Position.Y;
            
            // this TimerTick simulate drawing an onScreen-Rectangle in real time
            // to draw on screen use Key ALT + MouseMove, and realease ALT when you're done
            
            if (Control.ModifierKeys == Keys.Alt)       // Key ALT is pressed (ALT-move & ALT-down)
            {                                           //   (you drawing in real time)
                
                if (isDrawingRectangle)
                {
                    
                    this.drawOnScreenRectangle(PacientData.getRatio());
                    #region wait time before Clear screen
                    Image img = Image.FromFile(@"In App - Images\Transparent Background - DrawRectagle.png");
                    //img = Image.FromFile(@"In App - Images\Transparent Background - DrawRectagle.png");
                    #endregion
                    graphics.Clear(Color.White);
                    
                    
                    
                    
                    this.TopMost = true;
                }
                else
                {
                    smallRectangleDialog.Close();    
                    this.isDrawingRectangle = true;
                    this.X_begin = this.X_current;
                    this.Y_begin = this.Y_current;
                
                }
            }
            else if (Control.ModifierKeys != Keys.Alt && isDrawingRectangle)
            {                                                // Key ALT is UP (you finish drawing rectangle) 
                this.isDrawingRectangle = false;
                this.finalizeOnScreenRectangle();         
            }
       
            else if (Control.MouseButtons == MouseButtons.Right)
            {                                               
                X_begin = MousePosition.X - this.widthRectangle + 7;
                Y_begin = MousePosition.Y - this.heightRectangle + 7;
                TopLeftCorner_X = X_begin;
                TopLeftCorner_Y = Y_begin;
                if (okButtonRightPressed)
                {
                    this.moveOnScreenRectangle();
                }
            }
       
        }

        private void finalizeOnScreenRectangle()
        {
            if (Math.Abs(X_begin - X_current) > 35 && Math.Abs(Y_begin - Y_current) > 35)
            {                                                // 35px must be the minimum dimension of an Image.
                this.drawOnScreenRectangle(PacientData.getRatio());
                this.drawOkButton(); // draw OK/ACCEPT BUTTON IN BOTTOM-RIGHT OF BIG-RECTANGLE:     
            }
            else
            {
                MessageBox.Show("Please make a larger selection!");
            }
        }
        private void moveOnScreenRectangle()
        {

            for (int i = 0; i < 35; i++) // 
            {
                graphics.DrawRectangle(redPen,X_begin , Y_begin, widthRectangle, heightRectangle);
            }
            #region wait time before Clear screen
            Image img = Image.FromFile(@"In App - Images\Transparent Background - DrawRectagle.png");
            //img = Image.FromFile(@"In App - Images\Transparent Background - DrawRectagle.png");
            #endregion
            graphics.Clear(Color.White);
            this.TopMost = true;

        }
        private void drawOnScreenRectangle()
        {
            TopLeftCorner_X = Math.Min(X_begin, X_current);
            TopLeftCorner_Y = Math.Min(Y_begin, Y_current);
            widthRectangle = Math.Abs(X_current - X_begin);
            heightRectangle = Math.Abs(Y_current - Y_begin);

            for (int i = 0; i < 35; i++) // 
            {
                graphics.DrawRectangle(redPen, TopLeftCorner_X, TopLeftCorner_Y, widthRectangle, heightRectangle);
            }
        }
        private void drawOnScreenRectangle(double ratioWidthHeight)
        {
            //draw onscreen-rectangle normally ( with NO ratio between width and height )
            if (ratioWidthHeight == -1)
            {
                this.drawOnScreenRectangle();
                return;
            }
            
            // initial dimensions without ratio:
            widthRectangle  = Math.Abs(X_current - X_begin);
            heightRectangle = Math.Abs(Y_current - Y_begin);
            
            // let's calculate new rectangle's dimensions with ratio integrated!! - myAlgorithm 
            if((double)widthRectangle / (double)heightRectangle < ratioWidthHeight)
            {
                heightRectangle = (int)((double)widthRectangle  / ratioWidthHeight);
            }
            else if ((double)widthRectangle /(double) heightRectangle >= ratioWidthHeight)
            {
                widthRectangle = (int)((double)heightRectangle  * ratioWidthHeight);
            }
            
            // recalculating "X_ and Y_current" ... for drawing in time with ratio !! 
            if (X_current > X_begin)
            {
                X_current = X_begin + widthRectangle;
            }
            else
            {
                X_current = X_begin - widthRectangle;
            }
            if (Y_current > Y_begin)
            {
                Y_current = Y_begin + heightRectangle;
            }
            else
            {
                Y_current = Y_begin - heightRectangle;
            }

            //Now we have all we need to draw a rectangle with a chosen 'ratio' (like in Photoshop)
            this.drawOnScreenRectangle();
            
        }
        private void drawOkButton()
        {
            X_begin = Math.Max(X_begin, X_current); // 
            Y_begin = Math.Max(Y_begin, Y_current); // x_begin and y_begin for OK/ACCEPT button
            graphics.DrawRectangle(this.redPen, X_begin, Y_begin, okButton.Width + 2, okButton.Height + 2);
            graphics.DrawImage(okButton, X_begin + 1, Y_begin + 1);

        }
        private void drawOkButton(int pixels)
        {
            X_begin = Math.Max(X_begin, X_current); // 
            Y_begin = Math.Max(Y_begin, Y_current); // x_begin and y_begin for OK/ACCEPT button
            graphics.DrawRectangle(this.redPen, X_begin + pixels, Y_begin + pixels, okButton.Width + 2, okButton.Height + 2 );
            graphics.DrawImage(okButton, X_begin + 1 + pixels, Y_begin + 1 + pixels);

        }
        private void acceptImage()
        {
            Bitmap screenImage = new Bitmap(this.widthRectangle - 2, this.heightRectangle - 2);
            Graphics screenGraphics = Graphics.FromImage(screenImage as Image);
            //TopLeftCorner_X = Math.Min(X_begin, X_current);
            //TopLeftCorner_Y = Math.Min(Y_begin, Y_current);
            screenGraphics.CopyFromScreen(TopLeftCorner_X + 1, TopLeftCorner_Y + 1, 0, 0, screenImage.Size);
            Image img = screenImage;
            PacientDataForm.guideForm.addImage(img);
        }
        private void DrawRectangle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                acceptImage();
                graphics.Clear(Color.White);
            }
            if (okButtonRightPressed)
            {
                graphics.DrawRectangle(redPen, X_begin, Y_begin, widthRectangle, heightRectangle);
                this.drawOkButton(7);
            }
            okButtonRightPressed = false;
            
        }
        private void DrawRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Right)
            {
                this.okButtonRightPressed = true;
            }
            
        }

       
        
      
    }

}
