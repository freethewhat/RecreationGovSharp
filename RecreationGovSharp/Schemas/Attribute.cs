using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Attribute
    {
        public int AttributeId { get; set; }

        private string _attribute;
        public string AttributeName {
            get
            {
                return _attribute;
            }
            set
            {
                if (value.Length > 60)
                    throw new ArgumentOutOfRangeException("Attribute name cannot be longer than 60 characters.");

                _attribute = value;
            }
        }

        private string _attributeValue;
        public string AttributeValue {
            get { return _attributeValue; }
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Attribute value cannot be longer than 255 characters.");

                _attributeValue = value;
            }
        }
    }
}
