using UnityEditor;

public class BundleCreate
{
    [MenuItem("Bundles/Build for StandaloneWindows")]
    static void BuildBundlesWindows()
    {
        BuildBundles(BuildTarget.StandaloneWindows);
    }

    [MenuItem("Bundles/Build for StandaloneWindows64")]
    static void BuildBundlesWindows64()
    {
        BuildBundles(BuildTarget.StandaloneWindows64);
    }

    [MenuItem("Bundles/Build for Android")]
    static void BuildBundlesAndroid()
    {
        BuildBundles(BuildTarget.Android);
    }

    [MenuItem("Bundles/Build for IOS")]
    static void BuildBundlesIOS()
    {
        BuildBundles(BuildTarget.iOS);
    }

    [MenuItem("Bundles/Build for WebGL")]
    static void BuildBundlesWebGL()
    {
        BuildBundles(BuildTarget.WebGL);
    }

    static void BuildBundles(BuildTarget buildTarget)
    {
        UnityEngine.Debug.Log("Сборка бандлов " + buildTarget.ToString() + "...");
        string path = EditorUtility.SaveFolderPanel("Save Bundle", "", "");
        if (path.Length != 0)
        {
            BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.None, buildTarget);
        }
    }
}

