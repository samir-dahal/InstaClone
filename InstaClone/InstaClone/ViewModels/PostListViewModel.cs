using InstaClone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InstaClone.ViewModels
{
    public class PostListViewModel
    {
        public ObservableCollection<PostModel> Posts { get; set; } = new ObservableCollection<PostModel>();
        public PostListViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                Posts.Add(new PostModel());
            }
        }
    }
}
