using System;

namespace netcore_sdk_example
{
    using CoralogixCoreSDK;
    using System.Threading.Tasks;

    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                CoralogixLogger coralogixLogger;
                // The common practice is to get an instance of the logger in each class and setting the logger name to the class name.
                //logger name will be used as category unless specified otherwise.
                coralogixLogger = CoralogixLogger.GetLogger("My class");
                // Configure Coralogix SDK. You need to define it only once per process.
                coralogixLogger.Configure("be1fe366-ed73-a842-bb3e-74fa24c1c3fe", "MyTestApp", "BL");
                //Send "Hello World!" message with severity verbose.
                coralogixLogger.Log(Severity.Error, "Hello Juan! 10");
                i++;
                Console.WriteLine("Hello World!");
                Task.Delay(1000).Wait();
            } while ( i < 10);
            
        }
    }
}
