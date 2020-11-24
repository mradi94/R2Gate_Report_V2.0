using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace R2Gate_Report_v2._0
{
    class GroupImages
    {
        private List<Image> images;
        private int maximImages;
        //Getter and Setter :
        public List<Image> getImages()
        {
            return images;
        }
        public void setMaximImages(int maximImages)
        {
            this.maximImages = maximImages;
        }
        
        //Constructor:
        public GroupImages()
        {
            maximImages = 0;
            images= new List<Image>();
        }

        public void addImage(Image img)
        {
            images.Add(img);
        }

        public void removeImage()
        {
            images.RemoveAt(images.Count - 1);
        }
        public Boolean canAddImage()
        {
            if (images.Count >= maximImages)
            {
                return false;
            }
            return true;
        }
        public Boolean canRemoveImage()
        {
            if (images.Count == 0)
            {
                return false;
            }
            return true;
        }
        public int getIndex()
        {
            return images.Count() + 1;
        }




    }
}
