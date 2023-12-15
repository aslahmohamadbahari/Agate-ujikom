using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using UnityEngine;
using UnityEngine.UI;

public class AnimalController : MonoBehaviour
{
    public Text score;

    int cek = 0;

    private void Start()
    {
       score.text = cek.ToString();
    }
}
