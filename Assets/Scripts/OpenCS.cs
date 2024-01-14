using UnityEngine;

public class OpenCS : MonoBehaviour {

    private static OpenCS _openCSharp;
    
    public static OpenCS Code {
        
        get {
            
            if ( _openCSharp != null ) return _openCSharp;
            
            _openCSharp = new GameObject( "OpenCS" ).AddComponent<OpenCS>();
            DontDestroyOnLoad( _openCSharp.gameObject );

            return _openCSharp;
            
        }
        
    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private Mesh _mesh;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public void Set( Mesh mesh ) => _mesh = mesh;

    public Mesh Get(){ return _mesh; }

}