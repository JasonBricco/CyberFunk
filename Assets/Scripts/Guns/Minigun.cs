﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Minigun : Gun
{
	public float timeBetweenShots;
	public int pelletCount;
    public float spreadAngle;
    public float pelletFireVel = 1;
    public Transform BarrelExit;

	Quaternion pellet;

    private float timestamp;

	protected override void Start()
	{
		speed = 15.0f;
		timeBetweenShots = 0.05f;
		BarrelExit = pc.transform;
		pelletCount = 1;
		spreadAngle = 10.0f;
		pelletFireVel = 400;
		pellet = Quaternion.Euler(Vector3.zero);
	}

	public override void Fire(PlayerController pc)
	{
		if (Time.time >= timestamp)
		{
			// Up
			if (Input.GetButton("Fire1"))
			{
				pc.ChangeFacing(Facing.Back);
				timestamp = Time.time + timeBetweenShots;
				pellet = UnityEngine.Random.rotation;
				Bullet p = CreateBullet(BarrelExit);
				p.transform.rotation = Quaternion.RotateTowards(p.transform.rotation, pellet, spreadAngle);
				p.SetSpeed(speed);
			}

			// Down
			if (Input.GetButton("Fire2"))
			{
				pc.ChangeFacing(Facing.Front);
				timestamp = Time.time + timeBetweenShots;
				pellet = UnityEngine.Random.rotation;
				Bullet p = CreateBullet(BarrelExit);
				p.transform.rotation = Quaternion.RotateTowards(p.transform.rotation, pellet, spreadAngle);
				p.SetSpeed(speed);
			}

			// Left
			if (Input.GetButton("Fire3"))
			{
				pc.ChangeFacing(Facing.Left);
				timestamp = Time.time + timeBetweenShots;
				pellet = UnityEngine.Random.rotation;
				Bullet p = CreateBullet(BarrelExit);
				p.transform.rotation = Quaternion.RotateTowards(p.transform.rotation, pellet, spreadAngle);
				p.SetSpeed(speed);
			}

			// Right
			if (Input.GetButton("Fire4"))
			{
				pc.ChangeFacing(Facing.Right);
				timestamp = Time.time + timeBetweenShots;
				pellet = UnityEngine.Random.rotation;
				Bullet p = CreateBullet(BarrelExit);
				p.transform.rotation = Quaternion.RotateTowards(p.transform.rotation, pellet, spreadAngle);
				p.SetSpeed(speed);
			}
		}
	}
}