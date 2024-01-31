using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointSystem : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    private int _points;

    public void AddPoint()
    {
        _points++;
        pointsText.text = _points.ToString();
    }

}
