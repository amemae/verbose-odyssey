using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
    }
    #endregion

    #region Save and Load
    public static string SAVENAME = "Default";
    private static string path;

    public static void SaveGame()
    {        
        if (File.Exists(path)) File.Delete(path);
        StreamReader sr = new StreamReader(path);
        //        sw.WriteLine(_character.Save_Character());
        sr.Close();
    }

    public static bool LoadGame()
    {
        if (File.Exists(path))
        {
            StreamReader sr = new StreamReader(path);
            // save file = sr.ReadToEnd();
            sr.Close();
            return true;
        }

        return false;
    }


    #endregion

    private void Start()
    {
        path = Application.persistentDataPath + "/" + SAVENAME + "/save.dat";
    }
}
