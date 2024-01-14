using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BScript : MonoBehaviour {

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    private MeshFilter _meshFilter;
    
    private Mesh _mesh;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private IEnumerator Start(){
        
        _meshFilter = this.gameObject.GetComponent<MeshFilter>();
        _mesh = _meshFilter.mesh;
        
        yield return new WaitForSeconds( .5f );

        _meshFilter.mesh = OpenCS.Code.Get();
        
        OpenCS.Code.Set( _mesh );

    }

}