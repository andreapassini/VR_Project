﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class BounceCounter: MonoBehaviour
    {
        public delegate void OnWallBounce(Vector3 bouncePosition);
        public static event OnWallBounce onWallBounce;

        private Collider _collider;

        private void Start()
        {
            _collider = transform.GetComponent<Collider>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            // Call the event
            if (onWallBounce != null) onWallBounce(collision.transform.position);
        }
    }
}