using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPSPManager : MonoBehaviour
{
    public TMP_InputField strengthInput;
    public TMP_InputField toughnessInput;
    public TMP_InputField dexterityInput;
    public TMP_InputField intellectInput;
    public TMP_InputField powerInput;
    public TMP_InputField charmInput;

    public TextMeshProUGUI HP;
    public TextMeshProUGUI SP;

    public int Health;
    public int Spells;

    // Start is called before the first frame update
    void Start()
    {
        Health = int.Parse(HP.text);
        Spells = int.Parse(SP.text);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            if (int.Parse(strengthInput.text) > 0 && int.Parse(strengthInput.text) <= 50)
            {
                
                Health = (15 * int.Parse(strengthInput.text));
                Spells = (10 * int.Parse(strengthInput.text));

            } if (int.Parse(toughnessInput.text) > 0 && int.Parse(strengthInput.text) <= 50)
            
                
                Health = (25 * int.Parse(toughnessInput.text));
                Spells = (0 * int.Parse(toughnessInput.text));

            } if (int.Parse(dexterityInput.text) > 0 && int.Parse(strengthInput.text) <= 50)
            {
                
                Health = (10 * int.Parse(dexterityInput.text));
                Spells = (15 * int.Parse(dexterityInput.text));

            } if (int.Parse(intellectInput.text) > 0 && int.Parse(strengthInput.text) <= 50)
            {
                
                Health = (0 * int.Parse(intellectInput.text));
                Spells = (25 * int.Parse(intellectInput.text));

            }  if (int.Parse(powerInput.text) > 0 && int.Parse(strengthInput.text) <= 50)
            {
                Health = (20 * int.Parse(powerInput.text));
                Spells = (5 * int.Parse(powerInput.text));

            }  if (int.Parse(charmInput.text) > 0 && int.Parse(strengthInput.text) <= 50)
            {

                Health = (5 * int.Parse(charmInput.text));
                Spells = (20 * int.Parse(charmInput.text));

            } if (int.Parse(strengthInput.text) == 0 && int.Parse(toughnessInput.text) == 0 && int.Parse(dexterityInput.text) == 0 
            && int.Parse(intellectInput.text) == 0 && int.Parse(powerInput.text) == 0 && int.Parse(charmInput.text) == 0) {

                Health = 1;
                Spells = 1;
            }



            HP.text = Health.ToString();
            SP.text = Spells.ToString();

        }
    
}
