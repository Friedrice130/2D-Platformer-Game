using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CExtraFuel : Collectable
{
    [Header("Settings")] 
    [SerializeField] private float extraFuel = 10f;
    [SerializeField] private float extraFuelTimer = 10f; // Check the INSPECTOR if it is 10

    private PlayerJetpack _jetpack;

	    public static bool burn_Fuel = true;
    
    protected override void Collect()
    {
        ApplyFuel();
    }

    // Apply that bonus
    private void ApplyFuel()
    {
        _jetpack = _playerMotor.GetComponent<PlayerJetpack>();
        StartCoroutine(IEExtraFuel());
    }

    // Adds fuel 
    private IEnumerator IEExtraFuel()
    {
        burn_Fuel = false;

        yield return new WaitForSeconds(extraFuelTimer);

        burn_Fuel = true;
    }
}
