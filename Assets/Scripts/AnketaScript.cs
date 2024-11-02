using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMP;

public class AnketaScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField NameInputField;
    public TMP_Text nametext;


    // Update is called once per frame
    public void OnButtonUserName()
    {
        nametext.text = NameInputFieldText;
    }
}
