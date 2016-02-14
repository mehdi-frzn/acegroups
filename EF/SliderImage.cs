namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class SliderImage
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(100)]
        public string ImagePath { get; set; }

        public bool Status { get; set; }
    }
    public static class SliderImages
    {
        
        public static List<SliderImage> selectimage()
        {
            DB sample = new DB();
            return sample.SliderImages.ToList();
        }
        public static SliderImage selectsingle(int id)
        {
            DB sample = new DB();
            return sample.SliderImages.Single(item => item.ID == id);
        }
        public static void Addimages(SliderImage slider)
        {
            DB sample = new DB();
            sample.SliderImages.Add(slider);
            sample.SaveChanges();
        }
        public static void updateimage(SliderImage slider)
        {
            DB sample = new DB();
            SliderImage oldimage = sample.SliderImages.Single(item => item.ID == slider.ID);
            oldimage.Title = slider.Title;
            oldimage.ImagePath = slider.ImagePath;
            oldimage.Status = slider.Status;
            sample.SaveChanges();
        }
        public static void delete(int id)
        {
            DB sample = new DB();
            SliderImage deleteitem = sample.SliderImages.Single(item => item.ID == id);
            sample.SliderImages.Remove(deleteitem);
            sample.SaveChanges();
        }
    }
}
