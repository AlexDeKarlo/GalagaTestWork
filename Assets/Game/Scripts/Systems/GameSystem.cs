using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    [SerializeField]
    private int remainedKills;
    [SerializeField]
    private int health;

    public event Action OnRemainedKillsEnded;
    public event Action OnHealthEnded;

    public event Action<int> OnReciveDamage;

    public static GameSystem Instance;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        remainedKills = GameSettingsSystem.Instance.KillsToWinRange;
        health = GameSettingsSystem.Instance.PlayerHealth;
    }

    public void EnemyKilled()
    {
        remainedKills--;
        if (remainedKills <= 0) OnRemainedKillsEnded?.Invoke();
    }

    public void ReciveDamage()
    {
        health--;
        OnReciveDamage?.Invoke(health);
        if (health <= 0) OnHealthEnded?.Invoke();
    }
}
