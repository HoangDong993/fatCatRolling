using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerData
{
    public List<int> scoreOfStage;
    public List<float> timeFinishOfStage;
    public int finishAmount;
    
}

public class SaveLoadJSONDATA_RESULT : MonoBehaviour
{
    PlayerData playerData;
    string saveFilePath;

    public int scoreTest;

    void Start()
    {
        playerData = new PlayerData();
        saveFilePath = Application.persistentDataPath + "/PlayerData.json";
        Debug.Log("PATHHHHHHHH: " + saveFilePath);

        LoadGameToConfig();
        general.calTotalTimeSpend();
        // showTest();
    }


    public void SaveGame()
    {
        string savePlayerData = JsonUtility.ToJson(Config_level.playerData);
        File.WriteAllText(saveFilePath, savePlayerData);
    }

    public void LoadGame()
    {
        if (File.Exists(saveFilePath))
        {
            Debug.Log("HAVE FILEEEEEEE");
            string loadPlayerData = File.ReadAllText(saveFilePath);
            playerData = JsonUtility.FromJson<PlayerData>(loadPlayerData);
            setOlds();
        }
        else
        {
            playerData.scoreOfStage = new List<int>();
            playerData.scoreOfStage.Add(0);
            for (int i = 1; i <= Config_level.stageAmount; i++)
            {
                playerData.scoreOfStage.Add(0);
            }
        }
    }


    public void LoadGameToConfig()
    {
        Config_level.playerData = new PlayerData();
        if (File.Exists(saveFilePath))
        {
            Debug.Log("HAVE FILEEEEEEE");
            string loadPlayerData = File.ReadAllText(saveFilePath);
            Config_level.playerData = JsonUtility.FromJson<PlayerData>(loadPlayerData);
            Config_level.finishAmountNow = Config_level.playerData.finishAmount;
            setOlds();
        }
        else
        {
            Config_level.playerData.scoreOfStage = new List<int>();
            Config_level.playerData.timeFinishOfStage = new List<float>();
            Config_level.playerData.scoreOfStage.Add(0);
            for (int i = 1; i <= Config_level.stageAmount; i++)
            {
                Config_level.playerData.scoreOfStage.Add(0);
                Config_level.playerData.timeFinishOfStage.Add(0);
            }
            SaveGame();
        }
    }

    public void DeleteSaveFile()
    {
        if (File.Exists(saveFilePath))
        {
            File.Delete(saveFilePath);
        }
    }

    public void showTest()
    {
        for (int i = 0; i < Config_level.playerData.scoreOfStage.Count; i++)
        {
            Debug.Log(Config_level.playerData.timeFinishOfStage[i]);
        }

        Debug.Log( "FINISHHHH AMOUNTTTT: " + Config_level.playerData.finishAmount);
    }


    public void saveStageNow(int score)
    {
        if (score > Config_level.oldPointNow)
        {
            Debug.Log("STAGEEEEEEEE: " + Config_level.stage);
            Debug.Log("SCOREEEEEEEE: " + score);
            Config_level.playerData.scoreOfStage[Config_level.stage] = score;
        }

        if (Config_level.stage > Config_level.playerData.finishAmount)
        {
            Config_level.playerData.finishAmount = Config_level.stage;
            Config_level.finishAmountNow = Config_level.stage;
        }

        if (score >= Config_level.oldPointNow)
        {
            Config_level.playerData.timeFinishOfStage[Config_level.stage] = Config_level.timeFinishStageNow;
        }


        SaveGame();


        // TEST
        // LoadGameToConfig();
        // showTest();
        

    }


    void setOlds()
    {
        Config_level.oldPointNow = Config_level.playerData.scoreOfStage[Config_level.stage];
        Debug.Log("OLDDDDD: " + Config_level.playerData.scoreOfStage[Config_level.stage]);
    }
}