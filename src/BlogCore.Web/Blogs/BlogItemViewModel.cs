﻿using System;
using BlogCore.Core;

namespace BlogCore.Web.Blogs
{
    public class BlogItemViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Theme { get; set; }
    }
}