using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Analytics;

public class AnalyticsManager
{
    private static void LogEvent(string eventName, params Parameter[] parameters)
    {
        //method utama menambahkan firebase
        FirebaseAnalytics.LogEvent(eventName, parameters);
    }

    public static void LogUpgradeEvent(int resourcesIndex, int level)
    {
        LogEvent(
            FirebaseAnalytics.EventLevelUp,
            new Parameter(FirebaseAnalytics.ParameterIndex, resourcesIndex.ToString()),
            new Parameter(FirebaseAnalytics.ParameterLevel, level)
            );
        //resourceIndex digunakan sbg ID, karena itulah tipe datanya string bukan int
    }

    public static void LogUnlockEvent(int resourceIndex)
    {
        LogEvent(
            FirebaseAnalytics.EventUnlockAchievement,
            new Parameter(FirebaseAnalytics.ParameterIndex, resourceIndex.ToString())
            );
    }

    public static void SetUserProperties(string name, string value)
    {
        FirebaseAnalytics.SetUserProperty(name, value);
    }
}
