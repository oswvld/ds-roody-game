using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalvaPunteggio : MonoBehaviour {

	private string url = "http://demo01.dsit.it/unitygames-test/gioco-natale-2016/salva-punteggio.php";
	private PostResult response;

	public bool testing;

	void Start() {
		if (testing) {
			string nome = "testing";
			float tempo_rimasto = 100f;

			salvaPunteggio(nome, tempo_rimasto);
		}
	}

	void OnCollisionEnter2D(Collision2D other) {

		if (!testing) {
			string nome = "not testing";
			float tempo_rimasto = 100f;

			salvaPunteggio(nome, tempo_rimasto);
		}
	}

	private void success() {
		
		// Qui tutto il codice da eseguire dopo il salvataggio
		Debug.Log("punteggio memorizzato correttamente");

	}


	/* ============================== don't edit ================================ */

		
	public void salvaPunteggio(string nome, float tempo_rimasto) {
		IEnumerator salvaPunteggio = post_salvaPunteggio(nome, tempo_rimasto);
		StartCoroutine (salvaPunteggio);
	}

	private IEnumerator post_salvaPunteggio(string nome, float tempo_rimasto) {
		WWWForm post_salvaPunteggio = new WWWForm();

		post_salvaPunteggio.AddField("nome", nome);
		post_salvaPunteggio.AddField("tempo_rimasto", tempo_rimasto+"");

		WWW www = new WWW(url, post_salvaPunteggio);
		yield return www;

		response = JsonUtility.FromJson<PostResult> (www.text);

		switch(response.stato) {
		case -1: // variabili non inserite
			Debug.Log("Nome e tempo rimasto non passate allo script");
			break;

		case -2: // exception: query count punteggi
			Debug.Log("Exception during counting");
			break;

		case -3: // db full
			Debug.Log("Il database è pieno");
			break;

		case -4: // exception: salvataggio
			Debug.Log("C'è stata una eccezione durante il salvataggio");
			break;

		case 200: // success
			success();
			break;
		}
	}

}
