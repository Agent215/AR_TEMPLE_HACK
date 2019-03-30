using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public class JSONDemo : MonoBehaviour
{
    string path;
    string jsonString;

    private void Start()
    {
        path = Application.streamingAssetsPath + "/Creature.json";
        jsonString = File.ReadAllText(path);
        Creature Yumo = JsonUtility.FromJson<Creature>(jsonString);
        Debug.Log(Yumo.Name);
        Yumo.level = 25;
        string newYumo = JsonUtility.ToJson(Yumo);
        Debug.Log(newYumo);

    }
}


[System.Serializable]
public class Creature
{
    public string Name;
    public int level;
    public int[] Stats;
}
