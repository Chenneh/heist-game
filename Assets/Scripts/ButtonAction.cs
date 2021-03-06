﻿using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    [SerializeField] DoorController doorControlled;
    private string codeEntered;
    private string codeCurrent;
    
    // Start is called before the first frame update
    void Start()
    {
        resetCodes();
    }

    // Update is called once per frame
    void Update()
    {
        bool recievedFlag = doorControlled.PasswordMatchedFlag();
        if (recievedFlag)
        {
            resetCodes();
        }
    }

    public void DebugButtonPress()
    {
        Debug.Log("The button was pressed!");
    }

    public void PressZero()
    {
        Debug.Log("The 0 was pressed!");
        codeCurrent += '0';
    }

    public void PressOne()
    {
        Debug.Log("The 1 was pressed!");
        codeCurrent += '1';
    }

    public void PressTwo()
    {
        Debug.Log("The 2 was pressed!");
        codeCurrent += '2';
    }

    public void PressThree()
    {
        Debug.Log("The 3 was pressed!");
        codeCurrent += '3';
    }

    public void PressFour()
    {
        Debug.Log("The 4 was pressed!");
        codeCurrent += '4';
    }

    public void PressEnter()
    {
        codeEntered = codeCurrent;
        codeCurrent = "";
        Debug.Log("The code entered is = " + codeEntered);
        doorControlled.SenseKeyPad();
    }

    public void PressBack()
    {
        if (codeCurrent.Length == 0) return;
        codeCurrent.Remove(codeCurrent.Length - 1, 1);
    }

    public void PressReset()
    {
        resetCodes();
    }

    public string getCodeEntered()
    {
        return codeEntered;
    }

    private void resetCodes()
    {
        codeCurrent = "";
        codeEntered = "";
    }
}
