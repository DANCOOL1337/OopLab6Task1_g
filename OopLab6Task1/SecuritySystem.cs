using System;
using System.Collections.Generic;
using System.Text;

namespace OopLab6Task1
{
    class SecuritySystem : LogicPair
    {
        
        private bool isArmed;

        public bool IsArmed
        {
            get { return isArmed; }
            set { isArmed = value; }
        }

        
        public SecuritySystem() : base()
        {
            this.isArmed = false;
        }

        /
        public SecuritySystem
            (bool doorOpen, bool windowOpen, 
            bool isArmed) : base(doorOpen, windowOpen)
        {
            this.isArmed = isArmed;
        }

        
        public SecuritySystem(SecuritySystem other) : base(other)
        {
            if (other != null)
            {
                this.isArmed = other.IsArmed;
            }
        }

        
        public bool CheckAlarmTrigger()
        {
            
            if (this.isArmed && this.CalculateNor() == false)
            {
                return true; 
            }
            return false; 
        }

        
        public void ToggleStatus()
        {
            this.isArmed = !this.isArmed;
        }

        
        public override string ToString()
        {
            return $"{base.ToString()}, " +
                $"На охране: {this.isArmed}";
        }
    }
}
