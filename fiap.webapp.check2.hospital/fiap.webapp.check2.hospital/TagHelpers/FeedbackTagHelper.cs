﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace fiap.webapp.check2.hospital.TagHelpers
{
    public class FeedbackTagHelper :TagHelper
    {
        public string Texto { get; set; }
        public string Class { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(Texto))
            {
                output.TagName = "div";
                output.Attributes.SetAttribute("class", string.IsNullOrEmpty(Class) ? "alert alert-success" : Class);
                output.Content.SetContent(Texto);
            }
        }
    }
}
