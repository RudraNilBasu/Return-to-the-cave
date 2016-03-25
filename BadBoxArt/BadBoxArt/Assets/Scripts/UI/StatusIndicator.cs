using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatusIndicator : MonoBehaviour {

	[SerializeField]
	private RectTransform healthBarRect;
	[SerializeField]
	private Text healthText;

	void Start()
	{
		if (healthText == null || healthBarRect == null) {
			Debug.LogError ("Not Assigned");
		}
	}

	public void SetHealth(int _curr, int _max)
	{
		float _value = (float)_curr / _max;

		healthBarRect.localScale = new Vector3 (_value, healthBarRect.localScale.y, healthBarRect.localScale.z);

		healthText.text = (_value * 100) + "%";
	}
}
