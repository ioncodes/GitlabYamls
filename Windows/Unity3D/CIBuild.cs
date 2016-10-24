// Create a directory in /Editor/ and create a file called "CIBuild.cs" and put this content in it.
using UnityEngine;
using System.Collections;
using UnityEditor;
 
public class CIBuild : MonoBehaviour
{
    static void Start()
    {
        string[] scenes = { "Assets/Scenes/Menu.unity" };
        BuildPipeline.BuildPlayer(scenes, "build/FILENAME.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}