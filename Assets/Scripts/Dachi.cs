using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dachi : MonoBehaviour
{
    public int Fullness = 0;
    public int Happiness = 0;
    public int Meals = 0;
    public int Energy = 0;

    public List<Button> buttonList;
    public Button reset;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        Fullness = 20;
        Happiness = 20;
        Meals = 3;
        Energy = 50;
        
    }

    public void Reset(){
        Debug.Log("Reset, Dachi side");
        Fullness = 20;
        Happiness = 20;
        Meals = 3;
        Energy = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if(Happiness < 1 || Fullness < 1){
            string feedBack = "Your Dachi has passed away. :(";
            text.text = feedBack;
            foreach(Button btn in buttonList){
                btn.gameObject.SetActive(false);
            }
            reset.gameObject.SetActive(true);
        }
        if(Happiness > 99 && Fullness > 99 && Energy > 99){
            string feedBack = "You won!";
            text.text = feedBack;
            foreach(Button btn in buttonList){
                btn.gameObject.SetActive(false);
            }
            reset.gameObject.SetActive(true);
        }
    }
}
