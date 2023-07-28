using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private int health;
    private float speed;

    private Action OnDieShield;
    private Action OnDieBullet;

    private void Awake()
    {
        OnDieShield += () => GameSystem.Instance.ReciveDamage();
        OnDieBullet += () => GameSystem.Instance.EnemyKilled();
    }

    void Start()
    {
        health = GameSettingsSystem.Instance.EnemyHealh;
        speed = GameSettingsSystem.Instance.EnemySpeedRange.GetRandomFloatInRange();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 1), speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shield"))
        {
            OnDieShield?.Invoke();
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            health--;
            if (health <= 0)
            {
                OnDieBullet?.Invoke();
                Destroy(this.gameObject);
            }
        }
    }
}
