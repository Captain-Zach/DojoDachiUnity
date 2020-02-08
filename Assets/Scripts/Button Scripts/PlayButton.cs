using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public Dachi dachi;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(Play);
    }

    void Play()
    {
        // string feedBack;
        if(dachi.Energy < 5){
            Debug.Log("Can't play, too tired!");
            string feedBack = $"Your Dachi is too tired to play!";
            text.text = feedBack;
            return;
        }
        if ((int)Random.Range(1,4) == 1) {
            Debug.Log("Play failed.");
            dachi.Energy -= 5;
            string feedBack = $"Play failed! -5 Energy!";
            text.text = feedBack;
            return;
        }
        else{
        dachi.Energy -= 5;
        int changeNum = Random.Range(5,10);
        dachi.Happiness += changeNum;
        string feedBack = $"You played with your Dachi! Happiness +{changeNum}, Energy -5.";
        text.text = feedBack;
        }


    }
}
