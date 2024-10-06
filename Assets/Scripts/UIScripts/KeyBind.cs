using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class KeyBind : MonoBehaviour
{
    public Attack attack;
    [SerializeField] private TextMeshProUGUI buttonBL1;
    [SerializeField] private TMP_Text cdText;

    void Start()
    {
        buttonBL1.text = PlayerPrefs.GetString("CutsomKey");
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonBL1.text == "Awaiting Input")
        {
            foreach (KeyCode keycode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(keycode))
                {
                    attack.attackKey = keycode;
                    buttonBL1.text = keycode.ToString();
                    PlayerPrefs.SetString("CustomKey", keycode.ToString());
                    PlayerPrefs.Save();
                    cdText.text = keycode.ToString();
                }
            }
        }
    }

    public void ChangKeys() 
    {
        buttonBL1.text = "Awaiting Input";    
    }


}
