using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Media
    {
        public string EntityMediaId { get; set; }
        public MediaType MediaType { get; set; }
        public string EntityId { get; set; }
        public string EntityType { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string EmbedCode { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsPreview { get; set; }
        public bool IsGallery { get; set; }
        public string Url { get; set; }
        public string Credits { get; set; }
    }

    public enum MediaType
    {
        Image,
        Video
    }
}
