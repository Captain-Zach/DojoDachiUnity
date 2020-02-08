using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkButton : MonoBehaviour
{
    public Dachi dachi;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(Work);
    }

    void Work()
    {
        if(dachi.Energy < 5){
            Debug.Log("Can't work, too tired!");
            return;
        }
        dachi.Meals += Random.Range(1,3);
        dachi.Energy -= 5;

    }
}
