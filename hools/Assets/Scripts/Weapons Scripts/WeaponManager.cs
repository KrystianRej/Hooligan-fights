﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

    [SerializeField]
    private WeaponHandler [] _weaponHandlers;

    private int _currentWeapoinIndex;


	// Use this for initialization
	void Start () {
        _currentWeapoinIndex = 0;
        _weaponHandlers [_currentWeapoinIndex].gameObject.SetActive ( true );
	}
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetKeyDown ( KeyCode.Alpha1 ) )
        {
            TurnOnSelectedWeapon ( 0 ); //Axe
        }

        if ( Input.GetKeyDown ( KeyCode.Alpha2 ) )
        {
            TurnOnSelectedWeapon ( 1 ); //Rev
        }

        if ( Input.GetKeyDown ( KeyCode.Alpha3 ) )
        {
            TurnOnSelectedWeapon ( 2 ); //assault rif
        }
    }

    void TurnOnSelectedWeapon(int weaponIndex )
    {
        _weaponHandlers [_currentWeapoinIndex].gameObject.SetActive ( false );

        _weaponHandlers [weaponIndex].gameObject.SetActive ( true );

        _currentWeapoinIndex = weaponIndex;
    }

    public WeaponHandler GetCurrentWeaponHandler()
    {
        return _weaponHandlers [_currentWeapoinIndex];
    }
}
