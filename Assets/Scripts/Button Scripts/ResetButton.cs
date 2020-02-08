using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResetButton : MonoBehaviour
{
    public Dachi dachi;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(Reset);
    }

    void Reset()
    {
        dachi.Reset();
        foreach(Button btn in dachi.buttonList){
            btn.gameObject.SetActive(true);
        }
        Debug.Log("Reset, button side");
        this.gameObject.SetActive(false);
    }
}
