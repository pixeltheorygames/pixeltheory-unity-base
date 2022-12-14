using System;
using System.Collections;
using System.Reflection;
using System.Threading;
using Pixeltheory.Debug;
using Pixeltheory.Tests.CustomTestClasses;
using UnityEngine;
using UnityEngine.TestTools;


namespace Pixeltheory.Tests
{
    public class WorkerThreadLoggerTests
    {
        /*
         * Ellis 2022.12.10
         * WIP Need to figure out exactly when exceptions are thrown away before we test.
         */
        //[UnityTest]
        public IEnumerator WorkerThreadThrownExceptionTest()
        {
            Assembly testClassesAssembly = Assembly.GetAssembly(typeof(WorkerDomainExceptionThrower));
            AppDomain workerDomain = AppDomain.CreateDomain("Worker Domain");
            workerDomain.ExecuteAssemblyByName(testClassesAssembly.GetName());

            Logging.Log(AppDomain.CurrentDomain.FriendlyName);
            
            // LogAssert.Expect(LogType.Exception, "Exception: Exception on worker thread.");
            // Logging.Warn(AppDomain.CurrentDomain.ToString());
            // LogAssert.Expect(LogType.Exception, "[Exception] Exception: Exception on worker thread.");
            // GameObject testGameObject =
            //       new GameObject
            //       (
            //           "Test GameObject with WorkerThreadLogger",
            //           typeof(WorkerThreadLogger)
            //       );
            
            
             
             // Logging.Warn(Thread.CurrentThread.ManagedThreadId);
             // ThreadStart threadStart = this.ThrowTestException;
             // Thread testThread = new Thread(threadStart);
             // testThread.Start();
             yield break;
        }
    }
}
