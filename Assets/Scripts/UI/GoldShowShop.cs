using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GoldShowShop : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public InventoryScript inventory;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = GameManager.goldCount.ToString();
    }
}
