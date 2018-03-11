using System;

public class BinarySearch
{
    private int[] _inputValues;
    public BinarySearch(int[] input)
    {
        _inputValues = input;
    }

    public int Find(int value)
    {
        var middle = 0;
        var left = 0;
        var right = _inputValues.Length - 1;

        while (left <= right) {
            middle = (left + right) / 2;
            
            //if value in array is smaller than our target, increment the left index start
            if (_inputValues[middle] < value) {
                left = middle + 1;
            }
            //if value in array is larger than our value, decrement the right index
            else if (_inputValues[middle] > value) {
                right = middle - 1;
            }
            //otherwise, we have found our number and should return that.
            else {
                return middle;
            }
        }

        return -1;
    }
}