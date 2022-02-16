using System;
using System.Collections.Generic;
using System.Text;

namespace InstaClone.Models
{
    public class PostModel
    {
        public string Profile => "https://bit.ly/3BlwCeR";
        public string UserName => "Samir Dahal";
        public string TimeElapsed => $"{new Random().Next(1, 59)} minutes ago";
        public string Image => "https://picsum.photos/400/400";
    }
}
