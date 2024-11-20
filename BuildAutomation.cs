using UnityEditor;
using UnityEngine;

public class BuildAutomation : EditorWindow
{
    private string buildFolderPath = "C:\\Users\\x\\x";
    private int numberOfBuilds = 2;

    [MenuItem("Window/Build Automation")]
    public static void ShowWindow()
    {
        GetWindow<BuildWindow>("Build Automation");
    }

    private void OnGUI()
    {
        GUILayout.Label("Build Settings", EditorStyles.boldLabel);

        buildFolderPath = EditorGUILayout.TextField("Build Folder Path", buildFolderPath);
        numberOfBuilds = EditorGUILayout.IntField("Number of Builds", numberOfBuilds);

        if (GUILayout.Button("Start Build"))
        {
            BuildAndRun();
        }
    }

    private void BuildAndRun()
    {
        for (int i = 0; i < numberOfBuilds; i++)
        {
            string buildPath = buildFolderPath + i.ToString() + ".exe";
            BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, buildPath, BuildTarget.StandaloneWindows64, BuildOptions.None);
            Debug.Log("Build Complete: " + buildPath);
            System.Diagnostics.Process.Start(buildPath);
        }
    }
}
    
