using System;
using System.Collections.Generic;
using System.Text;

namespace OopLab6Task1
{
    class SecuritySystem : LogicPair
    {
        // Собственное поле: поставлена ли система на охрану
        private bool isArmed;

        public bool IsArmed
        {
            get { return isArmed; }
            set { isArmed = value; }
        }

        // Конструктор по умолчанию (вызывает базовый)
        public SecuritySystem() : base()
        {
            this.isArmed = false;
        }

        // Конструктор с параметрами (передает часть аргументов базовому)
        public SecuritySystem(bool doorOpen, bool windowOpen, bool isArmed) : base(doorOpen, windowOpen)
        {
            this.isArmed = isArmed;
        }

        // Конструктор копирования
        public SecuritySystem(SecuritySystem other) : base(other)
        {
            if (other != null)
            {
                this.isArmed = other.IsArmed;
            }
        }

        // Метод 1: Проверка срабатывания тревоги
        public bool CheckAlarmTrigger()
        {
            // Если на охране и дизъюнкция (хоть что-то открыто) истинна.
            // Так как CalculateNor() это !(A || B), если он вернул false - значит произошло вторжение.
            if (this.isArmed && this.CalculateNor() == false)
            {
                return true; // Тревога
            }
            return false; // Все спокойно
        }

        // Метод 2: Переключение статуса охраны
        public void ToggleStatus()
        {
            this.isArmed = !this.isArmed;
        }

        // Перегрузка ToString() с использованием base.ToString()
        public override string ToString()
        {
            return $"{base.ToString()}, На охране: {this.isArmed}";
        }
    }
}
