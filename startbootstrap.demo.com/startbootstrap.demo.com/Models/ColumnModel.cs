using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Web;

namespace startbootstrap.demo.com.Models
{
    public class ColumnModel : IRenderingModel
    {
        public string Title { get; set; }
        public string Introduction { get; set; }
        public Rendering Rendering { get; set; }
        public Item Item { get; set; }
        public RenderingParameters Parameters { get; set; }
        public Item PageItem { get; set; }
        public void Initialize(Rendering rendering)
        {
            Rendering = rendering;
            Item = rendering.Item;
            Parameters = rendering.Parameters;
            PageItem = PageContext.Current.Item;

            Title = Item["Title"];
            Introduction = Item["Introduction"];
        }
    }
}