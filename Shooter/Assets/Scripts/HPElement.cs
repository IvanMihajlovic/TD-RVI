using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPElement : MonoBehaviour
{
    [SerializeField] public Image playerImage;
    [SerializeField] public Image healtBar;

    public void SetPlayerImage(Sprite image)
    {
        playerImage.sprite = image;
    }

    public void SetHealthBar(float amount, Color barColor)
    {
        healtBar.fillAmount = amount;
        healtBar.color = barColor;
    }
}
