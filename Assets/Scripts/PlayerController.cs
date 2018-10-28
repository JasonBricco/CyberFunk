﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	// The player's current gun.
	private Gun gun;

	public int health; // the health of the player

    // Returns the health of the player
    public int getHealth()
    {
        return health;
    }

    // Sets the health of the player
    public void setHealth(int health)
    {
        this.health = health;
    }

	public float getBulletSpeed()
	{
		return gun.speed;
	}

	public void setBulletSpeed(float speed)
	{
		gun.speed = speed;
	}

	/**
     * Start
     * Initializes the health and bulletSpeed variables
     */
	void Start()
	{
		health = 100;
		gun = GetComponent<Gun>();
	}

	// Changes the gun type to the type specified by T.
	private void ChangeGun<T>() where T: Gun
	{
		Destroy(gun);
		gun = gameObject.AddComponent<T>();
		Debug.Log("Gun changed to " + typeof(T).FullName);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1)) ChangeGun<Pistol>();
		if (Input.GetKeyDown(KeyCode.Alpha2)) ChangeGun<Shotgun>();
		if (Input.GetKeyDown(KeyCode.Alpha3)) ChangeGun<SMG>();
		if (Input.GetKeyDown(KeyCode.Alpha4)) ChangeGun<Sniper>();
		if (Input.GetKeyDown(KeyCode.Alpha5)) ChangeGun<Minigun>();
	}
}
