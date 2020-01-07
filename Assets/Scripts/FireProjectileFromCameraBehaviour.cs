using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectileFromCameraBehaviour : MonoBehaviour
{
    public GameObject projectileToFire;
    private float reloadTimer = 0;
    public float reloadSpeed;

    // Update is called once per frame
    void Update()
    {
        reloadTimer += Time.deltaTime;
        
        if (reloadTimer < reloadSpeed)
            return;
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        
        if (Input.GetMouseButtonDown(0))
        { 
             Physics.Raycast(ray, out hitInfo, 1000);
             GameObject Projectile = Instantiate(projectileToFire, transform);
             Projectile.transform.LookAt(hitInfo.point);

             reloadTimer = 0;
        }
    }
    
}
