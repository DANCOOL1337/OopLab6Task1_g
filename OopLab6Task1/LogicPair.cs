using System;
using System.Collections.Generic;
using System.Text;

namespace OopLab6Task1
{
    class LogicPair
    {

        private bool _firstCondition;
        private bool _secondCondition;


        public LogicPair()
        {
            this._firstCondition = false;
            this._secondCondition = false;
        }


        public LogicPair(bool _firstCondition,
            bool _secondCondition)
        {
            this._firstCondition = _firstCondition;
            this._secondCondition = _secondCondition;
        }


        public LogicPair(LogicPair other)
        {
            if (other != null)
            {
                this._firstCondition = other._firstCondition;
                this._secondCondition = other._secondCondition;
            }
        }

        public bool FirstCondition
        {
            get
            {
                return _firstCondition;
            }
            set
            {
                _firstCondition = value;
            }
        }

        public bool SecondCondition
        {
            get
            {
                return _secondCondition;
            }
            set
            { _secondCondition = value; }
        }

        public bool CalculateNor()
        {
            return
                !(this._firstCondition || this._secondCondition);
        }


        public override string ToString()
        {
            return $"Условие 1: {this._firstCondition}, " +
                $"Условие 2: {this._secondCondition}";
        }
    }
}
