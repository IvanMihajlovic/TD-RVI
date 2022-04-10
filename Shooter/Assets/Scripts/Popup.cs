using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private HPElement playerHealthBar;
    [SerializeField] private RectTransform contentHolder;
    [SerializeField] private Sprite playerImage;
    [SerializeField] private Color playerHealthColor;
    [SerializeField] private Sprite enemyImage;
    [SerializeField] private Color enemyHealthColor;
    [SerializeField] private GameObject healthBarObjectPrefab;

    void OnEnable()
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerHealthBar.SetPlayerImage(playerImage);
        playerHealthBar.SetHealthBar((float)player.health/(float)100, playerHealthColor);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Zombie");
        int counter = 0;
        for (int i=0; i<enemies.Length; i++)
        {
            GameObject enemyHealthBarObject = Instantiate(healthBarObjectPrefab, GameObject.FindGameObjectWithTag("UICanvas").transform);
            Enemy enemy = enemies[i].GetComponent<Enemy>();
            HPElement enemyHealthBar = enemyHealthBarObject.GetComponent<HPElement>();
            enemyHealthBar.SetPlayerImage(enemyImage);
            enemyHealthBar.SetHealthBar((float)enemy.Health/(float)100, enemyHealthColor);
            counter++;
        }

        Debug.Log(counter);
    }
}
