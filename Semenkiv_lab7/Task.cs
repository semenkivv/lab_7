using System;

namespace Laba_7_V_11
{
    public class Task
    {
        private bool _isCompleted;
        private string _description;
        private DateTime _dateCreated;
        private DateTime _dateCompleated;

        public Task(string description)
        {
            IsCompleted = false;
            Description = description;
            DateCreated = DateTime.Now;
        }


        /// <summary>
        /// Свойство выполнена ли задача
        /// </summary>
        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                if (value)
                {
                    DateCompleated = DateTime.Now;
                }
                _isCompleted = value;
            }
        }
        /// <summary>
        /// Свойство описание задачи , возвращает ArgumentNullException, если пытаемся присвоить пустую строку
        /// </summary>
        public string Description
        {
            get => _description;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _description = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        ///  Свойство дата создания задачи, возвращает ArgumentException если некоректная дата
        /// </summary>
        public DateTime DateCreated
        {
            get => _dateCreated;
            init
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _dateCreated = value;
                }
            }
        }
        /// <summary>
        ///  Свойство дата, когда выполненили задачу, возвращает ArgumentException если некоректная дата
        /// </summary>
        public DateTime DateCompleated
        {
            get => _dateCompleated;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _dateCompleated = value;
                }
            }
        }
        public override string ToString()
        {
            string isCompleted = (IsCompleted ? "" : "not ")+ "compleated" + (IsCompleted ? " at ="+DateCompleated : "") ;
            return $"Task ({isCompleted})\nDescription={Description};  \nCreated  ={DateCreated}; \n";
        }
    }
}
