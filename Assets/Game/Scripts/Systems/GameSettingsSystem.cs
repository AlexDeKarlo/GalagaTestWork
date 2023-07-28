using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettingsSystem : MonoBehaviour
{
    [SerializeField]
    private GameSettings gameSettings;

    public static GameSettingsSystem Instance;

    private int killsToWinRange;
    private RangeFloat spawnCooldonwRange;
    private RangeFloat enemySpeedRange;
    private int enemyHealh;
    private float playerShootRange;
    private float playerShootSpeed;
    private float bulltDamage;
    private float bulletSpeed;
    private float bulletCooldown;
    private float playerSpeed;
    private int playerHealth;

    public int KillsToWinRange { get { return killsToWinRange; } }
    public RangeFloat SpawnCooldonwRange { get { return spawnCooldonwRange; } }
    public RangeFloat EnemySpeedRange { get { return enemySpeedRange; } }
    public int EnemyHealh { get { return enemyHealh; } }
    public float PlayerShootRange { get { return playerShootRange; } }  
    public float PlayerShootSpeed { get { return playerShootSpeed; } }
    public float BulletDamage { get { return bulltDamage; } }
    public float BulletSpeed { get { return bulletSpeed; } }
    public float BulletCooldown { get { return bulletCooldown; } }
    public float PlayerSpeed { get { return playerSpeed; } }
    public int PlayerHealth { get { return playerHealth; } }


    private void Awake()
    {
        Instance = this;
        killsToWinRange = gameSettings.KillsToWinRange.GetRandomIntInRange();
        spawnCooldonwRange = gameSettings.SpawnCooldonwRange;
        enemySpeedRange = gameSettings.EnemySpeedRange;
        enemyHealh = gameSettings.EnemyHealh;
        playerShootRange = gameSettings.PlayerShootRange;
        playerShootSpeed = gameSettings.PlayerShootSpeed;
        bulltDamage = gameSettings.PlayerDamage;
        bulletSpeed = gameSettings.BulletSpeed;
        bulletCooldown = gameSettings.BulletCooldown;
        playerSpeed = gameSettings.PlayerSpeed;
        playerHealth = gameSettings.PlayerHealth;
    }

}
