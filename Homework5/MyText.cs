using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal static class MyText
    {
        private static string text = @"
            Все переплетено, море нитей, но.
            Потяни за нить, за ней потянется клубок.
            Этот мир - веретено, совпадений - ноль.
            Нитью быть или струной, или для битвы тетивой.
            Все переплетено, в единый моток.
            Нитяной комок и не ситцевый платок.
            Перекати-поле гонит с неба ветерок,
            Все переплетено, но не предопределено.
        ";

        public static string Text { get { return text; } private set { text = value; } }
    }
}
