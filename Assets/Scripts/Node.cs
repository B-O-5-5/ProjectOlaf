using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour {

    public Color hoverColor;
    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;
    UpgradeManager upgradeManager;

    void Start ()
    {

        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
        upgradeManager = UpgradeManager.instance;

    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown()
    {

        if (turret != null)
            upgradeManager.UpgradeTurretOn(this);
        
        if (buildManager.turretToBuild == null)
            return;

        if (turret == null)
            buildManager.BuildTurretOn (this);

        
    }

	void OnMouseEnter ()
    {

        if (!buildManager.CanBuild)
            return;

        rend.material.color = hoverColor;
    }

    void OnMouseExit ()
    {

        rend.material.color = startColor;

    }
}
