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
        
        private string _entityType;
        public string EntityType { 
            get { return _entityType; } 
            set
            {
                if (value.Length > 50)
                    throw new ArgumentOutOfRangeException("Entity type cannot be longer than 50 characters.");
                
                _entityType = value;
            } 
        } 
        
        private string _title;
        public string Title { 
            get { return _title; } 
            set
            {
                if (value.Length > 500)
                    throw new ArgumentOutOfRangeException("Title cannot be longer than 500 characters.");
                
                _title = value;
            } 
        } 
        
        private string _subtitle;
        public string Subtitle { 
            get { return _subtitle; } 
            set
            {
                if (value.Length > 1000)
                    throw new ArgumentOutOfRangeException("Subtitle cannot be longer than 1000 characters.");
                
                _subtitle = value;
            } 
        } 
        public string Description { get; set; }
        public string EmbedCode { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsPreview { get; set; }
        public bool IsGallery { get; set; }
        public string Url { get; set; }
        
        private string _credits;
        public string Credits { 
            get { return _credits; } 
            set
            {
                if (value.Length > 1000)
                    throw new ArgumentOutOfRangeException("Credits cannot be longer than 1000 characters.");
                
                _credits = value;
            } 
        } 
    }

    public enum MediaType
    {
        Image,
        Video
    }
}
