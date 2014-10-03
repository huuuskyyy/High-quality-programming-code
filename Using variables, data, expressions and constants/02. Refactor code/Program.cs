using System;

public class Program
{
    public void PrintStatistics(double[] inputData, int length)
    {
        double maxData = Int32.MinValue;

        for (int i = 0; i < length; i++)
        {
            if (inputData[i] > maxData)
            {
                maxData = inputData[i];
            }
        }

        PrintMaxData(maxData);

        double minData = Int32.MaxValue;

        for (int i = 0; i < length; i++)
        {
            if (inputData[i] < minData)
            {
                minData = inputData[i];
            }
        }

        PrintMin(minData);

        double averageData = 0;

        for (int i = 0; i < length; i++)
        {
            averageData += inputData[i];
        }

        PrintAvg(averageData / length);
    }
}


