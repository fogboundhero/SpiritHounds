using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GDCDemoloader : MonoBehaviour {

	public AudioClip houseClip;
	public AudioClip barnClip;
	public AudioClip endClip;

	IEnumerator Start() {
		AudioSource audio = GetComponent<AudioSource>();

		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
		audio.clip = houseClip;
		yield return new WaitForSeconds(5);
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
		audio.clip = barnClip;
		yield return new WaitForSeconds(5);
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
		audio.clip = endClip;
		yield return new WaitForSeconds(5);
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Backslash))
		{
			
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

		}
	}
}
