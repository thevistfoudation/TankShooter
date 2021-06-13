using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class EnemyController : TankController
{
    protected override void onDestroy()
    {
        Items.Instance.Create(0, this.transform.position);
        Observer.Instance.Notify(TOPICNAME.ENEMYDESTROY, levelController.Level);
        Creater.Instance.createExplosion(transform.position);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = new Vector3(
        //        Random.Range(-1f,1f),
        //        Random.Range(-1f,1f
        //    )
        // );
        //Move(direction);

        //direction = new Vector3(
        //        Random.Range(-1f, 1f),
        //        Random.Range(-1f, 1f
        //    )
        // );
        //RotateGun(direction);

        //if(Random.Range(0,100)%2 == 0)
        //{
        //    Shoot();
        //}
    }

    protected override void OnLevelUp(int level)
    {
        TankInfo tankInfo = DataController.Instance.enemyVO.LoadTankInfo(level);
        UpdateTank(tankInfo);
    }
}
