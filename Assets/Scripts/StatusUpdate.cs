using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusUpdate : MonoBehaviour
{
    Text text;
    public Dachi dachi;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string update = $"Fullness: {dachi.Fullness}   Happiness: {dachi.Happiness}   Meals: {dachi.Meals}   Energy: {dachi.Energy}";
        text.text = update;
    }
}
