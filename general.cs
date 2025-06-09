using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class general
{



    public static void resetSomething()
    {
        Config_level.point = 0;
        Config_level.isNewUnlock = 0;
    }


    public static void minusHP()
    {
        Config_level.hpNow -= 1;
    }

    public static void minusTarget()
    {
        Config_level.pointTargetNow -= 1;
    }


    public static void calTotalTimeSpend()
    {
        float totalTime = 0;
        int totalStar = 0;
        for (int i = 0; i < Config_level.playerData.timeFinishOfStage.Count; i++)
        {

            if (Config_level.playerData.timeFinishOfStage[i] != 0)
            {
                totalTime += Config_level.playerData.timeFinishOfStage[i];
            }
            totalStar += Config_level.playerData.scoreOfStage[i];


        }


        // Debug.Log("TOTALLLL TIME SPENDDDDD::: " + totalTime);

        Config_level.totalTime = totalTime;
        Config_level.totalStar = totalStar;

   }
    
 
}
