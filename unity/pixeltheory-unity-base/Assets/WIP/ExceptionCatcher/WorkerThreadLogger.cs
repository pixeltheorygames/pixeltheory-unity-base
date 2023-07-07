using System;


namespace Pixeltheory.Debug
{
   /*
    * Ellis 2022.12.10
    * For the time being, don't use this. There still seems to be confusion as to when exactly Unity
    * throws away exceptions. Async tasks, threads, worker domains, threads on worker domains, thread pool
    * threads, are some of the guesses the community has as to when exceptions are silently killed and
    * the engine continues as if nothing happened.
    */
    // public class WorkerThreadLogger : PixelBehaviour<WorkerThreadLogger, PixelObject>
    // {
    //     #region Methods
    //     #region Unity Messages
    //     private void Start()
    //     {
    //         PixelLog.Warn(AppDomain.CurrentDomain.ToString());
    //         AppDomain.CurrentDomain.UnhandledException += this.WorkerThreadUnhandledExceptionHandler;
    //     }
    //     #endregion //Unity Messages
    //
    //     #region Event Handlers
    //     private void WorkerThreadUnhandledExceptionHandler(object obj, UnhandledExceptionEventArgs args)
    //     {
    //         PixelLog.Exception(args.ExceptionObject as Exception);
    //     }
    //     #endregion //Event Handlers
    //     #endregion//Methods
    // }   
}