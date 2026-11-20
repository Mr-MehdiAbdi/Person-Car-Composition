using System;
using System.Collections.Generic;
using System.Text;

namespace PersonCarComposition
{
    public class PlateNumber
    {
        private string firstPart;
        public string FirstPart
        {
            get => firstPart;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length!=2 || !value.All(char.IsDigit))
                {
                    throw new Exception("FirstPart must contain  2 digits.");
                }
                firstPart = value;
            }
        }

        private string letter;

        public string Letter
        {
            get => letter;
            set
            {
                if (string.IsNullOrWhiteSpace(value) ||
                    value.Length != 1 ||
                    !char.IsLetter(value[0]) ||
                    value[0] < 'آ' || value[0] > 'ی')
                {
                    throw new ArgumentException("Invalid Persian plate letter.");
                }

                letter = value;
            }
        }

        private string middlePart;

        public string MiddlePart
        {
            get => middlePart;
            set
            {
                if (string.IsNullOrWhiteSpace(value) ||
                    value.Length != 3 ||
                    !value.All(char.IsDigit))
                {
                    throw new ArgumentException("MiddlePart must contain exactly 3 digits.");
                }

                middlePart = value;
            }
        }

        private string cityCode;

        public string CityCode
        {
            get => cityCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value) ||
                    value.Length != 2 ||
                    !value.All(char.IsDigit))
                {
                    throw new ArgumentException("CityCode must contain exactly 2 digits.");
                }

                cityCode = value;
            }
        }
    }
}
