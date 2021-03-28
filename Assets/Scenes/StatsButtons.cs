using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatsButtons : MonoBehaviour
{
    public TextMeshProUGUI statPoints;

    public TMP_InputField statInput;
    public bool textIsChanged;
    public int pointsSubtracted;
    public float timer = 0;

    public int temp;
    public TextMeshProUGUI popup;
    // Start is called before the first frame update
    void Start()
    {

        temp = 0;
        statInput = GetComponent<TMP_InputField>();
        textIsChanged = false;
        //statInput.characterValidation = TMP_InputField.CharacterValidation.Integer;
    }

    void Update()
    {
        if(popup.enabled == true)
        {
            timer += Time.deltaTime;
            if(timer > 3)
            {
                timer = 0;
                popup.enabled = false;
            }
        }
    }

    public void Text_Changed()
    {

        if (int.TryParse(statInput.text, out temp))
        {
            temp = int.Parse(statInput.text);
        } else
        {
            temp = 0;
        }
        
        //temp = int.Parse(str);
        //Debug.Log(temp);

        int tempPoints;
            tempPoints = int.Parse(statPoints.text);

        if (tempPoints - temp >= 0 && pointsSubtracted == 0)
        {
            statPoints.text = (tempPoints - temp).ToString();
            pointsSubtracted = temp;
        } else if (( tempPoints - temp >= 0) && pointsSubtracted > 0)
        {

            statPoints.text = (tempPoints - temp + pointsSubtracted).ToString();
            pointsSubtracted = temp;
        }
        else if (tempPoints - temp < 0)
        {
            
            popup.enabled = true;
        }



    }
}




