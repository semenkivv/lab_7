using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_7_V_11
{
    public class ListTasks
    {
        private List<Task> _listTasks;
        /// <summary>
        /// Инициализация листа задач с помощью массива заданий или пустой лист
        /// </summary>
        /// <param name="tasks">задачи, добавляемые в лист</param>
        public ListTasks(params Task[] tasks)
        {
            if (tasks is not null)
            {
                List<Task> newListTasks = new List<Task>();
                foreach (var task in tasks)
                {
                    newListTasks.Add(task);
                }
                _listTasks = newListTasks;
            }
            else
            {
                _listTasks = new List<Task>();
            }
        }

        /// <summary>
        /// Добавления елемента в лист, возвращает ArgumentNullException, если добавляемый елемент равен нулю
        /// </summary>
        /// <param name="task">добавляемая задача в лист </param>
        public void AddElement(Task task)
        {
            if (task is not null)
            {
                _listTasks.Add(task);
            }
            else
            {
                throw new ArgumentNullException();
            }

        }
        /// <summary>
        /// Удаление задачи по индексу в листе, возвращает ArgumentOutOfRangeException, если индекс выходит за пределы листа
        /// </summary>
        /// <param name="indexRemove">индекс удаляемого улемента</param>
        public void RemoveElementByIndex(int indexRemove)
        {
            if (indexRemove > 0 && indexRemove < _listTasks.Count)
            {
                _listTasks.RemoveAt(indexRemove);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// Обновление статуса выполненой задачи  по индексу , возвращает ArgumentOutOfRangeException, если индекс выходит за пределы листа
        /// </summary>
        /// <param name="indexUpdate">индекс обновляемой задачи</param>
        public void UpdateStatusOnComplitedByIndex(int indexUpdate)
        {
            if (indexUpdate > 0 && indexUpdate < _listTasks.Count)
            {
                _listTasks[indexUpdate].IsCompleted = true;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (var element in _listTasks)
            {
                str.Append(element + "\n\n");
            }
            return str.ToString();
        }

    }
}
