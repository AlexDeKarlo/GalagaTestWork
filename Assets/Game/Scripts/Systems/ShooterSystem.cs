using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class ShooterController : MonoBehaviour
{
    [SerializeField]
    private BulletController bullet;
    private CircleCollider2D shootRange;
    private List<EnemyController> enemyControllers = new List<EnemyController>();

    void Start()
    {
        shootRange = GetComponent<CircleCollider2D>();
        shootRange.radius = GameSettingsSystem.Instance.PlayerShootRange;
        StartCoroutine(Shooting());   
    }

    private IEnumerator Shooting()
    {
        while (true)
        {
            if(enemyControllers.Count>0)
            {
                var bullet = Instantiate(this.bullet, this.transform.position, Quaternion.identity);
                EnemyController target = null;
                foreach(EnemyController controller in enemyControllers)
                {
                    if(target == null || Vector3.Distance(target.transform.position,transform.position) > Vector3.Distance(controller.transform.position, transform.position))
                        target = controller;
                }
                bullet.Target = target.transform.position;
            }
            yield return new WaitForSeconds(GameSettingsSystem.Instance.BulletCooldown);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyController>()) enemyControllers.Add(collision.GetComponent<EnemyController>());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyController>()) enemyControllers.Remove(collision.GetComponent<EnemyController>());
    }
}
