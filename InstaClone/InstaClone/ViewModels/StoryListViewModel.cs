using InstaClone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InstaClone.ViewModels
{
    public class StoryListViewModel
    {
        public ObservableCollection<StoryModel> Stories { get; set; } = new ObservableCollection<StoryModel>();
        public StoryListViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                Stories.Add(new StoryModel());
            }
        }
    }
}
