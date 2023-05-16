using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicClass : MonoBehaviour
{
    [SerializeField] Rigidbody _magicspellobject;
    [SerializeField] float _reload = 1f;
    float nextfiretime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }



    private bool canFire()
    {
        return Time.time >= nextfiretime;
    }

    public void Fire()
    {
        if (canFire())
        {
            nextfiretime = Time.time + _reload;

            var shoot = Instance
        }
    }
}
