using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap09
{
    internal class BMICalculator
    {
        private double _height, _weight;

        /// <summary>
        /// BMI的狀態
        /// </summary>
        /// <returns>18.5以下:體重過輕,18.5~24:體重正常, 24以上:體重過重</returns>
        public string Status()
        {
            double bmi = _weight / _height / _height;
            if (bmi < 18.5)
                return string.Format($"BMI={bmi:0.00}, 體重過輕");
            else if(bmi < 24)
                return string.Format($"BMI={bmi:0.00}, 體重正常");
            else
                return string.Format($"BMI={bmi:0.00}, 體重過重");
        }
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="height">身高(cm)</param>
        /// <param name="weight">體重(kg)</param>
        public BMICalculator(double height, double weight)
        {
            _weight = weight;
            _height = height / 100;
        }
    }
}
