using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public class Car : IRenderingModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Rendering Rendering { get; set; }
        public Item Item { get; set; }
        public Item PageItem { get; set; }

        public void Initialize(Rendering rendering)
        {
            Rendering = rendering;
            Item = rendering.Item;
            PageItem = PageContext.Current.Item;

            Make = Item["Make"];
            Model = Item["Model"];
            Year = Convert.ToInt32(Item["Year"]);
        }
    }
}