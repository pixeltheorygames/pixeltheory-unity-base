using UnityEngine;
using UnityEditor;


namespace Pixeltheory.Editor.Tests
{
    public class SceneCameraTransformCopyTool
    {
        #region Class
        #region Methods
        [MenuItem("Tools/Pixeltheory/Scene Camera/Copy From Coordinates ", false, -1002)]
        private static void CopyFromSceneCameraTransform(MenuCommand command)
        {
            SceneView.lastActiveSceneView.AlignWithView();
        }
        
        [MenuItem("Tools/Pixeltheory/Scene Camera/Copy To Coordinates", false, -1001)]
        private static void CopyToSceneCameraTransform(MenuCommand command)
        {
            GameObject gameObjectToCopyFrom = command.context as GameObject;
            SceneView.lastActiveSceneView.AlignViewToObject(gameObjectToCopyFrom.transform);
        }
        #endregion //Methods
        #endregion //Class
    }
}