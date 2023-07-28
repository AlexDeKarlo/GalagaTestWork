using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Settings", menuName = "Settings/New Game Settings")]
public class GameSettings : ScriptableObject
{
    public RangeInt KillsToWinRange;
    public RangeFloat SpawnCooldonwRange;
    public RangeFloat EnemySpeedRange;
    public int EnemyHealh;
    public float PlayerShootRange;
    public float PlayerShootSpeed;
    public float PlayerDamage;
    public float BulletSpeed;
    public float BulletCooldown;
    public float PlayerSpeed;
    public int PlayerHealth;
}

[System.Serializable]
public class RangeInt
{
    public int min;
    public int max;

    public int GetRandomIntInRange()
    {
        return Random.Range(min, max);
    }
}

[System.Serializable]
public class RangeFloat
{
    public float min;
    public float max;
    public float GetRandomFloatInRange()
    {
        return Random.Range(min, max);
    }
}

