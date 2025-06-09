using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Prefs
{
     public static void setISFIRST (int a){
        PlayerPrefs.SetInt(consts.ISFIRST,a);
    }

    public static int getISFIRST (){
        return PlayerPrefs.GetInt(consts.ISFIRST,0);
    }

    public static void setISSUCC (int a){
        PlayerPrefs.SetInt(consts.ISSUCC,a);
    }

    public static int getISSUCC (){
        return PlayerPrefs.GetInt(consts.ISSUCC,0);
    }

    public static void setCOM (int a){
        PlayerPrefs.SetInt(consts.COMPLETE,a);
    }

    public static int getCOM (){
        return PlayerPrefs.GetInt(consts.COMPLETE,0);
    }
    
    
}
