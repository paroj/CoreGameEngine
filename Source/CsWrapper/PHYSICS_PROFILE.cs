/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PHYSICS_PROFILE : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PHYSICS_PROFILE(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PHYSICS_PROFILE obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PHYSICS_PROFILE() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          testPINVOKE.delete_PHYSICS_PROFILE(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_String Name {
    set {
      testPINVOKE.PHYSICS_PROFILE_Name_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_String ret = new SWIGTYPE_p_String(testPINVOKE.PHYSICS_PROFILE_Name_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 Restitution {
    set {
      testPINVOKE.PHYSICS_PROFILE_Restitution_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.PHYSICS_PROFILE_Restitution_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 Friction {
    set {
      testPINVOKE.PHYSICS_PROFILE_Friction_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.PHYSICS_PROFILE_Friction_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 Mass {
    set {
      testPINVOKE.PHYSICS_PROFILE_Mass_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.PHYSICS_PROFILE_Mass_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f32 Density {
    set {
      testPINVOKE.PHYSICS_PROFILE_Density_set(swigCPtr, SWIGTYPE_p_f32.getCPtr(value));
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_f32 ret = new SWIGTYPE_p_f32(testPINVOKE.PHYSICS_PROFILE_Density_get(swigCPtr), true);
      if (testPINVOKE.SWIGPendingException.Pending) throw testPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public E_PHYSICS_SHAPE Shape {
    set {
      testPINVOKE.PHYSICS_PROFILE_Shape_set(swigCPtr, (int)value);
    } 
    get {
      E_PHYSICS_SHAPE ret = (E_PHYSICS_SHAPE)testPINVOKE.PHYSICS_PROFILE_Shape_get(swigCPtr);
      return ret;
    } 
  }

  public E_BODY_TYPE BodyType {
    set {
      testPINVOKE.PHYSICS_PROFILE_BodyType_set(swigCPtr, (int)value);
    } 
    get {
      E_BODY_TYPE ret = (E_BODY_TYPE)testPINVOKE.PHYSICS_PROFILE_BodyType_get(swigCPtr);
      return ret;
    } 
  }

  public PHYSICS_PROFILE() : this(testPINVOKE.new_PHYSICS_PROFILE(), true) {
  }

}
