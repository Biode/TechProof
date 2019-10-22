
using System;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private Transform spawnPoint;
    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private Rigidbody platformPrefab;
    [SerializeField]
    private float launchForce = 700f;


    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            LaunchProjectile();
        }
        if (Input.GetMouseButtonDown(1))
        {
            SpawnPlatform();
        }
                

    }

    private void LaunchProjectile()
    {
        
            var projectileInstance = Instantiate(
                projectilePrefab,
                firePoint.position,
                firePoint.rotation);

            projectileInstance.AddForce(firePoint.forward * launchForce);
        
    }
    private void SpawnPlatform()
    {

        var platformInstance = Instantiate(
            platformPrefab,
            spawnPoint.position,
            firePoint.rotation);

       

    }
}