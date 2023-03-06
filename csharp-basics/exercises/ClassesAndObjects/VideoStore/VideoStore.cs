using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _videoList = new List<Video>();

        public void AddVideo(string title)
        {
            _videoList.Add(new Video(title));
        }

        public void Checkout(string title)
        {
            int index = _videoList.FindIndex(x => x.Title == title);
            _videoList[index].BeingCheckedOut();
        }

        public void ReturnVideo(string title)
        {
            int index = _videoList.FindIndex(x => x.Title == title);
            _videoList[index].BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            int index = _videoList.FindIndex(x => x.Title == title);
            _videoList[index].ReceivingRating(rating);
        }

        public void ListInventory()
        {
            foreach (var item in _videoList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
