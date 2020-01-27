using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Event
    {
        public string EventId { get; set; }

        private string _eventName;
        public string EventName {
            get { return _eventName; }
            set
            {
                if (value.Length > 60)
                    throw new ArgumentOutOfRangeException("Event name cannot be longer than 60 characters.");

                _eventName = value;
            }
        } 

        public string ResourceLink { get; set; }
    }
}
