using System;
using System.Collections;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
   public GunData gunData;
   
   public int currentAmmo = 0;
   
   private float _nextTimeToFire = 0;

   protected bool IsFiring { get; set; }
   protected bool IsReloading { get; set; }
   protected bool OutOfAmmo { get; set; }
   

   
   public virtual void Awake()
   {
      // set the mesh and model to the mesh in gun data
      gameObject.GetComponentInChildren<MeshFilter>().mesh = gunData.gunModel.GetComponent<MeshFilter>().sharedMesh;
      gameObject.GetComponentInChildren<MeshRenderer>().materials = gunData.gunModel.GetComponent<MeshRenderer>().sharedMaterials;
   }
   public virtual void Start()
   {
      currentAmmo = gunData.magazineSize;
      

      Debug.Log(gunData.gunName + " Loaded, Ammo: " + currentAmmo);
   }

   public virtual void Update()
   {
      HandleUI(); 
   }
   
   protected void TryReload()
   {
      if (IsReloading)
      {
         
         return;
      }
      
      StartCoroutine(Reload());
   }
   
   private IEnumerator Reload()
   {
      IsReloading = true;
      
      yield return new WaitForSeconds(gunData.reloadTime);
      
      currentAmmo = gunData.magazineSize;
      
      IsReloading = false;
      
      OutOfAmmo = false;
      
   }

   
   protected void TryShoot()
   {
      if (Time.time < _nextTimeToFire)
      {
         return;
      }
      
      if (IsReloading)
      {
         
         Debug.Log(gunData.gunName + " is reloading");
         
         return;
      }
      
      if (currentAmmo <= 0)
      {
         OutOfAmmo = true;
         return;
         
      }
      
      _nextTimeToFire = Time.time + (1f / gunData.fireRate);
      
      
      HandleShoot();
      
      
      
      
   }
   
   private void HandleUI()
   {
     
         
      
      
   }

   private void HandleShoot()
   {
      currentAmmo--;
      Shoot();
   }
   

   protected abstract void Shoot();

}
