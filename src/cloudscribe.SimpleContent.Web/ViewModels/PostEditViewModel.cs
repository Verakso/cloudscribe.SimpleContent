﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:                  Joe Audette
// Created:                 2017-03-02
// Last Modified:           2017-06-09
// 

using System.ComponentModel.DataAnnotations;

namespace cloudscribe.SimpleContent.Web.ViewModels
{
    public class PostEditViewModel
    {
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = "ProjectId is required")]
        public string ProjectId { get; set; } = string.Empty;

        public string CorrelationKey { get; set; } = string.Empty;


        [Required(ErrorMessage = "Title is required")]
        [StringLength(255, ErrorMessage = "Title has a maximum length of 255 characters")]
        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        public string MetaDescription { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public bool IsPublished { get; set; } = false;

        public string Categories { get; set; }

        public string PubDate { get; set; } = string.Empty;

        public string CurrentPostUrl { get; set; }

        public string DeletePostRouteName { get; set; }

       
    }
}
