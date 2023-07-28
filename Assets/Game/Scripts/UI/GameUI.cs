using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private TMPro.TMP_Text healthText;
    void Start()
    {
        healthText.text = $"��������: {GameSettingsSystem.Instance.PlayerHealth}";
        GameSystem.Instance.OnReciveDamage += (e) => healthText.text = $"��������: {e}";
    }
}
