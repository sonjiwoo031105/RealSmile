using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontPush : MonoBehaviour
{
    private float GameTime = 4;
    public Text GameTimeText;
    NextStagePanel nsp;

    void Update()
    {
        if ((int)GameTime == 0)
        {
            nsp = FindObjectOfType<NextStagePanel>();
            nsp.NextPanel();
        }
        else
        {
            GameTime -= Time.deltaTime;
            int i = (int)GameTime;
            string str = i.ToString();
            GameTimeText.text = str;
        }
    }
}
