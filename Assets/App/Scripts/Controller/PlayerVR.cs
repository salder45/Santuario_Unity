using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.FirstPerson
{
	//Components Require for this script working
	[RequireComponent(typeof (Rigidbody))]
	[RequireComponent(typeof (CapsuleCollider))]
	[RequireComponent(typeof(Animator))]
	public class PlayerVR : MonoBehaviour {

	}
}
