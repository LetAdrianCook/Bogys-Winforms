using Bogys_Winforms.Models;
using Bogys_Winforms.Strings;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bogys_Winforms.Services.AdminFunctions
{
    class VideoLibraryFunctions
    {
        StringsVariables strTxt = new StringsVariables();
        public List<Video> GetAllVideos()
        {
            using (var context = new AppDbContext())
            {
                return context.Video.ToList();
            }
        }
        public void HeaderTitle(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dataGridView.Columns[strTxt.ID].Visible = false;
            dataGridView.Columns[strTxt.VideoTitle].HeaderText = strTxt._VideoTitle;
            dataGridView.Columns[strTxt.VideoCategory].HeaderText = strTxt._VideoCategory;
            dataGridView.Columns[strTxt.RentDays].HeaderText = strTxt._RentDays;
            dataGridView.Columns[strTxt.VideoInCount].HeaderText = strTxt._VideoInCount;
            dataGridView.Columns[strTxt.VideoOutCount].HeaderText = strTxt._VideoOutCount;
            dataGridView.Columns[strTxt.VideoPrice].HeaderText = strTxt._VideoPrice;
            dataGridView.Columns[strTxt.VideoAdded].HeaderText = strTxt._VideoAdded;
        }
        public bool AddVideo(string title, string category, int price, int rentDays, int stock)
        {
            using (var context = new AppDbContext())
            {
                bool exists = context.Video.Any(v => v.VideoTitle.ToLower() == title.Trim().ToLower());
                if (exists)
                {
                    return false;
                }

                var newVideo = new Video
                {
                    VideoTitle = title.Trim(),
                    VideoCategory = category,
                    VideoPrice = price,
                    RentDays = rentDays,
                    VideoInCount = stock,
                    VideoOutCount = 0,
                    VideoAdded = DateTime.Now
                };

                context.Video.Add(newVideo);
                return context.SaveChanges() > 0;
            }
        }
        public bool EditVideo(int videoId, string videoTitle, string videoCategory,
                         int incount, int rentdays, int price)
        {
            using (var context = new AppDbContext())
            {
                var video = context.Video.FirstOrDefault(u => u.ID == videoId);
                if (video == null) return false;

                video.VideoTitle = videoTitle;
                video.VideoCategory = videoCategory;
                video.VideoInCount = incount;
                video.RentDays = rentdays;
                video.VideoPrice = price;
               
                context.SaveChanges();
                return true;                   
            }
        }

        public bool DeleteVideo(int videoId)
        {
            using (var context = new AppDbContext())
            {
                var video = context.Video.FirstOrDefault(u => u.ID == videoId);
                if (video == null) return false;
            
                context.Video.Remove(video);
                context.SaveChanges();
                return true;                    
            }
        }


    }
}
