using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;

namespace FaceUp
{

    //Твой бэкенд
    class FaceUpManager
    {
        //возвращает лист путей к маскам из папки или битмапы, еще не известно
        public List<string> GetMaskPathsOf ( string maskType )
        {
            return new List<string>();
        }
        
        //обрабатывает фрейм и возвращает новый рисунок на вывод
        public Bitmap DrawProcessedFrame ()
        {
            return new Bitmap("");
        }
    }
}
