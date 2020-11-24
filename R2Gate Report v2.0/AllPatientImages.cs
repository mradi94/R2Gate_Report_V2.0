using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace R2Gate_Report_v2._0
{
    class AllPatientImages
    {
        private static List<GroupImages> allImages ;
        private static GroupImages currentGroupImages;
        private static int indexImage;
        
        //Getter & Setter:

        public static int getIndexImage()
        {
            return indexImage;
        }
        public static int getGroupIndex()
        {
            return allImages.Count -1;
        }
        public static int getGroupComponentIndex()
        {
            return currentGroupImages.getIndex();
        }
        public static List<List<Image>> getAllImages()
        {
            List<List<Image>> allImages = new List<List<Image>>();
            for (int i = 0; i < AllPatientImages.allImages.Count; i++)
            {
                allImages.Add(AllPatientImages.allImages[i].getImages());
            }
            return allImages;
        }
        public static void save()
        {
            List<List<Image>> allImages = getAllImages();
            for (int i = 0; i < allImages.Count; i++)
            {
                for (int j = 0; j < allImages[i].Count; j++)
                {
                    allImages[i][j].Save(@"C:\Users\Adi\Desktop\ImaginiPacient\" + (i+1) + "-" + (j+1) + ".jpg");
                }
            }
        }


        public static void setGroupMaximImages(int maximImages)
        {
            if(currentGroupImages!= null)
            currentGroupImages.setMaximImages(maximImages);
        }

        //Constructor:

        public AllPatientImages()
        {
            indexImage = 0;
            allImages = new List<GroupImages>();
            allImages.Add(new GroupImages());
            currentGroupImages = allImages[allImages.Count - 1];
        }
        private static Image resizeByParameter(Image img, int newWidth)
        {
            int oldWidth = img.Width;
            float report = (float)newWidth / (float)oldWidth;
            
            return ResizeNow(img, report);
        }
        public static Bitmap ResizeNow(Image imagine, float m)
        {
            int lungime = imagine.Height;
            float latime = imagine.Width;

            int l, L;
            L = Convert.ToInt32((float)latime * m);
            l = Convert.ToInt32((float)lungime * m);

            Rectangle dest_rect = new Rectangle(0, 0, L, l);
            Bitmap destImage = new Bitmap(L, l);

            destImage.SetResolution(imagine.HorizontalResolution, imagine.VerticalResolution);
            using (var g = Graphics.FromImage(destImage))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapmode = new ImageAttributes())
                {
                    wrapmode.SetWrapMode(WrapMode.TileFlipXY);
                    g.DrawImage(imagine, dest_rect, 0, 0, latime, lungime, GraphicsUnit.Pixel, wrapmode);
                }
            }
            for (int i = 0; i < destImage.Width; i++)
            {
                destImage.SetPixel(i, 0, Color.Black);
                destImage.SetPixel(i, destImage.Height-1, Color.Black);
            }
            for (int i = 0; i < destImage.Height; i++)
            {
                destImage.SetPixel(0, i, Color.Black);
                destImage.SetPixel(destImage.Width-1, i, Color.Black);
            }
                return destImage;
        }



















        private static Image resizeImageCorrectly(Image img)
        {
            double ratio = PacientData.getRatio();
            if (Math.Abs(ratio - 1.7660377) < 0.000001)
            {
                return resizeByParameter(img, 468);
            }
    
            else if (Math.Abs(ratio - 1.5705128) < 0.000001)
            {
                return resizeByParameter(img,245);
            }
            else if (Math.Abs(ratio - 1.525641)  < 0.000001)
            {
                return resizeByParameter(img,238);
            }
            else if (Math.Abs(ratio - 1.4807692) < 0.000001)
            {
                return resizeByParameter(img,231);
            }
            else if (Math.Abs(ratio - 1.5217391) < 0.000001)
            {
                return resizeByParameter(img,245);
            }
            else if (Math.Abs(ratio - 1.4782608) < 0.000001)
            {
                return resizeByParameter(img,238);
            }
            else if (Math.Abs(ratio - 1.4347826) < 0.000001)
            {
                return resizeByParameter(img,231);
            }

            return img;
        }
        public static void addImage(Image img)
        {
            img = resizeImageCorrectly(img);
            indexImage++;
            currentGroupImages.addImage(img);
            if (!currentGroupImages.canAddImage())
            {
                allImages.Add(new GroupImages());
                currentGroupImages = allImages[allImages.Count - 1];
            }
        }
        public static void removeImage()
        {
            if (!currentGroupImages.canRemoveImage() && allImages.Count != 1)
            {
                allImages.RemoveAt(allImages.Count - 1);
                currentGroupImages = allImages[allImages.Count - 1];
                currentGroupImages.removeImage();
                indexImage--;
            }
            else if (currentGroupImages.canRemoveImage())
            {
                currentGroupImages.removeImage();
                indexImage--;
            }
        }


    }
}
