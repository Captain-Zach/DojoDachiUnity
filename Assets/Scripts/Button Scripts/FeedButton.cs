using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FeedButton : MonoBehaviour
{
    
    public Dachi dachi;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(Feed);
    }

    void Feed()
    {
        if (dachi.Meals < 1)
        {
            Debug.Log("No meals!  You starve!");
            string feedBack = $"You have no meals!";
            text.text = feedBack;
            return;
        }
        if ((int)Random.Range(1,4) == 1) {
            Debug.Log("Feed failed.");
            dachi.Meals--;
            string feedBack = $"Feeding failed! Meals -1";
            text.text = feedBack;
            return;
        }else {
            int changeNum = (int)Random.Range(5,10);
            dachi.Fullness += changeNum;
            dachi.Meals--;
            string feedBack = $"You fed your Dachi! Fullness +{changeNum}, Meals -1.";
            text.text = feedBack;
        }
    }
}
