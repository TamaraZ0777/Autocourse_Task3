namespace ArrayTraining_Task3
{
    class ArrayOfNumbers
    {
        
        private int _minValue;
        private int _maxValue;
        private int[] arrayOfNumbers = null;

        public ArrayOfNumbers(int minValue, int maxValue)
        {
            this._minValue = minValue;
            this._maxValue = maxValue;
            this.arrayOfNumbers = new int[_maxValue - _minValue + 1];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = i + _minValue;
            }
        }

        
        public int CalculateSum()
        {
            int result = 0;
            for (int i = 0; i < (arrayOfNumbers.Length); i++)
            //foreach (int i in arrayOfNumbers)

            {
                //var value1 = arrayOfNumbers[i];

                if (((arrayOfNumbers[i] % 3) == 0) && (arrayOfNumbers[i] % 5 > 0))
                {
                    //var a = arrayOfNumbers[i];
                    //result = arrayOfNumbers[a];

                    result += arrayOfNumbers[i];
                }

            }
            return result;

        }

    }
}
