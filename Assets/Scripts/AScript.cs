using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AScript : MonoBehaviour {

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private MeshFilter _meshFilter;
    private Mesh _mesh;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private IEnumerator Start(){

        _meshFilter = this.gameObject.GetComponent<MeshFilter>();
        _mesh = _meshFilter.mesh;
        
        OpenCS.Code.Set( _mesh );
        
        yield return new WaitForSeconds( 1 );
        
        _meshFilter.mesh = OpenCS.Code.Get();
        
    }

}