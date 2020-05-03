using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// the file essentially unreadable by players because its in binary. unlike playerprefs
using System.Runtime.Serialization.Formatters.Binary;
using System.IO; // input/output for saving/loading functionality

public class Manager : MonoBehaviour
{
    public float score;
    public bool level2;
    public Text scoretext;

    // the usual setup for a game manager
    public static Manager manager;

    void Awake()
    {
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }
        else if (manager != this)
        {
            Destroy(gameObject);
        }
    }

    public void ScoreChange(int changeVal)
    {
        score += changeVal;
        scoretext.text = score.ToString();
    }

    // you could call this function in OnDisable() to auto save data
    public void Save()  // because it's public you can call Save() from other scripts 
    {
        // create a file and push data to it
        BinaryFormatter bf = new BinaryFormatter();
        // persistentDataPath = secret filepath in unity, a good place to save stuff you don't want people to save
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        // instantiate the class with current data so you can save it
        PlayerData data = new PlayerData();
        data.score = score;
        data.level2 = level2;
        // write player data to file
        bf.Serialize(file, data);
        // close the file when we finish
        file.Close();
    }

    // could call this in OnEnable() to auto load
    public void Load()
    {
        // check if file exists first
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            // reads it into an object that we've defined as a player data object
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();
            score = data.score;
            level2 = data.level2;

            scoretext.text = score.ToString();
        }
    }

}
// a clean class object/data container to use to save to a file. 
// cant save gameControl class because its a MonoBehavior. This is a clean one that you can serialize.
[Serializable]
class PlayerData
{
    public float score;
    public bool level2;
}