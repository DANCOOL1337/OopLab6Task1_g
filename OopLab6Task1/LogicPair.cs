using System;
using System.Collections.Generic;
using System.Text;

namespace OopLab6Task1
{
    class LogicPair
    {
        
        private bool firstCondition;
        private bool secondCondition;

        
        public LogicPair()
        {
            this.firstCondition = false;
            this.secondCondition = false;
        }

        
        public LogicPair(bool firstCondition, 
            bool secondCondition)
        {
            this.firstCondition = firstCondition;
            this.secondCondition = secondCondition;
        }

        
        public LogicPair(LogicPair other)
        {
            if (other != null)
            {
                this.firstCondition = other.FirstCondition;
                this.secondCondition = other.SecondCondition;
            }
        }

        public bool FirstCondition
        {
            get { return firstCondition; }
            set { firstCondition = value; }
        }

        public bool SecondCondition
        {
            get { return secondCondition; }
            set { secondCondition = value; }
        }

        public bool CalculateNor()
        {
            return 
                !(this.firstCondition || this.secondCondition);
        }

        
        public override string ToString()
        {
            return $"Условие 1: {this.firstCondition}, " +
                $"Условие 2: {this.secondCondition}";
        }
    }
}
