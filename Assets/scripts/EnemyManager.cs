using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject coinPrefab;
	public GameObject enenyrefab;
	private float elapsed;
	// Use this for initialization
	void Start () {
		elapsed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;

		if (elapsed >= 0.5) {
			if(Random.value>=0.5){
				Instantiate(coinPrefab,new Vector3(Random.Range(-5f,5f),3.5f,0),coinPrefab.transform.rotation);
			}else{
				Instantiate(enenyrefab,new Vector3(Random.Range(-5f,5f),3.5f,0),enenyrefab.transform.rotation);
			}
			elapsed = 0;

		}
	}
}
