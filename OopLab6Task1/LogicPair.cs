using System;
using System.Collections.Generic;
using System.Text;

namespace OopLab6Task1
{
    class LogicPair
    {
        // Приватные поля (автосвойства запрещены)
        private bool firstCondition;
        private bool secondCondition;

        // Полноценные свойства
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

        // Конструктор по умолчанию
        public LogicPair()
        {
            this.firstCondition = false;
            this.secondCondition = false;
        }

        // Конструктор с параметрами
        public LogicPair(bool firstCondition, bool secondCondition)
        {
            this.firstCondition = firstCondition;
            this.secondCondition = secondCondition;
        }

        // Конструктор копирования
        public LogicPair(LogicPair other)
        {
            if (other != null)
            {
                this.firstCondition = other.FirstCondition;
                this.secondCondition = other.SecondCondition;
            }
        }

        // Метод, вычисляющий отрицание дизъюнкции (!(A || B))
        public bool CalculateNor()
        {
            return !(this.firstCondition || this.secondCondition);
        }

        // Перегрузка ToString() с использованием интерполяции, как в лекциях
        public override string ToString()
        {
            return $"Условие 1: {this.firstCondition}, Условие 2: {this.secondCondition}";
        }
    }
}
