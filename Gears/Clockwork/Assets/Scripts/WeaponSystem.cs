using UnityEngine;
using System.Collections;

public class WeaponSystem : MonoBehaviour 
{
	public Projectile gear;
	public GameObject ProjectileSpawn1, 
			          ProjectileSpawn2 ;
	
	private const float FIRE_RATE = 1f ;
	private float previousFireTime ;
	
	void Start () 
	{
	
	}
	
	void Update () 
	{
		if ((Input.GetAxis("Fire1")!=0) && Time.timeSinceLevelLoad - previousFireTime >= FIRE_RATE)
		{
			shoot ();
			previousFireTime = Time.timeSinceLevelLoad;
		}
	}
		
	public void shoot()
	{
		Instantiate(gear, ProjectileSpawn1.transform.position, ProjectileSpawn1.transform.rotation);
		Instantiate(gear, ProjectileSpawn2.transform.position, ProjectileSpawn2.transform.rotation);
	}
}
