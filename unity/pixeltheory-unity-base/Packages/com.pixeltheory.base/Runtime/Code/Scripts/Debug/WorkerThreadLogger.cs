using System;


namespace Pixeltheory.Debug
{
    public class WorkerThreadLogger : PixelBehaviour<WorkerThreadLogger>
    {
        #region Methods
        #region Unity Messages
        private void Start()
        {
            AppDomain.CurrentDomain.UnhandledException += this.WorkerThreadUnhandledExceptionHandler;
        }
        #endregion //Unity Messages

        #region Event Handlers
        private void WorkerThreadUnhandledExceptionHandler(object obj, UnhandledExceptionEventArgs args)
        {
            Logging.Exception(args.ExceptionObject as Exception);
        }
        #endregion //Event Handlers
        #endregion//Methods
    }   
}