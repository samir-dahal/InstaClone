﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstaClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoryListView : ContentView
    {
        public StoryListView()
        {
            InitializeComponent();
        }
    }
}