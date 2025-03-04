using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using System.IO;
using UnityEngine;
//using static System.Net.Mime.MediaTypeNames;

public class Loader : MonoBehaviour
{
    public string assetName = "Scene";
    public string bundleName = "testbundle";
    
    void Start()
    {
        AssetBundle localAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, bundleName));

        if (localAssetBundle == null)
        {
            Debug.LogError("Failed to load AssetBundle!");
            return;
        }

        GameObject asset = localAssetBundle.LoadAsset<GameObject>(assetName);
        Instantiate(asset);
        localAssetBundle.Unload(false);
    }
}
