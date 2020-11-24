using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.UI;

public class GoogleLogin : MonoBehaviour
{

    void Start()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
    }

    public void LogIn()
    {
        Social.localUser.Authenticate((bool success) =>
        {
          
        });
    }
    
    public void LogOut()
    {
        ((PlayGamesPlatform)Social.Active).SignOut();
    }
}
