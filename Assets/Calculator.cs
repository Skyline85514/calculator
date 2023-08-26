using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField Liniya1;
    public InputField Liniya2;
    public Text result;

    public void Summ()
    {
        result.text = Liniya1.text + Liniya2.text;

    } }