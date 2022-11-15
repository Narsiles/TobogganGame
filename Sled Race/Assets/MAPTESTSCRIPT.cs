using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAPTESTSCRIPT : MonoBehaviour
{

    [SerializeField] int levelSizeH;                
    [SerializeField] int numberTOBOGAN;
    [SerializeField] int mapSizeL;
    [SerializeField] int etageSize;
    private List<int> toboganID; 
    private List<int> toboganETAGE;
    private List<Vector3> pointPosition; //la position d'une tel spline a tel etage
    private int altitude = 0;

    // Start is called before the first frame update
    void Start()
    {
        int randomINT1 = 0;
        int randomINT2 = 0;
        int currentTobogan = 0;
        Vector2 randomVECTOR2;

        for (int i = 0; i < levelSizeH; i++)                                                            //creation de position des points, pour la taille du niveau en hanteur, 
        {
            randomINT2 = 0;
            for (int j = 0; j < numberTOBOGAN; j++)                                                     //On créé la carte d'identité de chaque vector (position de point de spine a chaque etage,
            {                                                                                           // ID de toboganb et etage du point
                toboganETAGE.Add(randomINT1);         //tobogan etage fait quelque chose comme (1,1,1,2,2,2,3,3,3,4,4,4 etc) pour trois togogan
                toboganID.Add(randomINT2);            //tobogan ID fait quelque chose comme (1,2,3,1,2,3,1,2,3 etc) pour trois tobogan
                randomINT2++;
            }

            for (int k = 0; k < numberTOBOGAN; k++)                                                     //On remplie nos vector position de chaque etage pour chaque point
            {
                randomVECTOR2 = Random.insideUnitCircle * mapSizeL;
                pointPosition[k] = new Vector3(randomVECTOR2[0], altitude, randomVECTOR2[1]);

            }

            randomINT1++;
            altitude = altitude - etageSize; //on descend d'un srtat
        }

        for(int i = 0; i < toboganETAGE.Count; i++)                                                    // on créé une line qui vas du point precedent au suivant en verifiant d'ettre sur le même togogan
        {
            currentTobogan = 0; //le tobogan que l'on vas dessiner
            if (i == currentTobogan)
            {
                Debug.DrawLine(Vector3.zero, new Vector3(5, 0, 0), Color.white);
                currentTobogan++;
            }
            Debug.DrawLine(Vector3.zero, new Vector3(5, 0, 0), Color.white);
        }

        
    }



    // Update is called once per frame
    void Update()
    {

    }
}
