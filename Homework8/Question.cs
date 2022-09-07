using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    /// <summary>
    /// Вопрос
    /// </summary>
    internal class Question
    {
        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Ответ (да/нет)
        /// </summary>
        public bool TrueFalse { get; set; }

        /// <summary>
        /// Конструктор "по умолчанию" 
        /// </summary>
        public Question()
        {

        }

        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }

    }
}
