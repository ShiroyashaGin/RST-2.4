﻿using UnityEngine;
using System.Collections;

namespace Completed {
	public class Wall : MonoBehaviour {
		public AudioClip[] chopSounds;				// audio clips that play when the wall is attacked by the player.
		public Sprite dmgSprite;					// Alternate sprite to display after Wall has been attacked by player.
		public int hp = 3;							// Hit points for the wall.

		private SpriteRenderer spriteRenderer;		// Store a component reference to the attached SpriteRenderer.

		void Awake() {
			// Get a component reference to the SpriteRenderer.
			spriteRenderer = GetComponent<SpriteRenderer>();
		}

		// DamageWall is called when the player attacks a wall.
		public void DamageWall(int loss) {
			// Call the RandomizeSfx function of SoundManager to play one of two chop sounds.
			SoundManager.instance.RandomizeSfx(chopSounds);

			// Set spriteRenderer to the damaged wall sprite.
			spriteRenderer.sprite = dmgSprite;

			// Subtract loss from hit point total.
			hp -= loss;

			// If hit points are less than or equal to zero:
			if (hp <= 0) {
				// Disable the gameObject.
				gameObject.SetActive(false);
			}
		}
	}
}