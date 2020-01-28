using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class PermittedEquipment
    {
        private string _equipmentName;
        public string EquipmentName {
            get { return _equipmentName; }
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Equipment name cannot be longer than 255 characters.");

                _equipmentName = value;
            }
        }

        public double MaxLength { get; set; }
    }
}
