using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCRM
{
    public class MonitorPerformance
    {
        private static readonly PerformanceCounter avgCounter64Sample;
        private static readonly PerformanceCounter avgCounter64SampleBase;


        public void CreateCounters()
        {
            avgCounter64Sample = new PerformanceCounter("AverageCounter64SampleCategory",
                "AverageCounter64Sample",
                false);
             

            avgCounter64SampleBase = new PerformanceCounter("AverageCounter64SampleCategory",
                "AverageCounter64SampleBase",
                false);

            avgCounter64Sample.RawValue = 0;
            avgCounter64SampleBase.RawValue = 0;
        }

        private static void OutputSample(CounterSample s)
        {
            Console.WriteLine("\r\n+++++++++++");
            Console.WriteLine("Sample values - \r\n");
            Console.WriteLine("   BaseValue        = " + s.BaseValue);
            Console.WriteLine("   CounterFrequency = " + s.CounterFrequency);
            Console.WriteLine("   CounterTimeStamp = " + s.CounterTimeStamp);
            Console.WriteLine("   CounterType      = " + s.CounterType);
            Console.WriteLine("   RawValue         = " + s.RawValue);
            Console.WriteLine("   SystemFrequency  = " + s.SystemFrequency);
            Console.WriteLine("   TimeStamp        = " + s.TimeStamp);
            Console.WriteLine("   TimeStamp100nSec = " + s.TimeStamp100nSec);
            Console.WriteLine("++++++++++++++++++++++");
        }

        public static void CollectSamples(ArrayList samplesList)
        {

            Random r = new Random(DateTime.Now.Millisecond);

            // Loop for the samples.
            for (int j = 0; j < 100; j++)
            {

                int value = r.Next(1, 10);
                Console.Write(j + " = " + value);

                avgCounter64Sample.IncrementBy(value);

                avgCounter64SampleBase.Increment();

                if ((j % 10) == 9)
                {
                    samplesList.Add(avgCounter64Sample.NextSample());
                    OutputSample(avgCounter64Sample.NextSample());
                }
                else
                {
                    Console.WriteLine();
                }

                System.Threading.Thread.Sleep(50);
            }
        }



    }
}
