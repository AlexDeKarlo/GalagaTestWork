using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject WinUI;
    [SerializeField]
    private GameObject LoseUI;

    void Start()
    {
        GameSystem.Instance.OnHealthEnded += () => LoseUI.SetActive(true);
        GameSystem.Instance.OnRemainedKillsEnded += () => WinUI.SetActive(true);
    }
}
