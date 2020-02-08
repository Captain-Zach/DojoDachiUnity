using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SleepButton : MonoBehaviour
{
    public Dachi dachi;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(Sleep);
    }

    void Sleep()
    {
        dachi.Energy += 15;
        dachi.Fullness -= 5;
        dachi.Happiness -= 5;
    }
}
