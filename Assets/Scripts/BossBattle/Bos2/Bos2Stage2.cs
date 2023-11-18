using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bos2Stage2 : MonoBehaviour
{
    public EnemyTurretScript tourret1;
    public EnemyTurretScript tourret2;
    public EnemyTurretScript tourret3;
    public EnemyTurretScript tourret4;
    
    public void Shoot(){
        tourret1.JustShoot();
        tourret2.JustShoot();
        tourret3.JustShoot();
        tourret4.JustShoot();
    }
}
