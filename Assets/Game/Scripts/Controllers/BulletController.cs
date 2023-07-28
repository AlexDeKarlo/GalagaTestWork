using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BulletController : MonoBehaviour
{
    public Vector3 Target;
    private float Damage;
    private float Speed;


    private void Start()
    {
        Damage = GameSettingsSystem.Instance.BulletDamage;
        Speed = GameSettingsSystem.Instance.BulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime);

        if(Target == transform.position) Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
