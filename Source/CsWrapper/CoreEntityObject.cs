/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CoreEntityObject : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CoreEntityObject(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CoreEntityObject obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CoreEntityObject() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_CoreEntityObject(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public CoreEntityObject() : this(testPINVOKE.new_CoreEntityObject(), true) {
  }

  public SCENE_QUERY_FLAGS QueryType {
    set {
      testPINVOKE.CoreEntityObject_QueryType_set(swigCPtr, (int)value);
    } 
    get {
      SCENE_QUERY_FLAGS ret = (SCENE_QUERY_FLAGS)testPINVOKE.CoreEntityObject_QueryType_get(swigCPtr);
      return ret;
    } 
  }

  public CPlayer Player {
    set {
      testPINVOKE.CoreEntityObject_Player_set(swigCPtr, CPlayer.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CoreEntityObject_Player_get(swigCPtr);
      CPlayer ret = (cPtr == IntPtr.Zero) ? null : new CPlayer(cPtr, false);
      return ret;
    } 
  }

  public CInventoryItem Item {
    set {
      testPINVOKE.CoreEntityObject_Item_set(swigCPtr, CInventoryItem.getCPtr(value));
    } 
    get {
      IntPtr cPtr = testPINVOKE.CoreEntityObject_Item_get(swigCPtr);
      CInventoryItem ret = (cPtr == IntPtr.Zero) ? null : new CInventoryItem(cPtr, false);
      return ret;
    } 
  }

}
