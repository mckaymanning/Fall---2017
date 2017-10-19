using UnityEngine;

public class APShoot : Shoot
{
    public static float apAmmo;

    public override void Start()
    {
        base.Start();
        
    }


    public override void ShooterHandler()
    {
        if (apAmmo != 0)
        {


            
            if (BulletPool.bullets != null)
                BulletPool.bullets[0].gameObject.layer = LayerMask.NameToLayer("ArmorIgnore");

            base.ShooterHandler();
            apAmmo--;
            
        }
        else
        {
            //Controller.currentGun = "BaseGun";
        }
    }




}
