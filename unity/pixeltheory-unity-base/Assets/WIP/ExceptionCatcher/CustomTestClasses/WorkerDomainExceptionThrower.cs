using System;
using Pixeltheory.Debug;


namespace Pixeltheory.Tests.CustomTestClasses
{
    /*
        * Ellis 2022.12.10
        * WIP Need to figure out exactly when exceptions are thrown away before we test.
        */
    public class WorkerDomainExceptionThrower
    {
        public static void Main()
        {
            Logging.Log(AppDomain.CurrentDomain.FriendlyName);
            WorkerDomainExceptionThrower workerDomainExceptionThrower = new WorkerDomainExceptionThrower();
        }
        
        public WorkerDomainExceptionThrower()
        {
            //Logging.Log(AppDomain.CurrentDomain.FriendlyName);
            //throw new Exception("Exception on worker thread.");
        }
    }   
}
