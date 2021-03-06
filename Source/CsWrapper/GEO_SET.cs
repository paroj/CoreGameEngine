/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class GEO_SET : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GEO_SET(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GEO_SET obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GEO_SET() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_GEO_SET(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_f32 BatchMax {
    set {
      testPINVOKE.GEO_SET_BatchMax_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.GEO_SET_BatchMax_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 BatchStart {
    set {
      testPINVOKE.GEO_SET_BatchStart_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.GEO_SET_BatchStart_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 ImposterMax {
    set {
      testPINVOKE.GEO_SET_ImposterMax_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.GEO_SET_ImposterMax_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 ImposterStart {
    set {
      testPINVOKE.GEO_SET_ImposterStart_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.GEO_SET_ImposterStart_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 PageSize {
    set {
      testPINVOKE.GEO_SET_PageSize_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.GEO_SET_PageSize_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 HeightMin {
    set {
      testPINVOKE.GEO_SET_HeightMin_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.GEO_SET_HeightMin_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 WidthMin {
    set {
      testPINVOKE.GEO_SET_WidthMin_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.GEO_SET_WidthMin_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 HeightMax {
    set {
      testPINVOKE.GEO_SET_HeightMax_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.GEO_SET_HeightMax_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 WidthMax {
    set {
      testPINVOKE.GEO_SET_WidthMax_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.GEO_SET_WidthMax_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool isInfinte {
    set {
      testPINVOKE.GEO_SET_isInfinte_set(swigCPtr, value);
    } 
    get {
      bool ret = testPINVOKE.GEO_SET_isInfinte_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_Entity Entity {
    set {
      testPINVOKE.GEO_SET_Entity_set(swigCPtr, SWIGTYPE_p_Entity.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.GEO_SET_Entity_get(swigCPtr);
      SWIGTYPE_p_Entity ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Entity(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_String MeshName {
    set {
      testPINVOKE.GEO_SET_MeshName_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.GEO_SET_MeshName_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String MaterialName {
    set {
      testPINVOKE.GEO_SET_MaterialName_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.GEO_SET_MaterialName_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String DensityMap {
    set {
      testPINVOKE.GEO_SET_DensityMap_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.GEO_SET_DensityMap_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_String PhysicsProfile {
    set {
      testPINVOKE.GEO_SET_PhysicsProfile_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.GEO_SET_PhysicsProfile_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public GEO_SET.GEO_LOAD_TYPE GeoType {
    set {
      testPINVOKE.GEO_SET_GeoType_set(swigCPtr, (int)value);
    } 
    get {
      GEO_SET.GEO_LOAD_TYPE ret = (GEO_SET.GEO_LOAD_TYPE)testPINVOKE.GEO_SET_GeoType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_VectorT_Core__GEO_SET_SUBSET_t Objects {
    set {
      testPINVOKE.GEO_SET_Objects_set(swigCPtr, SWIGTYPE_p_VectorT_Core__GEO_SET_SUBSET_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.GEO_SET_Objects_get(swigCPtr);
      SWIGTYPE_p_VectorT_Core__GEO_SET_SUBSET_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_VectorT_Core__GEO_SET_SUBSET_t(cPtr, false);
      return ret;
    } 
  }

  public GEO_SET() : this(testPINVOKE.new_GEO_SET(), true) {
  }

  public enum GEO_LOAD_TYPE {
    GLT_TREE_3D = 0,
    GLT_TREE_2D = 1,
    GLT_GRASS = 2,
    GLT_BUSH = 3,
    GLT_TREE_3DP = 4
  }

}
