using System;

using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T,Y>
    {
        T[] _cityCode;
        T[] _tempcityCode;
        T[] _cityName;
        T[] _tempCityName;
        public MyDictionary()
        {
            _cityCode = new T[0];
            _cityName = new T[0];
        }

        public void Add(T cityCode, Y cityName)
        {
            
            _tempCityName = _cityName;
            _cityName = new T[_cityName.Length + 1];
            _tempcityCode = _cityCode;
            _cityCode = new T[_cityCode.Length + 1];


            for (int i = 0; i < _tempcityCode.Length; i++)
            {
                _cityCode[i] = _tempcityCode[i];
            }

            _cityCode[_cityCode.Length - 1] = cityCode;

            for (int i = 0; i < _tempCityName.Length; i++)
            {
                _cityName[i] = _tempCityName[i];
            }

            _cityName[_cityName.Length - 1] = cityName;

        }

        public int MyDicCount
        {
            get { return _cityCode.Length; }
        }

        public int Count() {

            { return _cityCode.Length; }
        }

        public T[] CityCodes 
        {
            get { return _cityCode; }
        }

        public T[] cityName
        {
            get { return _cityName; }
        }
    }
}
    