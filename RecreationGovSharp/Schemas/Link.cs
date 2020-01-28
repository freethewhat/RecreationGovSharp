using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Link
    {
        public string EntityLinkId { get; set; }
        
        private string _linkType;
        public string LinkType { 
            get { return _linkType; } 
            set
            {
                if (value.Length > 500)
                    throw new ArgumentOutOfRangeException("Link type cannot be longer than 500 characters.");

                _linkType = value;
            } 
        } 
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

        public string Description { get; set; }
        
        private string _url;
        public string Url { 
            get { return _url; } 
            set
            {
                if (value.Length > 2000)
                    throw new ArgumentOutOfRangeException("URL cannot be longer than 2000 characters.");

                _url = value;
            } 
        } 
    }
}
