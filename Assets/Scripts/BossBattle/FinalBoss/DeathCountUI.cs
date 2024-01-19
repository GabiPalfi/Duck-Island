using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCountUI : MonoBehaviour
{
    public TextMeshProUGUI Text;
    
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = GameManager.lastLevelDeathCount.ToString();
    }
}
