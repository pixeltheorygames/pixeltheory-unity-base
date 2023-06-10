#undef UNITY_EDITOR
#undef DEVELOPMENT_BUILD
using System;
using System.Collections;
using NUnit.Framework;
using Pixeltheory.Debug;
using UnityEngine;
using UnityEngine.TestTools;


namespace Pixeltheory.Tests
{
    public class LoggingTests
    {
        [UnityTest]
        public IEnumerator LogObjectStripTest()
        {
            int testObject = 0;
            Func<object, object> objectPassthru = 
                x => 
                { 
                    Assert.Fail();
                    return x; 
                };
            PixelLog.Log(objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator LogObjectWithContextStripTest()
        {
            GameObject testContextObject = new GameObject();
            float testObject = 1.0f;
            Func<object, object> objectPassthru = 
                x => 
                { 
                    Assert.Fail();
                    return x; 
                };
            PixelLog.Log(testContextObject, objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator LogFormatStripTest()
        {
            string format = "{0}";
            Vector2 testObject = Vector2.zero;
            Func<object, object> objectPassthru =
                x =>
                {
                    Assert.Fail();
                    return x;
                };
            PixelLog.Log(format, objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator LogFormatWithContextStripTest()
        {
            GameObject testContextObject = new GameObject();
            string format = "{0}";
            Vector2 testObject = Vector2.one;
            Func<object, object> objectPassthru =
                x =>
                {
                    Assert.Fail();
                    return x;
                };
            PixelLog.Log(testContextObject, format, objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator WarnObjectStripTest()
        {
            char testObject = 'a';
            Func<object, object> objectPassthru = 
                x => 
                { 
                    Assert.Fail();
                    return x; 
                };
            PixelLog.Warn(objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator WarnObjectWithContextStripTest()
        {
            GameObject testContextObject = new GameObject();
            decimal testObject = '7';
            Func<object, object> objectPassthru = 
                x => 
                { 
                    Assert.Fail();
                    return x; 
                };
            PixelLog.Warn(testContextObject, objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator WarnFormatStripTest()
        {
            string format = "{0}";
            Vector3 testObject = Vector3.zero;
            Func<object, object> objectPassthru =
                x =>
                {
                    Assert.Fail();
                    return x;
                };
            PixelLog.Warn(format, objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator WarnFormatWithContextStripTest()
        {
            GameObject testContextObject = new GameObject();
            string format = "{0}";
            Vector3 testObject = Vector3.one;
            Func<object, object> objectPassthru =
                x =>
                {
                    Assert.Fail();
                    return x;
                };
            PixelLog.Warn(testContextObject, format, objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator ExceptionStripTest()
        {
            Exception testExcetion = new Exception();
            Func<Exception, Exception> exceptionPassthru =
                x =>
                {
                    Assert.Fail();
                    return x;
                };
            PixelLog.Exception(exceptionPassthru(testExcetion));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator ExceptionWithContextStripTest()
        {
            GameObject testContextObject = new GameObject();
            Exception testExcetion = new Exception();
            Func<Exception, Exception> exceptionPassthru =
                x =>
                {
                    Assert.Fail();
                    return x;
                };
            PixelLog.Exception(testContextObject, exceptionPassthru(testExcetion));
            yield return null;
            Assert.Pass();
        }
       
        [UnityTest]
        public IEnumerator ErrorObjectStripTest()
        {
            string testObject = "testObject";
            Func<object, object> objectPassthru = 
                x => 
                { 
                    Assert.Fail();
                    return x; 
                };
            PixelLog.Error(objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator ErrorObjectWithContextStripTest()
        {
            GameObject testContextObject = new GameObject();
            double testObject = 3.14;
            Func<object, object> objectPassthru = 
                x => 
                { 
                    Assert.Fail();
                    return x; 
                };
            PixelLog.Error(testContextObject, objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator ErrorFormatStripTest()
        {
            string format = "{0}";
            Vector4 testObject = Vector4.zero;
            Func<object, object> objectPassthru =
                x =>
                {
                    Assert.Fail();
                    return x;
                };
            PixelLog.Error(format, objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
        
        [UnityTest]
        public IEnumerator ErrorFormatWithContextStripTest()
        {
            GameObject testContextObject = new GameObject();
            string format = "{0}";
            Vector4 testObject = Vector4.one;
            Func<object, object> objectPassthru =
                x =>
                {
                    Assert.Fail();
                    return x;
                };
            PixelLog.Error(testContextObject, format, objectPassthru(testObject));
            yield return null;
            Assert.Pass();
        }
    }
}
