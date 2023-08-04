using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public Color notEnoughMoneyColor;
    public Vector3 positionOffset;

	public GameObject turretTemplate;

	[HideInInspector]
	public GameObject turret;

	private void Start()
	{
		turret = null;
	}
	private void Update()
	{
		
	}
	public Vector3 GetBuildPosition ()
	{
		return transform.position + positionOffset;
	}

	void OnMouseDown ()
	{
		if (EventSystem.current.IsPointerOverGameObject())
			return;


		BuildTurret(turretTemplate);
	}

	void BuildTurret (GameObject __turret)
	{
		
		// TODO: Task 3/4 -- Implement build/ upgrade logic.

		GameObject _turret = Instantiate(__turret, GetBuildPosition(), Quaternion.identity);
		turret = _turret;
		Debug.Log("Turret build!");
	}


	public void SellTurret ()
	{
		// TODO: Line 59

		Destroy(turret);
	}



}
