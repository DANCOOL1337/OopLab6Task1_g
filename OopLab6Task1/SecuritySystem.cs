using System;
using System.Collections.Generic;
using System.Text;

namespace OopLab6Task1
{
    class SecuritySystem : LogicPair
    {

        private bool _isArmed;



        public SecuritySystem() : base()
        {
            this._isArmed = false;
        }


        public SecuritySystem
            (bool doorOpen, bool windowOpen,
            bool _isArmed) : base(doorOpen, windowOpen)
        {
            this._isArmed = _isArmed;
        }


        public SecuritySystem(SecuritySystem other) : base(other)
        {
            if (other != null)
            {
                this._isArmed = other._isArmed;
            }
        }

        public bool IsArmed
        {
            get
            {
                return _isArmed;
            }
            set
            {
                _isArmed = value;
            }
        }

        public bool CheckAlarmTrigger()
        {

            if (this._isArmed && this.CalculateNor() == false)
            {
                return true;
            }
            return false;
        }


        public void ToggleStatus()
        {
            this._isArmed = !this._isArmed;
        }


        public override string ToString()
        {
            return $"{base.ToString()}, " +
                $"На охране: {this._isArmed}";
        }
    }
}
