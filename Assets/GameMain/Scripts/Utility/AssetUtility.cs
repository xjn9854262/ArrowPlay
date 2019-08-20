﻿using GameFramework;
using UnityGameFramework.Runtime;

namespace ArrowPlay
{
    public class AssetUtility
    {
        public static string GetSceneAsset(string assetName)
        {
            Log.Debug(assetName);
            return Utility.Text.Format("Assets/GameMain/Scenes/{0}.unity", assetName);
        }

        public static string GetDataTableAsset(string assetName, LoadType loadType)
        {
            return Utility.Text.Format("Assets/GameMain/DataTables/{0}.{1}", assetName, loadType == LoadType.Text ? "txt" : "bytes");
        }

        public static string GetUIFormAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameMain/UI/UIForms/{0}.prefab", assetName);
        }
    }
}

