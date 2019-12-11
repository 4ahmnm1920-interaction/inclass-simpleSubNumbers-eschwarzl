using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField ipfVarA;
    public InputField ipfVarB;
    public Button btnSubNumbers;
    public Button btnReset;

    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetOnClick()
    {
        ipfVarA.interactable = true;
        ipfVarB.interactable = true;

        btnSubNumbers.interactable = true;
        btnReset.interactable = false;

        result.text = "Result";
        ipfVarA.text = "";
        ipfVarB.text = "";
    }

    public void SubNumbersOnClick()
    {
      /*index++; 
        Debug.Log("OnClick" + index);
        Debug.Log("inputfield text A is " + ipfVarA.text);
        Debug.Log("inputfield text B is " + ipfVarB.text); */

        int variableA = int.Parse(ipfVarA.text);
        int variableB = int.Parse(ipfVarB.text);
        int subresult = variableA - variableB;
        Debug.Log("Result " + (variableA - variableB));

        result.text = subresult.ToString();

        ipfVarA.interactable = false;
        ipfVarB.interactable = false;

        btnSubNumbers.interactable = false;
        btnReset.interactable = true;
    }
}
