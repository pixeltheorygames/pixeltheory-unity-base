using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;
/*
 *  Copied from singelsnick's post:
 *  https://forum.unity.com/threads/made-you-an-amazing-find-missing-scripts-script.1463357/
 *  Modified by Ellis Talley 2024.03.17
 */
namespace Pixeltheory.Editor
{
    public class FindMissingScriptTool : EditorWindow
    {
        private static List<string> missingAssets = new List<string>();
        private static List<GameObject> objectsWithMissingScriptsInCurrentScene = new List<GameObject>();

        [MenuItem("Tools/Find missing scripts")]
        public static void ShowWindow()
        {
            GetWindow(typeof(FindMissingScriptTool));
        }

        private void OnGUI()
        {
            GUILayout.Label("Find Missing Scripts", EditorStyles.boldLabel);
            GUILayout.Space(10);

            GUIStyle myBoxStyle = new GUIStyle(GUI.skin.box);
            myBoxStyle.normal.background = MakeTex(2, 2, new Color(0.6f, 0.6f, 0.6f, 0.5f));

            // Scene block
            GUILayout.BeginVertical(myBoxStyle);
            if (GUILayout.Button("Find in current scene"))
            {
                FindMissingScriptsInCurrentScene();
            }
            GUILayout.Label("Results (Current Scene):", EditorStyles.boldLabel);
            foreach (var go in objectsWithMissingScriptsInCurrentScene)
            {
                if (GUILayout.Button(go.name))
                {
                    EditorGUIUtility.PingObject(go);
                }
            }
            GUILayout.EndVertical();

            GUILayout.Space(20);

            // Assets block
            GUILayout.BeginVertical(myBoxStyle);
            if (GUILayout.Button("Find in prefabs"))
            {
                FindMissingScriptsInPrefabs();
            }
            GUILayout.Label("Results (Prefabs):", EditorStyles.boldLabel);
            foreach (string path in missingAssets)
            {
                if (GUILayout.Button(path))
                {
                    EditorGUIUtility.PingObject(AssetDatabase.LoadAssetAtPath<Object>(path));
                }
            }
            GUILayout.EndVertical();
        }

        private Texture2D MakeTex(int width, int height, Color col)
        {
            Color[] pix = new Color[width * height];
            for (int i = 0; i < pix.Length; i++)
                pix[i] = col;
            Texture2D result = new Texture2D(width, height);
            result.SetPixels(pix);
            result.Apply();
            return result;
        }

        private static void FindMissingScriptsInCurrentScene()
        {
            objectsWithMissingScriptsInCurrentScene.Clear();
            GameObject[] allObjects;
            #if UNITY_6000_0_OR_NEWER
            allObjects = GameObject.FindObjectsByType<GameObject>(FindObjectsInactive.Include, FindObjectsSortMode.None);
            #else
            allObjects = GameObject.FindObjectsOfType<GameObject>();
            #endif            
            foreach (GameObject go in allObjects)
            {
                if (go.transform.parent == null) // Only start with root objects
                {
                    FindMissingScriptsInGameObjectAndChildren(go);
                }
            }
        }

        private static void FindMissingScriptsInGameObjectAndChildren(GameObject go)
        {
            var components = go.GetComponents<Component>();
            bool hasMissingScript = components.Any(c => c == null);
            if (hasMissingScript)
            {
                objectsWithMissingScriptsInCurrentScene.Add(go);
            }
            foreach (Transform child in go.transform) // Recursively check children
            {
                FindMissingScriptsInGameObjectAndChildren(child.gameObject);
            }
        }

        private static void FindMissingScriptsInPrefabs()
        {
            missingAssets.Clear();
            string[] allAssets = AssetDatabase.GetAllAssetPaths();
            foreach (string assetPath in allAssets)
            {
                if (Path.GetExtension(assetPath) == ".prefab")
                {
                    var assetRoot = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
                    var components = assetRoot.GetComponentsInChildren<Component>(true);
                    bool hasMissingScript = components.Any(c => c == null);
                    if (hasMissingScript)
                    {
                        missingAssets.Add(assetPath);
                    }
                }
            }
        }
    }
}